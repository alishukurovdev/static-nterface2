using StaticInterface2.Exitentikebde;
using StaticInterface2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace StaticInterface2.Model
{
    internal  class Student : ICodeAcademy
    {
        public static int Count  = 0;
        public int Id;
        string _name;
        string _surname;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (CheckName(value))
                {
                    _name = value;
                }
            }
        }
        public string Surname {
            get
            {
                return _surname;
            }
            set
            {
                if (CheckName(value))
                {
                    _surname = value;
                }
            }
        }    
        public string CodeEmail
        {
            get; set;
        }

        public Student(string name, string surname)
        {
           
            Name = name.Capitalize();
            Surname = surname.Capitalize();
            Id = ++Count;
            GenerateEmail();

        }

        public static bool CheckName(string name)
        {
            if (name.Length >2)
            {
                return true;

            }
            else
            {
                Console.WriteLine("The number of letters of the name and surname cannot be less than 2!");
                return false;
            }
        }



        public void GenerateEmail()
        {
          
            string nameLower = Name.ToLower();
            string surnameLower = Surname.ToLower();
            string id = Id.ToString();
            string email = $"{nameLower}.{surnameLower}{id}@code.edu.az";
            CodeEmail = email;
            
        }
    }
}
