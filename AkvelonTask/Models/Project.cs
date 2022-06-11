using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using AkvelonTask.Enums;

namespace AkvelonTask.Models
{
    public class Project
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [EnumDataType(typeof(ProjectStatus))]
        public ProjectStatus Status { get; set; }
        public int Priority { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
