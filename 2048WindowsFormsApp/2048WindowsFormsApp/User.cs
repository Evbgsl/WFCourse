﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048WindowsFormsApp
{
    public class User
    {
        public string Name { get; set; }
        public int Result { get; set; }


        public User(string name, int result) 
        {
            Name = name;
            Result = result;        
        }
    }
}
