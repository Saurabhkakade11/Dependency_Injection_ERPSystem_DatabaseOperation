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
    
    public partial class tbltraining_topics
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbltraining_topics()
        {
            this.tbltopics_Contents = new HashSet<tbltopics_Contents>();
            this.tbltraining_course_topics = new HashSet<tbltraining_course_topics>();
        }
    
        public int topic_id { get; set; }
        public string topic_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbltopics_Contents> tbltopics_Contents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbltraining_course_topics> tbltraining_course_topics { get; set; }
    }
}
