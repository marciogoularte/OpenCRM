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
    
    public partial class Object_Fields
    {
        public Object_Fields()
        {
            this.Profile_Object_Fields = new HashSet<Profile_Object_Fields>();
        }
    
        public int ObjectFieldsId { get; set; }
        public Nullable<int> ObjectId { get; set; }
        public string Name { get; set; }
    
        public virtual Object Object { get; set; }
        public virtual ICollection<Profile_Object_Fields> Profile_Object_Fields { get; set; }
    }
}