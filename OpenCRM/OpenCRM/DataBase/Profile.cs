//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenCRM.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profile
    {
        public Profile()
        {
            this.Profile_Object = new HashSet<Profile_Object>();
            this.User = new HashSet<User>();
        }
    
        public int ProfileId { get; set; }
        public string Name { get; set; }
        public string AbbrevationName { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual ICollection<Profile_Object> Profile_Object { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
