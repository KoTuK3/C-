using L11_Task01_DAL.Models;
using L11_Task01_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace L11_Task01_DAL.Services
{
    public class ClientService
    {
        private readonly UnitOfWork _unitOfWork;

        public ClientService()
        {
            _unitOfWork = new UnitOfWork();
        }

        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public Client GetUserByLogin(string login)
        {
            return _unitOfWork.ClientRepository.Get(c => c.Login == login).FirstOrDefault();
        }

        public bool RegisterUser(string login, string password)
        {
            var user = GetUserByLogin(login);

            if (user != null)
                return false;

            var newUser = new Client
            {
                Login = login,
                Password = ComputeSha256Hash(password)                
            };

            _unitOfWork.ClientRepository.Insert(newUser);
            _unitOfWork.Save();

            return true;
        }

        public bool LoginUser(string login, string password)
        {
            var user = GetUserByLogin(login);

            if (user == null)
                return false;

            return user.Password == ComputeSha256Hash(password);
        }
    }
}
