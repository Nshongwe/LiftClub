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
    
    public partial class Role
    {
        public Role()
        {
            this.Personals = new HashSet<Personal>();
        }
    
        public System.Guid RoleD { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Personal> Personals { get; set; }
    }
}
