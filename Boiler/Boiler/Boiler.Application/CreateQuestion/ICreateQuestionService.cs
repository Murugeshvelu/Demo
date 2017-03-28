using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boiler.Api.Models;

namespace Boiler.CreateQuestion
{
    public interface ICreateQuestionService
    {
        List<Categories> GetCategories();
    }
}
