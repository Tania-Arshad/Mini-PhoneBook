using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mini_Phone_Book.Models
{
    public class PersonViewModel
    {
        [Required]
        [Display(Name ="ID")]
        public int PersonId { get; set; }
        [Required]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        [Display(Name = "LastName")]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        [Required]
        [Display(Name = "AddedOn")]
        [DataType(DataType.Date)]
        public System.DateTime AddedOn { get; set; }
        [Required]
        [Display(Name = "AddedBy")]
        public string AddedBy { get; set; }
        public string HomeAddress { get; set; }
        [Required]
        [Display(Name = "HomeCity")]
        public string HomeCity { get; set; }
        public string FaceBookAccountId { get; set; }
        public string LinkedInId { get; set; }
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> UpdateOn { get; set; }
        public string ImagePath { get; set; }
        public string TwitterId { get; set; }
        [Required]
        [Display(Name = "EmailID")]
        public string EmailId { get; set; }


       
    }
}