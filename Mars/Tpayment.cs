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
    
    public partial class Tpayment
    {
        public int Id { get; set; }
        public string level { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> take1 { get; set; }
        public Nullable<int> take2 { get; set; }
        public Nullable<int> take3 { get; set; }
        public Nullable<int> take4 { get; set; }
    
        public virtual Tinfo Tinfo { get; set; }
    }
}
