//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbContextPreview
{
    using System;
    using System.Collections.Generic;
    
    public partial class Amount
    {
        public int RecipeID { get; set; }
        public int AmountID { get; set; }
        public Nullable<decimal> MinimumAmount { get; set; }
        public Nullable<decimal> MaximumAmount { get; set; }
        public string Unit { get; set; }
    
        public virtual Recipe Recipe { get; set; }
    }
}
