﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gamebook.Models
{
    public class RoomTexts
    {
        [Key]
        public int Id { get; set; }
        public string text { get; set; }
    }
}
