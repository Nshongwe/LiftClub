using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using  LiftClubDataAccess;
namespace LiftClubApi.Models
{
    public class RoleDto
    {
        public RoleDto(Role role)
        {
            RoleD = role.RoleD;
            Description = role.Description;
        }

        public System.Guid RoleD { get; set; }
        public string Description { get; set; }
    }
}