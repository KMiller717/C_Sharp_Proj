using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
    


namespace CSharp_Exam_Black{

    public class RSVP
    {
        [Key]

        public int RSVPId {get;set;}

        public int UserId {get;set;}

        public int WeddingId {get;set;}

        public User Guest {get;set;}

        public Wedding Wedding {get;set;}


    }
}