//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Excellent_International_School_Student_List_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class studentTable
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string country { get; set; }
        public string fullName => $"{firstName} {lastName}";

    }
}