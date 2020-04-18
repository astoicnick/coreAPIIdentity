using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data
{
    public class Wisdom
    {
        [Key]
        public int WisdomId { get; set; }
        public string Content { get; set; }
        public string BookID { get; set; }
        public string Author { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
