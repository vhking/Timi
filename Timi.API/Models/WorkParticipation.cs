using System;

namespace Timi.API.Models
{
    public class WorkParticipation
    {
        public int WPId { get; set; }
        public DateTime? DateTimeIn { get; set; }
        public DateTime? DateTimeOut { get; set; }
        public double Hours { get; set; }
        public double Break { get; set; }
        public string Comment { get; set; }

        //May be removed on a later staget.
        public bool ActiveSession { get; set; }
        
        public Contractor Contractors { get; set; }
        public User Users { get; set; }
        public WorkCategory WorkCategories { get; set; }
        public WorkType WorkTypes { get; set; }
        public Project Projects { get; set; }

    }
}