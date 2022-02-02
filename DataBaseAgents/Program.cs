using System;
using System.Linq;
using static DataBaseAgents.DEMOContext;

namespace DataBaseAgents
{
    //Для подключения базы данных в Консоль диспетчера пакетов: Scaffold-DbContext "Server=WIN-IJ2BHUB0FSR;Database=DEMO;Trusted_Connection=True" Microsoft.EntityFrameworkCore.SqlServer
    class Program
    {
        static void Main(string[] args)
        {
            // Создание для добавления
            using (ApplicationContext db = new ApplicationContext())
            {
                Agent user1 = new Agent { Title = "Tom" };
                // Добавление
                db.Users.Add(user1);
            }

            // получение
            using (ApplicationContext db = new ApplicationContext())
            {
                // получаем объекты из бд и выводим на консоль
                var users = db.Users.ToList();
                Console.WriteLine("Данные после добавления:");
                foreach (Agent u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Title}");
                }
            }
            Console.Read();
        }
    }
}
