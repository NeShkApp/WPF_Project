using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Project.Models;

namespace WPF_Project.Models
{
    public class UserManager
    {
        public static ObservableCollection<User> _DatabaseUsers = new ObservableCollection<User>() {
            /*new User() { Email = "quam@aol.couk", Name = "Erich Fry" },
            new User { Email = "in@yahoo.com", Name = "Virginia Salas" },
            new User { Email = "luctus@google.com", Name = "Alvin Velasquez" },
            new User { Email = "etiam.bibendum@hotmail.edu", Name = "Zia Hutchinson" },
            new User { Email = "augue.porttitor@protonmail.org", Name = "Justin Burch" } };*/

        new User { Email = "quam@aol.couk", Name = "Erich Fry", Sex = "Male", Age = "21"},
        new User { Email = "in@yahoo.com", Name = "Virginia Salas", Sex = "Female", Age = "26" },
        new User { Email = "luctus@google.com", Name = "Alvin Velasquez", Sex = "Male", Age = "32 "},
        new User { Email = "etiam.bibendum@hotmail.edu", Name = "Ziga Hutchinson", Sex = "Female", Age = "40 "},
        new User { Email = "augue.porttitor@protonmail.org", Name = "Justin Burch", Sex = "Male", Age = "25" } };

        public static ObservableCollection<User> GetUsers()
        {
            return _DatabaseUsers;

        }


        public static void AddUser(User user)
        {
            _DatabaseUsers.Add(user);

        }

    }
}