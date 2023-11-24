using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.ComponentModel;

namespace WPF_Project.Models
{
    public class User
    {
        public User()
        {

        }

        public string? Name { get; set; }
        public string? Email { get; set; }

        public string? Sex { get; set; }
        public string? Age { get; set; }
        /*get { return _age; }
        set
        {
            if (value >= 0 && value <= 120)
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
            else
            {
                // Обробка помилок або повідомлення про неправильне значення
                Console.WriteLine("Неправильне значення для віку. Вік повинен бути між 0 і 120.");
            }
        }*/
    }
}
