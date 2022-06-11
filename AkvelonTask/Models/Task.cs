using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AkvelonTask.Enums;

namespace AkvelonTask.Models
{
    public class Task
    {
        [Required]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [EnumDataType(typeof(Enums.TaskStatus))]
        public Enums.TaskStatus Status { get; set; }
        public int Priority { get; set; }
        public virtual Project Project { get; set; }
    }
}
