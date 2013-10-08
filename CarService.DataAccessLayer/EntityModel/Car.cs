//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarService.DataAccessLayer.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Car
    {
        public Car()
        {
            this.RepairCards = new HashSet<RepairCard>();
        }
    
        public System.Guid Id { get; set; }
        public string RegistrationNumber { get; set; }
        public string FrameNumber { get; set; }
        public string EngineNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Nullable<System.DateTime> ProductionYear { get; set; }
        public string OwnerName { get; set; }
        public int OwnerNumber { get; set; }
    
        public virtual ICollection<RepairCard> RepairCards { get; set; }
    }
}
