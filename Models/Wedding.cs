using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using CSharp_Exam_Black.Models;
    


namespace CSharp_Exam_Black{

    public class Wedding
    {
        [Key]

        public int WeddingId {get;set;}

        [Required]
        public string Title {get;set;}

        [Required]
        public DateTime Date {get;set;}
        [Required]

        public string Description {get;set;}
        [Required]
        public int Duration {get;set;}
        public string TimeLabel {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public int UserId {get;set;}

        public User Creator {get;set;}

        public List<RSVP> Attendees {get;set;}




    }



}