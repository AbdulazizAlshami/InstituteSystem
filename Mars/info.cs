//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mars
{
    using System;
    using System.Collections.Generic;
    
    public partial class info
    {
        public info()
        {
            this.courses = new HashSet<course>();
            this.Marks = new HashSet<Mark>();
            this.payings = new HashSet<paying>();
        }
    
        public int serial { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public System.DateTime date { get; set; }
        public Nullable<int> phone { get; set; }
        public string address { get; set; }
        public int number { get; set; }
    
        public virtual ICollection<course> courses { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<paying> payings { get; set; }
    }
}