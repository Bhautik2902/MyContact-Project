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
                DateOfJoining = DateTime.UtcNow,
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
