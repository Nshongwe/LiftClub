using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LiftClubApi.Models;
using LiftClubDataAccess;
using LiftClubDataAccess.DataService;
namespace LiftClubApi.Services
{
    

    public interface IPersonDataService
    {
        public List<PersonalDto> PersonList();
        public int PersonalRegister(PersonalDto personalDto);
    }

    public class PersonService : IPersonDataService
    {
        private PersonDataService _personDataService;

        public PersonService()
        {
            _personDataService = new PersonDataService();

        }

        public List<PersonalDto> PersonList()
        {
            var personalList= new List<PersonalDto>();
           _personDataService.PersonList().ToList().ForEach(delegate(Personal person)
           {
               personalList.Add(new PersonalDto(person));
           });

           return personalList;
        }

        public int PersonalRegister(PersonalDto personalDto)
        {
            var person = new Personal
            {
                PersonalID = personalDto.PersonalID,
                Name = personalDto.Name,
                CellNumber = personalDto.CellNumber,
                Gender = personalDto.Gender,
                Email = personalDto.Email,
                Role = personalDto.Role
            };
            return _personDataService.SavePerson(person);
        } 
       
        
    }
}