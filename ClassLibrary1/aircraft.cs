//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class aircraft
    {
        public int Aircraftid { get; set; }
        public string Aircraft_model { get; set; }
        public Nullable<int> pid { get; set; }
    
        public virtual pilot pilot { get; set; }
    }
}