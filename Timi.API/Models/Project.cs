using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Timi.API.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]       
        public int Id { get; set; }    
        public string Name { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }      
        public double EstimateMasonry { get; set; }
        public double EstimateTile { get; set; }
        public double EstimateStructural { get; set; }
        public double EstimateExternal { get; set; }
        public double EstimatePlating { get; set; }
        public double EstimateStender { get; set; }
        public double EstimateFinalWork { get; set; }
        public double EstimateGarage { get; set; }
        public double PEstimateAssembly { get; set; }
        public double PEstimateOther { get; set; }
    }
}