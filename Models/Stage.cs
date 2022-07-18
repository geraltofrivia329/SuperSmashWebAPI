using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public partial class Stage
    {
        public int Id { get; set; }
        [Required]
        public string StageName { get; set; } = null!;
    }
}
