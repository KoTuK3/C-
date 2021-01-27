using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace L05_Task01
{
    class UserService
    {
        private readonly RentDBEntities _context;
        private readonly HashAlgorithm _algorithm;
        public UserService()
        {
            _context = new RentDBEntities();
            _algorithm = new SHA1CryptoServiceProvider();
        }

        private string ComputeHash(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }

        public bool Registration(string login, string password)
        {
            string passHash = ComputeHash(password, _algorithm);

            var user = new Users 
            { 
                Login = login, 
                Password = passHash 
            };

            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Login(string login, string password)
        {
            string passHash = ComputeHash(password, _algorithm);

            var user = _context.Users.Where(u => u.Login == login && u.Password == passHash).FirstOrDefault();

            return user != null;
        }
    }
}
