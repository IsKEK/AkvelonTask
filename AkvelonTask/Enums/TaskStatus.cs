
using System.ComponentModel.DataAnnotations;

namespace AkvelonTask.Enums
{
    public enum TaskStatus
    {
        [Display(Name = "To do")]
        ToDo,
        [Display(Name = "In Progress")]
        InProgress,
        Done
    }
}
