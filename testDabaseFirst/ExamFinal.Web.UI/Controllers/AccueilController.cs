using ExamFinal.Models;
using ExamFinal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamFinal.Web.UI.Controllers
{
    public class AccueilController : Controller
    {
        // GET: Accueil
        public ActionResult Index()
        {
            EventService eventService = new EventService();
            EventModel eventModel = new EventModel();
            eventModel.Events = eventService.GetEvents();
            return View(eventModel);
        }
    }
}