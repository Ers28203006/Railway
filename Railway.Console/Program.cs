using Railway.DataAccess;
using Railway.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FillingEntities.DatabaseCheck();
            TicketsBuying.Input();
            System.Console.ReadLine();
        }
    }
}
