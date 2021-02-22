using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Razor_Identity.Models
{
    public enum Status
    {
        On_hold,
        Under_repair,
        Waiting_for_parts,
        Done
    }

    public class RepairOrder
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Repair Status")]
        public Status? Status { get; set; }

        [Required(ErrorMessage = "Hours worked input is required")]
        [Display(Name = "Hours Worked")]
        public int HoursWorked { get; set; }

        [Required(ErrorMessage = "Begin date is required")]
        [Display(Name = "Begin Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BeginDate { get; set; }

        [Required(ErrorMessage = "End date is required")]
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Repair order description is required")]
        [DataType(DataType.MultilineText)]
        [MaxLength(500)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(500)]
        [Display(Name = "Work Report")]
        public string WorkReport { get; set; }

        //All parts
        [Display(Name ="Part 1")]
        public Part Part1 { get; set; }
        [ForeignKey("Id")]
        public int? PartID1 { get; set; }
        [Display(Name ="Quantity Part 1")]
        public int Part1Quantity { get; set; }
    }
}
