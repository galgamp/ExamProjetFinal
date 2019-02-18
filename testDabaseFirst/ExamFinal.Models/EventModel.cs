using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFinal.Models
{
    public class EventModel
    {
        //public int Id { get; set; }
        //public DateTime Date { get; set; }
        //public double EntryFree { get; set; }
        //public double ReduceEntryFree { get; set; }
        //public double? MemberFee { get; set; }
        //public int Capacity { get; set; }
        //public int AssiociationID { get; set; }
        //public int EventTypeId { get; set; }
        //public string Address { get; set; }
        //public string City { get; set; }
        //public string ZipPostalCode { get; set; }
        public List<Event> Events { get; set; }
        public List<Member> Members { get; set; }
        public List<Drink> Drinks { get; set; }
    }
}
