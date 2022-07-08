using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public partial class Character
    {
        public int Id { get; set; }
        [Required]
        public string CharacterName { get; set; } = null!;
    }
}
