using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamFinal.Web.API.Models
{
    public class DrinkTypeModel
    {
        public int Id { get; set; }
        public string Decription { get; set; }
        public double AlcoholContent { get; set; }
    }
}