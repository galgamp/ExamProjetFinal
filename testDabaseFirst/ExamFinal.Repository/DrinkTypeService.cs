using ClassLibrary1;
using ExamFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFinal.Repository
{
    public class DrinkTypeService
    {

        public static List<DrinkTypeModel> Get()
        {
            using (var context = new Db2019EventsStudentEntities())
            {
                return context.DrinkType.Select(d => new DrinkTypeModel() { Decription = d.Description, Id = d.Id, AlcoholContent = (double)d.AlcoholContent }).ToList();
            }
        }
    }
}
