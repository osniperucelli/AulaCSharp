using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class UtilTeclado
    {
        public static void ImprimirMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        public static int LerInteiro()
        {
            string line = Console.ReadLine();
            int iLine = Convert.ToInt32(line);

            return iLine;
        }

        public static int LerInteiro(string mensagem)
        {
            ImprimirMensagem(mensagem);

            return LerInteiro();
        }

        public static double LerDouble()
        {
            string line = Console.ReadLine();
            double dLine = Convert.ToDouble(line);

            return dLine;
        }

        public static double LerDouble(string mensagem)
        {
            ImprimirMensagem(mensagem);

            return LerDouble();
        }

        public static string LerDoTeclado()
        {
            string line = Console.ReadLine();

            return line;
        }

        public static string LerDoTeclado(string mensagem)
        {
            ImprimirMensagem(mensagem);

            return LerDoTeclado();
        }
    }
}
