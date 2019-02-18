using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDabaseFirst
{
    public class Class1
    {
        private Db2019EventsStudentEntities db2019EventsStudentEntities;

        public Class1()
        {
            db2019EventsStudentEntities = new Db2019EventsStudentEntities();

            //student only alcool
            db2019EventsStudentEntities.Drink.Where(d => d.DrinkType.AlcoholContent != 0).Select(d => d.MemberId).Distinct().ToList();

            //student event free
            db2019EventsStudentEntities.Participation.Where(p => p.Credit == 0).Select(p => p.MemberId).Distinct().ToList();
        }
    }
}
