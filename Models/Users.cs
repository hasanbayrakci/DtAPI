using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DtAPI.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string token { get; set; }
        public DateTime created_at { get; set; }
    }
}
