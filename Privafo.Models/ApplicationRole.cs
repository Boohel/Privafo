using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privafo.Models
{
    public class ApplicationRole: IdentityRole
    {
        [DataType(DataType.Text)]
        public string? Description { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateModified { get; set; } = DateTime.Now;
    }
}
