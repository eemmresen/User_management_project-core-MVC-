using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AvansasProject.Models
{
    public class Users
    {
        [Key]
        public string ID { get; set; }
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string pass { get; set; }
        public string UserRolID { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BornDate { get; set; }
    }
}
