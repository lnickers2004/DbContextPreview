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
    
    public partial class Recipe
    {
        public Recipe()
        {
            this.Amounts = new HashSet<Amount>();
            this.RecipeIngredients = new HashSet<RecipeIngredient>();
            this.RecipeSteps = new HashSet<RecipeStep>();
        }
    
        public int RecipeID { get; set; }
        public string RecipeName { get; set; }
        public string Source { get; set; }
        public string Headnote { get; set; }
        public Nullable<int> TypeID { get; set; }
        public Nullable<int> CategoryID { get; set; }
    
        public virtual ICollection<Amount> Amounts { get; set; }
        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }
        public virtual ICollection<RecipeStep> RecipeSteps { get; set; }
    }
}
