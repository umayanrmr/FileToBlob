//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConvertToBase64
{
    using System;
    using System.Collections.Generic;
    
    public partial class MWP_THREADCATEGORY
    {
        public MWP_THREADCATEGORY()
        {
            this.MWP_THREADABLE = new HashSet<MWP_THREADABLE>();
        }
    
        public decimal THREADCATEGORYID { get; set; }
        public string THREADCATEGORYNAME { get; set; }
        public string THREADCATEGORYDESC { get; set; }
        public short THREADCATEGORYISBUILTIN { get; set; }
    
        public virtual ICollection<MWP_THREADABLE> MWP_THREADABLE { get; set; }
    }
}
