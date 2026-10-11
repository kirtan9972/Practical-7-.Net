using Practical7.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Practical7.Controllers
{
    public class HomeController : Controller
    {
        public static List<Feedback> feedbackList = new List<Feedback>();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GiveFeedback()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GiveFeedback(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedbackList.Add(feedback);
                return RedirectToAction("ViewFeedback");
            }

            return View(feedback);
        }

        public ActionResult ViewFeedback()
        {
            return View(feedbackList);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteFeedback(int index)
        {
            if (index >= 0 && index < feedbackList.Count)
            {
                feedbackList.RemoveAt(index);
            }

            return RedirectToAction("ViewFeedback");
        }
    }
}