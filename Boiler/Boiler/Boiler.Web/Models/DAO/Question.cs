//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Boiler.Web.Models.DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Question
    {
        public int QuestionId { get; set; }
        public int TenantId { get; set; }
        public long UserId { get; set; }
        public int QuestionTypeId { get; set; }
        public int CategoryId { get; set; }
        public byte[] Question1 { get; set; }
        public int OptionCount { get; set; }
        public bool IsSubQuestion { get; set; }
        public Nullable<int> PkQuestionId { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreateTimeStamp { get; set; }
        public System.DateTime UpdateTimeStamp { get; set; }
    
        public virtual AbpTenant AbpTenant { get; set; }
        public virtual AbpUser AbpUser { get; set; }
        public virtual Category Category { get; set; }
        public virtual QuestionType QuestionType { get; set; }
    }
}
