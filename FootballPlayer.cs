﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP
{
    public class FootballPlayer : Person
    {
        public int Number { get; private set; }
        public int Height { get; private set; }

        public FootballPlayer(string name, int number, int age, int height) : base(name, age)
        {
            Number = number;
            Height = height;
        }
    }
}
