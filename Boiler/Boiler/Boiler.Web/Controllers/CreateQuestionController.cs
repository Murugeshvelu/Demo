using Boiler.Api.Models;
using Boiler.Web.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Boiler.Web.Controllers
{
    public class CreateQuestionController : BoilerControllerBase
    {

        public BoilerEntities _boilerentity = new BoilerEntities();
      
        public ActionResult GetCategories()
        {
            var categories = (from cat in _boilerentity.Categories
                              select new Categories()
                              {
                                  CategoryId = cat.CategoryId,
                                  CategoryName = cat.CategoryName,
                                  IsDeleted = cat.IsDeleted
                              }).Distinct().ToList();

            return Json(categories, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetQuestionType()
        {
            var QuestionTypes = (from ques in _boilerentity.Categories
                                 select new QuestionTypes()
                                 {
                                     QuestionTypeId = ques.CategoryId,
                                     QuestionType = ques.CategoryName,
                                     IsDeleted = ques.IsDeleted
                                 }).Distinct().ToList();

            return Json(QuestionTypes, JsonRequestBehavior.AllowGet);
        }
    }
}