//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gurskaia_Tarasiuk_Final
{
    using System;
    using System.Collections.Generic;
    
    public partial class NationalDebt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NationalDebt()
        {
            this.DebtPerYears = new HashSet<DebtPerYear>();
        }
    
        public int id { get; set; }
        public Nullable<int> country_id { get; set; }
        public Nullable<int> indicator_id { get; set; }
    
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DebtPerYear> DebtPerYears { get; set; }
        public virtual Indicator Indicator { get; set; }
    }
}