using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LiftClubDataAccess;
namespace LiftClubApi.Models
{
    public class PersonalDto
    {
        public PersonalDto(Personal person)
        {
            PersonalID = person.PersonalID;
            Name = person.Name;
            CellNumber = person.CellNumber;
            Gender = person.Gender;
            Email = person.Email;
           RoleDescription = person.Role.Description;

        }

        public System.Guid PersonalID { get; set; }
        public string Name { get; set; }
        public string CellNumber { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }
        public System.Guid RoleD { get; set; }
        public String RoleDescription { get; set; }
    }
}