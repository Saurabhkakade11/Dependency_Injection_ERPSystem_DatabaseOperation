//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERPSystem_DatabaseOperation
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbltraining_course_fees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbltraining_course_fees()
        {
            this.tblStudent_Registration = new HashSet<tblStudent_Registration>();
        }
    
        public int fee_id { get; set; }
        public Nullable<int> course_id { get; set; }
        public string fee_type { get; set; }
        public Nullable<double> fees_amount { get; set; }
        public Nullable<double> gst { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblStudent_Registration> tblStudent_Registration { get; set; }
        public virtual tbltraining_courses tbltraining_courses { get; set; }
    }
}
