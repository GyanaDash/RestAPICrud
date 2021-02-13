using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPICrud.Model
{
    public class MyEmployee
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        [MaxLength(20, ErrorMessage = "Name can only be 20 characters long")]
        public string Name { get; set; }
    }
}
