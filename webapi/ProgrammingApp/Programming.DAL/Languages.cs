//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Programming.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Languages
    {
        public int Id { get; set; }
        public string Language { get; set; }
        public string Founder { get; set; }
        [Required(ErrorMessage ="Y�l alan� gerekli")]
        public Nullable<int> Year { get; set; }
        public Nullable<bool> IsPopular { get; set; }
    }
}
