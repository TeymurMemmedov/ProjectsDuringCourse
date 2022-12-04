using DailyWorks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWorks.Database
{
    internal class ProgramContext
    {   
        // Burda List-dənsə Dictionary istifadə etdim, çünki DeleteTask və UpdateTask+
        //+ ID əsaslı işləyir  və id və taskı bir birinə əlaqəli saxlaya biləcəyim data struktur budur.
        public IDictionary<int, TaskSchema> CompletedTasks = new Dictionary<int, TaskSchema>();
        public IDictionary<int, TaskSchema> IncompletedTasks = new Dictionary<int, TaskSchema>();
       
    }
}
