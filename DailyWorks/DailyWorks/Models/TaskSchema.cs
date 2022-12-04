using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWorks.Models
{
    internal class TaskSchema
    // C#-in ozunun de Task adinda bir classi var imis deye TaskSchema qoydum adini, toqqusurdular yoxsa
    {

        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskImportance { get; set; }
        public string TaskTime { get; set; }
        // Default olaraq bir task tamamlanmamis olur, ona gore deyeri basdan verdim.
        public string TaskStatus = "Tamamlanmayib";

        
    }
}
