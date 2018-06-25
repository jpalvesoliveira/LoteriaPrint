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

            //bilhete = new MegaSena();
            bilhete = new Quina();
            service = new GDIPrintService();

            //bilhete.SortedNumbers = new List<byte>() { 1, 2, 8, 11, 71};
            //bilhete.SortedNumbers = new List<byte>() { 1, 2, 11, 21 };
            //bilhete.SortedNumbers = new List<byte>() { 1, 2, 12, 5, 6, 9, 11, 15, 27, 30, 43 };
            bilhete.SortedNumbers = new List<byte>();
            for (byte i = 1; i <= 80; i++)
            {
                bilhete.SortedNumbers.Add(i);
            }
            service.Print(bilhete);
        }
    }
}
