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
    
    public partial class Estate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estate()
        {
            this.Banner = new HashSet<Banner>();
        }
    
        public string EstateId { get; set; }
        public string EstateName { get; set; }
        public string EstatePrice { get; set; }
        public string DiscountPrice { get; set; }
        public string Clicks { get; set; }
        public string IsActive { get; set; }
        public string IsDiscount { get; set; }
        public string EstateAdress { get; set; }
        public string EstateDescription { get; set; }
        public string EstateLocationId { get; set; }
        public string EstateRegDate { get; set; }
        public string EstateEditDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Banner> Banner { get; set; }
    }
}
