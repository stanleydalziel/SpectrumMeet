//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpectrumMeetEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class PrivateMessage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrivateMessage()
        {
            this.PrivateMessage1 = new HashSet<PrivateMessage>();
        }
    
        public int PrivateMessageID { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public System.DateTime PostedDate { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public Nullable<int> ParentPrivateMessageID { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Account Account1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrivateMessage> PrivateMessage1 { get; set; }
        public virtual PrivateMessage PrivateMessage2 { get; set; }
    }
}