//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chapter03._2_MVC_Entity_TaiKhoan.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccountType
    {
        public AccountType()
        {
            this.Account = new HashSet<Account>();
        }
    
        public int ACCOUNTTYPE1 { get; set; }
        public string TYPENAMENAME { get; set; }
        public string TYPEDESCRIPTION { get; set; }
    
        public virtual ICollection<Account> Account { get; set; }
    }
}
