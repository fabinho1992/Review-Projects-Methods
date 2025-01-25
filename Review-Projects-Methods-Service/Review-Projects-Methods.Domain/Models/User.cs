using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Projects_Methods.Domain.Models
{
    public class User
    {
        public User( string name, string email, DateTime createAt, TypeUserEnum typeUser)
        {
            Id = Guid.NewGuid();    
            Name = name;
            Email = email;
            CreateAt = createAt;
            TypeUser = typeUser;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime CreateAt { get; private set; }
        public TypeUserEnum TypeUser { get; set; }
    }
}
