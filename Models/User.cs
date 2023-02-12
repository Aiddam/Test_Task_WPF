using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Task_WPF.Models
{
    public class User
    {
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        private Enum? _role;

        public string Role
        {
            get { return _role.ToString();}
        }
        public string? Description { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public int Money { get; set; }
        public string FullName
        {
            get {  return $"{Name} {Surname}"; }
        }
        public string Place
        {
            get { return $"{City}, {Country}"; }
        }
        public User(string image,string? name, string? surname, string? email, Enum? role, string? description, string? city, string? country, string? phone, int money)
        {
            Image = image;
            Name = name;
            Surname = surname;
            Email = email;
            _role = role;
            Description = description;
            City = city;
            Country = country;
            Phone = phone;
            Money = money;
        }

    }
}
