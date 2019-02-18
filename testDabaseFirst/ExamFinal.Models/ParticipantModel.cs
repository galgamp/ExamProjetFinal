using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamFinal.Models
{
    public class ParticipantModel
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Credit { get; set; }
    }
}