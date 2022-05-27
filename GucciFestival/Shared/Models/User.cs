﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GucciFestival.Shared.Models
{
    public class User
    {
        public string? Name { get; set; }
        public DateTime? Birthday { get; private set; } = DateTime.Now;
        public string? Email { get; set; }
        public int? Phone { get; private set; }

        public string? Password;
        public int? Competence_id;
        public int? User_id;
        public int? Type_id;
        public string? Type;

        /// <summary>
        /// false for volunteer, true for Coordinator.
        /// </summary>
        //public bool CoordinatorFlag { get; private set; }
        //public User(string name, DateTime birthDate, string email, int tlf, bool coordinatorFlag = false)
        //{
        //    Name = name;
        //    BirthDate = birthDate;
        //    Email = email;
        //    Tlf = tlf;

        //    CoordinatorFlag = coordinatorFlag;
        //}
        public User(string name, string email,DateTime birthday, int phone, string password, int competence_id, int user_id, int type_id, string type)
        {
            Name = name;

            Email = email;
            Phone = phone;
            Password = password;
            Competence_id = competence_id;
            User_id = user_id;
            Type_id = type_id;
            Type = type;
            Birthday = birthday;
        }
        public User()
        {

        }
        
    }
}
