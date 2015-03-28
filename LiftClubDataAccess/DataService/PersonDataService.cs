using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiftClubDataAccess;
namespace LiftClubDataAccess.DataService
{
    public class PersonDataService
    {
    private liftClubEntities _liftClubEntities;
    public PersonDataService()
        {
            _liftClubEntities = new liftClubEntities();
        }
      
        public List<Personal> PersonList()
        {
            if (_liftClubEntities == null) throw new System.InvalidOperationException("liftClubEntities");
            return _liftClubEntities.Personals.ToList();
        }

        public int SavePerson(Personal personal)
        {
            if (_liftClubEntities == null) throw new System.InvalidOperationException("liftClubEntities");
             _liftClubEntities.Personals.Add(personal);
             return _liftClubEntities.SaveChanges();

        }
}
    

}