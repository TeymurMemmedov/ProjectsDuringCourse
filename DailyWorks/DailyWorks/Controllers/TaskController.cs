using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DailyWorks.Models;
using DailyWorks.Database;
using System.Threading.Tasks;

namespace DailyWorks.Controllers
{   
    internal class TaskController
    { 
        ProgramContext db= new ProgramContext();

        public void CreateTask() { 
            // task adinda obyekt yaradilir
            // Burda TaskId random verilir.
            // Diger Property-ler user terefinden daxil edilir.

            var task= new TaskSchema();
            Random rd = new Random();
            task.TaskId=rd.Next(0,1000);
            Console.Write("Taskin adini daxil edin:");
            task.TaskName = Console.ReadLine();
            Console.Write("Taskin vaciblik derecesini daxil edin:");
            task.TaskImportance = Console.ReadLine();
            Console.Write("Task-a ayiracaginiz saat miqdarini daxil edin:");
            task.TaskTime = Console.ReadLine();

            // database-e yazilir, TaskId:task seklinde
            // TaskId - key, task - valuedir

            db.IncompletedTasks.Add(task.TaskId,task);
            Console.WriteLine("Task ugurla yaradildi");

        }
        public void ReadTasks() {
            // Burda kodun uzun olmasi bezek duzekle elaqedardir.
            // Mahiyyet etibarile ilk olaraq tamamlanmis tasklari, sonra da tamamlanmamislari cap edir.

            Console.WriteLine("Tamamlanmis:\n*********************************************************************************************************");
            Console.WriteLine($"| Task-in İD-si | | Taskin adi | | Task-in vaciblik derecesi | | Taska ayrilan vaxt | | Task-in statusu |");
            Console.WriteLine("*********************************************************************************************************");
            foreach (var completedTask in db.CompletedTasks)
            {
                Console.WriteLine($"|  {completedTask.Value.TaskId}  | |  {completedTask.Value.TaskName}  | |  {completedTask.Value.TaskImportance}  | |  {completedTask.Value.TaskTime} saat  | |  {completedTask.Value.TaskStatus}  |   ");
                Console.WriteLine("*********************************************************************************************************");
            }
            Console.WriteLine();
            Console.WriteLine("Tamamlanmamis:\n*********************************************************************************************************");
            Console.WriteLine($"| Task-in İD-si | | Taskin adi | | Task-in vaciblik derecesi | | Taska ayrilan vaxt | | Task-in statusu |");
            Console.WriteLine("*********************************************************************************************************");
            foreach (var incompletedTask in db.IncompletedTasks)
            {
                Console.WriteLine($"|  {incompletedTask.Value.TaskId}  | |  {incompletedTask.Value.TaskName}  | |  {incompletedTask.Value.TaskImportance}  | |  {incompletedTask.Value.TaskTime} saat  | |  {incompletedTask.Value.TaskStatus}  |   ");
                Console.WriteLine("*********************************************************************************************************");
            }
        }
        public void DeleteTask(int id) {
            
            // Bir taski silmek ucun id-si verilir.
            // Ve dictionary-nin nemetlerinden faydalanaraq hemin id-e uygun gelen task valuesi rahatca silinir.
            db.IncompletedTasks.Remove(id);
            Console.WriteLine("Task ugurla silindi");

        }
        public void UpdateTask(int id) {
            // Tamamlanmis deye isaretlemek istediyimiz taskin id-si verilir
            // Hemin taskin TaskStatusu- "Tamamlanib" olaraq deyisir

            db.IncompletedTasks[id].TaskStatus = "Tamamlanib";

            // Sonra hemin taski Tamamlanmis-lar dictionary-sine elave edirik.
            db.CompletedTasks.Add(id, db.IncompletedTasks[id]);

            // Ve tamamlanmamislardan silirik.
            db.IncompletedTasks.Remove(id);
            
            Console.WriteLine("Taski bitirdiyiniz proqramda qeyd edildi");
        }
        
    }
}
