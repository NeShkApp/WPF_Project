using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WPF_Project.Model
{
    public class Contact : INotifyPropertyChanged
    {
        private string name;
        private string emailAddress;
        private string phoneNumber;
        private int age;
        private string sex;
        private DateTime birthday;

        public string Name
        {
            get 
            { 
                return name; 
            }
            set 
            { 
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public string EmailAddress
        {
            get 
            { 
                return emailAddress; 
            }
            set 
            { 
                emailAddress = value;
                OnPropertyChanged("EmailAdress");
            }
        }

        public string PhoneNumber
        {
            get 
            {
                return phoneNumber; 
            }
            set 
            { 
                phoneNumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }

        public int Age
        {
            get 
            {
                return age; 
            }
            set 
            { 
                age = value;
                OnPropertyChanged("Age");
            }
        }

        public string Sex
        {
            get { return sex; }
            set 
            { 
                sex = value;
                OnPropertyChanged("Sex");
            }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set 
            { 
                birthday = value;
                OnPropertyChanged("Birthday");
            }
        }
        public Contact(string name, string email, string phone, int age, string sex, DateTime birthday)
        {
            Name = name;
            EmailAddress = email;
            PhoneNumber = phone;
            Age = age;
            Sex = sex;
            Birthday = birthday;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
