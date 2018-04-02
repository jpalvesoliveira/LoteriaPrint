using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoteriaPrint.Core.Services;
using LoteriaPrint.Domain.Model;
using LoteriaPrint.Domain.Services;

namespace LoteriaPrint.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilhete bilhete;
            IPrintService service;

            bilhete = new MegaSena();
            service = new GDIPrintService();

            bilhete.SortedNumbers = new List<byte>(){ 5, 9, 15, 27, 30, 43 };
            service.Print(bilhete);
        }
    }
}
