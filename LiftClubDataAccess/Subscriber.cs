//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LiftClubDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subscriber
    {
        public System.Guid SubscriberID { get; set; }
        public System.Guid PersonalID { get; set; }
        public System.Guid Lift { get; set; }
    
        public virtual Lift Lift1 { get; set; }
        public virtual Personal Personal { get; set; }
    }
}