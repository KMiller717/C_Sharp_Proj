using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using CSharp_Exam_Black.Models;
    


namespace CSharp_Exam_Black{

    public class User
    {
        [Key]

        public int UserId {get;set;}

        [Required]
        [Display(Name = "First Name")]
        [MinLength(2, ErrorMessage = "Must be at least 2 characters")]
        public string FirstName {get;set;}
        [Required]
        [Display(Name = "Last Name")]
        [MinLength(2, ErrorMessage = "Must be at least 2 characters")]
        public string LastName {get;set;}
        [EmailAddress]
        [Required]
        public string Email {get;set;}
        [DataType(DataType.Password)]
        [Required]
        [CustomerPassword]
        public string Password {get; set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string Confirm {get;set;}

        public List<Wedding> CreatedActivities {get;set;}

        public List<RSVP> MyWeddings {get;set;}
    }



}