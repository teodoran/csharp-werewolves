using System;
using System.Collections.Generic;
using System.Text;

namespace Werewolves.Dilemmas
{
    class DataState1
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Fullname { get; private set; }
        
        public DataState1(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
            Fullname = $"{firstname} {lastname}";
        }
    }

    class DataState2
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Fullname()
        {
            return $"{Firstname} {Lastname}";
        }

        public DataState2(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
