using Models_SVOnline.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_SVOnline.DAO
{
    public class UserDao
    {
        private DbContextSV db;
        public UserDao()
        {
            db = new DbContextSV();
        }

        public User login(String user, String pass)
        {
            var result = db.Users.FirstOrDefault(x => x.Username.Contains(user) && x.Password.Contains(pass));
            return result;
            //{
            //    return 0;
            //}
            //else
            //{
            //    return 1;
            //}
        }
        public List<User> ListAll()
        {
            return db.Users.ToList();
        }

        public List<User> ListWhere(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return db.Users.Where(x => x.Username.Contains(keyword) || x.FullName.Contains(keyword) || x.Email.Contains(keyword)).ToList();
            return db.Users.ToList();
        }

        public string Insert(User ent_User)
        {
            db.Users.Add(ent_User);
            db.SaveChanges();
            return (ent_User.Username);
        }

        public User findUser(string userName,string email)
        {
            return db.Users.FirstOrDefault(x => x.Username.Contains(userName) || x.Email.Contains(email));
        } 
    }
}
