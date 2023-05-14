using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string LoginName { get; set; } = null!;

        public string Mail { get; set; } = null!;

        public string? Phone { get; set; }

        public int ALevel { get; set; }

        public string? Password { get; set; }
    }
}
