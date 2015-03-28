using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LiftClubDataAccess;
namespace LiftClubApi.Models
{
    public class LiftDto
    {
        public LiftDto(Lift lift)
        {
            Lift1 = lift.Lift1;
            CarType = lift.CarType;
            TotalSpace = lift.TotalSpace;
            SpaceAvailable = lift.SpaceAvailable;
            PreferredRace = lift.PreferredRace;
            PreferredGender = lift.PreferredGender;
            MornigPickUpTime= lift.MornigPickUpTime;
            EveningPickUpTim = lift.EveningPickUpTim;
            SuburbFrom = lift.SuburbFrom;
            SuburbTo = lift.SuburbTo;
            Charge = lift.Charge;
            ServiceName = lift.ServiceName;
            Monday = lift.Monday;
            Tuesday = lift.Tuesday;
            Wednesday = lift.Wednesday;
            Thursday = lift.Thursday;
            Friday = lift.Friday;
            Saturday = lift.Saturday;
            Sunday = lift.Sunday;
            Personal = lift.Personal;
            IEnumerable<Subscriber> Subscribers = lift.Subscribers;
        }

        public System.Guid Lift1 { get; set; }
        public string CarType { get; set; }
        public int TotalSpace { get; set; }
        public int SpaceAvailable { get; set; }
        public string PreferredRace { get; set; }
        public Nullable<bool> PreferredGender { get; set; }
        public System.DateTime MornigPickUpTime { get; set; }
        public System.DateTime EveningPickUpTim { get; set; }
        public string SuburbFrom { get; set; }
        public string SuburbTo { get; set; }
        public Nullable<decimal> Charge { get; set; }
        public string ServiceName { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }
          
        public virtual Personal Personal { get; set; }
        public virtual ICollection<Subscriber> Subscribers { get; set; }
    }
}