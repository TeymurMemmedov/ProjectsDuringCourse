using DailyWorks.Models;
using DailyWorks.Controllers;
using DailyWorks.Controllers;
namespace DailyWorks

{
    internal class Program
    {
        static void Main(string[] args)
        {   
            TaskController taskController= new TaskController();
            bool continueCondition = true; 
            // bu bool deyiseni asagidaki while dovrunu aktiv saxlamaq ucundur.(22ci setir)
            // istifadeci 5-e basdiqda (49-cu setir) false olur, while dovru qirilir.
            Console.Write("Proqramdaki funksiyalar:\n\n" +
                    "1-Yeni tapsiriq elave etmek\n" +
                    "2-Tapsiriqlari görmek\n" +
                    "3-Tamamladigin tapsirigi qeyd etmek\n" +
                    "4-Elave etdiyin bir tapsirigi silmek\n" +
                    "5-Proqramdan cixmaq\n\n");

            while (continueCondition==true) {
                Console.Write("Emeliyyat nomresi daxil edin:");
                string operationNumber = Console.ReadLine();
                Console.WriteLine();

                switch (operationNumber)
                {
                    case "1":
                        taskController.CreateTask();
                        Console.WriteLine();
                        break;
                    case "2":
                        taskController.ReadTasks();
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.Write("Bitirmis oldugunuz task-in id-sini daxil edin:");
                        int taskIdForUpdate=int.Parse(Console.ReadLine());
                        taskController.UpdateTask(taskIdForUpdate);
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.Write("Silmek istediyiniz task-in id-sini daxil edin");
                        int taskIdForDelete=int.Parse(Console.ReadLine());
                        taskController.DeleteTask(taskIdForDelete);
                        Console.WriteLine();
                        break;
                    case "5":
                        continueCondition= false;
                        Console.WriteLine("Proqramdan cixildi...");
                        break;
                    default:
                        Console.WriteLine("Lutfen duzgun emeliyyat nomresi daxil edin.");
                        Console.WriteLine();
                        break;



                }

            }
        }
        }
}