using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaEntrada, minutoEntrada, horaSaida, minutoSaida;


            horaEntrada = int.Parse(Console.ReadLine());
            minutoEntrada = int.Parse(Console.ReadLine());
            horaSaida = int.Parse(Console.ReadLine());
            minutoSaida = int.Parse(Console.ReadLine());
                      
            Console.WriteLine(regraDeTres(horaEntrada, minutoEntrada, horaSaida, minutoSaida));

            Console.ReadKey();

        }


        static int regraDeTres(int HE, int ME, int HS, int MS)
        {
            int res;

            //1=4
            //var=x

            int SEH, MEH, SE;
            int SSH, MSH, SS;

            SEH = HE * 60 * 60;
            //Console.WriteLine("hora entrada:" + SEH);
            MEH = ME * 60;
            //Console.WriteLine("minuto entrada:" + MEH);
            SE = MEH + SEH;
            //Console.WriteLine("total:" + SE);

            SSH = HS * 60 * 60;
            //Console.WriteLine("hora saida:" + SSH);
            MSH = MS * 60;
            //Console.WriteLine("minuto saida:" + MSH);
            SS = MSH + SSH;
            //Console.WriteLine("total saida:" + SS);

            int diference = SS - SE;
            Console.WriteLine("A DIFERENÇA É:"+diference);


            //3600=4
            //var=x

            int p2 = (diference * 4) / 3600;


            res = p2;
            
            return res;
        }

    }
}
