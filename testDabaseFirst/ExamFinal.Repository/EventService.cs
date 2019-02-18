using ClassLibrary1;
using ExamFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFinal.Repository
{
    public class EventService
    {
        public Db2019EventsStudentEntities context { get; set; }
        public EventService()
        {
            context = new Db2019EventsStudentEntities();
        }

        public async Task<List<EventNomModel>> Get()
        {
            return context.Event.Select(e => new EventNomModel() { Id = e.Id, NomAssociation = e.Association.Name }).ToList();
        }

        public List<Event> GetEvents()
        {
            return context.Event.ToList();
        }


    }
}
