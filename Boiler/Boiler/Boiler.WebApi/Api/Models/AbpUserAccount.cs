//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Boiler.Api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AbpUserAccount
    {
        public long Id { get; set; }
        public Nullable<int> TenantId { get; set; }
        public long UserId { get; set; }
        public Nullable<long> UserLinkId { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<System.DateTime> LastLoginTime { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<long> DeleterUserId { get; set; }
        public Nullable<System.DateTime> DeletionTime { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<long> LastModifierUserId { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<long> CreatorUserId { get; set; }
    }
}
