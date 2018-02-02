﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Werewolves.Dilemmas
{
    class DataState
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Fullname()
        {
            return $"{Firstname} {Lastname}";
        }

        public DataState(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
