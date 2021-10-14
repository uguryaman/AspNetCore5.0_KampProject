using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concreate
{
    public class Contact
    {
        [Key]
        public int ContacttId { get; set; }
        [StringLength(100)]

        public string ContactUserName { get; set; }
        [StringLength(250)]

        public string ContactMail { get; set; }
        [StringLength(200)]

        public string ContactSubject { get; set; }
        public string ContactMessage { get; set; }
        public DateTime ContactDate { get; set; }
        public bool ContactStatus { get; set; }

    }
}
