﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOrganizerApplication
{
    public class Notes
    {
        private string username;
        private string notes;
        public Notes(string user, string note)
        {
            this.username = user;
            this.notes = note;
        }
        public string Username { get => username; set => username = value; }
        public string Note { get => notes; set => notes = value; }
        public string toString()
        {
            return username + "," + notes;
        }
    }
}
