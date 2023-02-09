﻿using System.ComponentModel.DataAnnotations;

namespace TheBugTracker.Models
{
    public class TicketType
    {
        public int Id { get; set; }

        [Display(Name ="Type Name")]
        public string Name { get; set; }
    }
}
