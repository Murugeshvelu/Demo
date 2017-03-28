using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boiler.Api.Models;

namespace Boiler.CreateQuestion
{
    public class CreateQuestionService : BoilerAppServiceBase, ICreateQuestionService
    {
        private readonly CreateQuestionService _CreateQuestion;

        public CreateQuestionService(CreateQuestionService createQuestion)
        {
            _CreateQuestion = createQuestion;
        }

        public List<Categories> GetCategories()
        {
            return _CreateQuestion.GetCategories();
        }
    }
}
