//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class inv
    {
        public int id { get; set; }
        public string inv_num { get; set; }
        public Nullable<System.DateTime> purchase { get; set; }
        public Nullable<decimal> cost { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public int contact { get; set; }
    
        public virtual employee employee { get; set; }
    }
}
