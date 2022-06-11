using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AkvelonTask.Enums
{
    public enum ProjectStatus
    {
        [Display(Name = "Not Started")]
        NotStarted,
        Active,
        Completed
    }
}
