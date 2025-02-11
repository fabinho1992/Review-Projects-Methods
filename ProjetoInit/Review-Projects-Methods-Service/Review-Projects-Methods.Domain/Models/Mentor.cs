﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Projects_Methods.Domain.Models
{
    public class Mentor : User
    {
        public Mentor(string name, string email, TypeUserEnum typeUser) : base(name, email, typeUser)
        {
        }

        public List<FeedBack> FeedBacks { get; private set; } = new();
    }
}
