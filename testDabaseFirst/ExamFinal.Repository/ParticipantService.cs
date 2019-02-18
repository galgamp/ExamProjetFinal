using ClassLibrary1;
using ExamFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFinal.Repository
{
    public class ParticipantService
    {
        public Db2019EventsStudentEntities context { get; set; }
        public ParticipantService()
        {
            context = new Db2019EventsStudentEntities();
        }

        public async Task<List<ParticipantModel>> Get(int eventId)
        {
            //return context.Member.Where(m => m.Participation.Where(p => p.EventId == eventId).);
            return null;
        }
    }
}
