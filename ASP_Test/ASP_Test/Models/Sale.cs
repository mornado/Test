//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP_Test.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public int sale_id { get; set; }
        public int book_id { get; set; }
        public System.DateTime sale_date { get; set; }
        public int books_count { get; set; }
        public double price { get; set; }
    
        public virtual Book Book { get; set; }
    }
}