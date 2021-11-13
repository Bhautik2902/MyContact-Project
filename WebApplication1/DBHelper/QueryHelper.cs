using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.EntityModels;
using WebApplication1.Models;

namespace WebApplication1.DBHelper
{                                                                                                                                                                                                                                                                                                                                  
    public class QueryHelper
    {
        private readonly CoreDbContext _context = null;

        public QueryHelper(CoreDbContext context)
        {
            _context = context;
        }

        public async Task<int> addUser (Models.UserModel user)
        {
            // convert password into hash.
            user.password = getHash(user.password);

            // get data of new user from view.
            var newuser = new User()
            {
                FirstName = user.firstname,
                LastName = user.lastname,
                Email = user.Email,
                Gender = user.gender,
                Password = user.password,
                DateOfJoining = DateTime.UtcNow.Date,
            };

            // check if Email address already exists
            if (!isUserExist(user.Email))
            {
                try
                {
                    await _context.User.AddAsync(newuser);
                    await _context.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    Debug.Write(e.Message);
                    return 0;  // in case of connection error.
                }
                return newuser.Userid;
            }
            else
            {
                return -1; // if email already exists.
            }
        }

        // add contact into contact table
        public async Task<int> addContact (ContactModel contact, int uid)  // current user's Id to store in contact table's Userid field.
        {
            var newcontact = new Contacts
            {
                Userid = uid,
                FirstName = contact.firstname,
                LastName = contact.lastname,
                Email = contact.Email,
                Gender = contact.gender,
                Phone = contact.phone,
                Fax = contact.fax,
            };
            try
            {
                await _context.Contacts.AddAsync(newcontact);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Debug.Write(e);
                return 0;
            }
            return newcontact.Id;
        }
        // get user object using user id.
        public UserModel getUser(int id)
        {
            try
            {
                var user = _context.User.Where(m => m.Userid == id).SingleOrDefault();
                /*Here user cannot be null as id will be there for every user who logged in. If server is not connected then it will create 
                   Exception and catch block will be executed. So no need check user is null or not.*/

                // copy data from User to UserModel
                var usermodel = new UserModel
                {
                    userid = user.Userid,
                    firstname = user.FirstName,
                    lastname = user.LastName,
                    Email = user.Email,
                    gender = user.Gender,
                    date_of_register = user.DateOfJoining
                };
                return usermodel;             
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
                return null;
            }
        }

        // get contact object using contact id.
        public ContactModel getContact(int id)
        {
            try
            {
                var contact = _context.Contacts.Where(m => m.Id == id).SingleOrDefault();
                /*Here user cannot be null as id will be there for every user who logged in. If server is not connected then it will create 
                   Exception and catch block will be executed. So no need check user is null or not.*/

                // copy data from User to UserModel
                var contactmodel = new ContactModel
                {
                    id = contact.Id,
                    userid = contact.Userid,
                    firstname = contact.FirstName,
                    lastname = contact.LastName,
                    Email = contact.Email,
                    gender = contact.Gender,
                    phone = contact.Phone,
                    fax = contact.Fax

                };
                return contactmodel;
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
                return null;
            }
        }
       
        // get user id using email and password.
        public int getUserId(string email, string pass)
        {
            try
            {
                var userid = _context.User.Where(m => m.Email == email && m.Password == pass).Select(m => m.Userid).SingleOrDefault();
                return userid;
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
                return 0;
            }

        }
        // get all contact of perticular user.
        public async Task<List<ContactModel>> getAllContacts(int id)
        {
            try
            {
                var contacts = new List<ContactModel>();
                var allContacts = await _context.Contacts.OrderBy(p => p.Id).Where(p => p.Userid == id).ToListAsync();
                if (allContacts?.Any() == true)
                {
                    foreach (var contact in allContacts)
                    {
                        contacts.Add(new ContactModel
                        {
                            id = contact.Id,
                            userid = contact.Userid,
                            firstname = contact.FirstName,
                            lastname = contact.LastName,
                            Email = contact.Email,
                            gender = contact.Gender, 
                        }); 
                    }
                }
                return contacts;
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
                return null;
            }
         }

        // Delete selected contects.
        public async Task<string> deleteSelected(string[] selectedids)
        {
            try
            {
                foreach (var id in selectedids)
                {
                    var contact = await _context.Contacts.FindAsync(Convert.ToInt32(id));
                    _context.Contacts.Remove(contact);
                    await _context.SaveChangesAsync();
                }
                return "success";
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
                return e.Message;
            }
        }

        // delete individual contact
        public async Task<string> deleteIndividual(int c_id)
        {
            try
            {
                var contact = await _context.Contacts.FindAsync(c_id);
                if (contact != null)
                {
                    _context.Contacts.Remove(contact);
                    await _context.SaveChangesAsync();
                    return "Success";      
                }
                else
                {
                    return "Not found";        // Not found
                }
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
                return e.Message;         // error occured
            }
            
        }

        // update contact in database.
        public async Task<string> updateContactDetails(int id, string fname, string lname, string email, string gender, string phone, string fax)
        {
            try
            {
                var contact = await _context.Contacts.FindAsync(id);
                if (contact != null)
                {
                    contact.FirstName = fname;
                    contact.LastName = lname;
                    contact.Email = email;
                    contact.Gender = gender;
                    contact.Phone = phone;
                    contact.Fax = fax;
                    await _context.SaveChangesAsync();
                    _context.Contacts.Update(contact);

                    return "Updated Successfully!";
                }
                else
                {
                    return "Contact not found!";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        // search contacts that match the query
        public async Task<List<ContactModel>> searchContacts(string query, int id)
        {

            if (query == null)    // if query is empty, reset page with all contacts.
            {
                return await getAllContacts(id);
            }
            else
            {
                try
                {
                    var contacts = new List<ContactModel>();
                    //var allMatchedContacts = await _context.Contacts.OrderBy(p => p.Id).Where(p => (p.Id == id && (p.FirstName.Contains(query) || p.LastName.Contains(query)))).ToListAsync();
                    var allMatchedContacts = await _context.Contacts.OrderBy(p => p.Id).Where(p => p.Userid == id && (p.FirstName.Contains(query) || p.LastName.Contains(query))).ToListAsync();
                    if (allMatchedContacts?.Any() == true)
                    {
                        foreach (var contact in allMatchedContacts)
                        {
                            contacts.Add(new ContactModel
                            {
                                id = contact.Id,
                                userid = contact.Userid,
                                firstname = contact.FirstName,
                                lastname = contact.LastName,
                                Email = contact.Email,
                                gender = contact.Gender,
                            });
                        }
                    }
                    return contacts;
                }
                catch (Exception e)
                {
                    Debug.Write(e.Message);
                    return null;
                }
            }
        }
 //============================================================ utility methods.=============================================================
        public bool isUserExist(string targetemail)
        {
            try
            {
                var isExist = _context.User.Any(p => p.Email == targetemail);
                if (isExist) return true;
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
            }
            return false;
        }

        public string getHash(string password)
        {
            // convert password into byte array
            var data = Encoding.ASCII.GetBytes(password);   

            var sha1 = new SHA1CryptoServiceProvider();
            // Apply hash function on byte data.
            var bytedata = sha1.ComputeHash(data);

            // Convert byte array into string.
            string hashedpass = Encoding.ASCII.GetString(bytedata);

            return hashedpass;
        }
        
        public CoreDbContext getDBContext()
        {
            return _context;
        }
    }
}
