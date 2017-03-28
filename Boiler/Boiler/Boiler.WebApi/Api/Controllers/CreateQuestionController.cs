using Abp.WebApi.Controllers;
using Boiler.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boiler.Api.Controllers
{
    public class CreateQuestionController : AbpApiController
    {

        public BoilerEntities _boilerentity = new BoilerEntities();

        public List<Categories> GetCategories()
        {
            var categories = (from cat in _boilerentity.Categories
                              select new Categories()
                              {
                                  CategoryId = cat.CategoryId,
                                  CategoryName = cat.CategoryName,
                                  IsDeleted = cat.IsDeleted
                              }).Distinct()
                              .ToList();
            return categories;
        }

        public List<QuestionTypes> GetQuestionType()
        {
            var QuestionTypes = (from ques in _boilerentity.Categories
                                 select new QuestionTypes()
                                 {
                                     QuestionTypeId = ques.CategoryId,
                                     QuestionType = ques.CategoryName,
                                     IsDeleted = ques.IsDeleted
                                 }).Distinct()
                              .ToList();
            return QuestionTypes;
        }
    }
}
