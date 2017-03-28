using Boiler.CreateQuestion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Boiler.Web.Controllers
{
    public class CreateQuestionController : BoilerControllerBase
    {

        private readonly CreateQuestionService _CreateQuestion;
        public CreateQuestionController()
        {
        }

        public CreateQuestionController(CreateQuestionService createQuestion)
        {
            _CreateQuestion = createQuestion;
        }

        // GET: CreateQuestion
        public ActionResult CreateQuestion()
        {
            return View();
        }


        public ActionResult GetCategories()
        {
            var result = _CreateQuestion.GetCategories();
            return Json(result.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}