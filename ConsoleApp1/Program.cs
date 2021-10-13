using DAL_TestSystem;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
         string conStr=   ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            using (Context context = new Context(conStr))
            {
                Group group = new Group() { Name = "sas" };
                context.Groups.Add(group);
                context.SaveChanges();
            }
        }
    }
}
