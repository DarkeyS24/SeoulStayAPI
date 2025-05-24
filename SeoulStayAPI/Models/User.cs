using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SeoulStayAPI.Models
{
    public class User
    {
        public Int64 Id { get; set; }
        public string Guid { get; set; } = string.Empty;
        public Int64 UserTypeId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public bool Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public int FamilyCount { get; set; }
    }
}
