using NationalDay_DDD.Domain.Model;
using NationalDay_DDD.Infrastruct.Data.Context;
using System;

namespace NationalDay_DDD
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new UserContext())
            {
                //db.Database.EnsureCreated();
                //db.Users.Add(new User(0,"张三","yunqian8@live.com","13088973729",DateTime.Now.Date.AddDays(-10),new Domain.Models.Address("陕西省","西安市","雁塔区","北街101号")));
                //var count = db.SaveChanges();
                //Console.WriteLine("{0} records saved to database", count);

                //Console.WriteLine();
                //Console.WriteLine("All blogs in database:");
                //foreach (var blog in db.Users)
                //{
                //    Console.WriteLine(" - {0}", blog.Title);
                //}
            }
        }
    }
}
