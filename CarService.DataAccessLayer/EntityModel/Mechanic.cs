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
    
    public partial class Mechanic
    {
        public Mechanic()
        {
            this.RepairCards = new HashSet<RepairCard>();
        }
    
        public System.Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    
        public virtual ICollection<RepairCard> RepairCards { get; set; }
    }
}
