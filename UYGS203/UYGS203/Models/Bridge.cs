//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UYGS203.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bridge
    {
        public string BridgeId { get; set; }
        public string BridgeSubjectId { get; set; }
        public string BridgeStudentId { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
