using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableau_2bis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] jours = new string[7];

            jours[0] = "Lundi";
            jours[1] = "Mardi";
            jours[2] = "Mercredi";
            jours[3] = "Jeudi";
            jours[4] = "Vendredi";
            jours[5] = "Samedi";
            jours[6] = "Dimanche";
            Console.WriteLine(jours[1]);
            Console.WriteLine(jours[4]);
        }
    }
}
