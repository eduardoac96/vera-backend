using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vera.Infrastructure.Models
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get;set; }    
        public string LastName { get; set; } 
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string AvatarUrl {  get; set; }

        public bool IsHost { get; set; }

        public string CreatedAt { get; set;  }

    }
}
