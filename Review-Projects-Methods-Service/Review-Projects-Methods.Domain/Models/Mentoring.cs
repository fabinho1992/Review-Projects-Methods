using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Projects_Methods.Domain.Models
{
    public class Mentoring : User
    {
        public Mentoring(string name, string email, DateTime createAt, TypeUserEnum typeUser) : base(name, email, createAt, typeUser)
        {
        }

        public List<Project> Projects { get; private set; } = new();
    }
}
