using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concreate
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        [StringLength(100)]

        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public string WriterImane { get; set; }

        [StringLength(250)]

        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public bool WriterStatus { get; set; }
    }
}
