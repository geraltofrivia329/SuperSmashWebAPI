﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public partial class System
    {
        public int Id { get; set; }
        [Required]
        public string TypeOfSystem { get; set; } = null!;
    }
}
