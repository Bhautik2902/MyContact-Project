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

        // utility methods.
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
        public async Task<List<UserModel>> getAllUsers()
        {
            try
            {
                var users = new List<UserModel>();
                var allUsers = await _context.User.ToListAsync();
                if (allUsers?.Any() == true)
                {
                    foreach (var user in allUsers)
                    {
                        users.Add(new UserModel
                        {
                            userid = user.Userid,
                            firstname = user.FirstName,
                            lastname = user.LastName,
                            Email = user.Email,
                            gender = user.Gender,
                        });
                    }
                }
                return users;
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
            }
            return null;
        }  
    }
}
