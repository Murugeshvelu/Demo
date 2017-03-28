using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boiler.Api.Models
{
    public class QuestionTypes
    {
        public int QuestionTypeId { get; set; }
        public string QuestionType { get; set; }
        public bool IsDeleted { get; set; }
    }
}
