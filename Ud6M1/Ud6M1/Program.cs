using System;

namespace Ud6M1
{
    class Program
    {
        static void Main(string[] args)
        {
            //MILESTONE 1
            //fase 1
            string nom = "Arnau ";
            string cognom = "Diez ";
            string cognom2 = "Sans ";
            int dia = 9;
            int mes = 5;
            int any = 1987;
            Console.WriteLine(cognom + cognom2 + nom);
            Console.WriteLine(dia + "/" + mes + "/" + any);
            //fase 2
            const int aaaa = 1948;
            int periode = 4;
            int cantitat = (any - aaaa) / 4;
            Console.WriteLine("Hi ha {0} anys de traspàs.", cantitat);
            //fase 3
            string si = "El meu any de naixement es un any de traspàs";
            string no = "El meu any de naixement no es un any de traspàs";
            for (int i = 1; i <= cantitat; i++)
            {
                Console.WriteLine("Any de traspàs: {0}", aaaa + (4 * i));
            }
            bool any_traspas;
            if (any % periode == 0)
            {
                Console.WriteLine(si);
                any_traspas = true;
            }
            else
            {
                any_traspas = false;
                Console.WriteLine(no);
            }
            //fase 4
            string nom_complet = cognom + cognom2 + nom;
            string data = dia + "/" + mes + "/" + any;
            Console.WriteLine(nom_complet);
            Console.WriteLine(data);
            Console.WriteLine(no);
            //MILESTONE 2
            double num = 0.1234;
            int x;
            float f;
            string s;
            //x = Convert.ToInt32(num);
            //f = Convert.ToSingle(num);
            //s = Convert.ToSingle(num);
            //Console.WriteLine(x + " " + f + " " + s);
            //MILESTONE 3
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int aux;
            for (int i = 0; i < 10; i++)
            {
                aux = numeros[i];
                numeros[i] = numeros[9 - i];
                numeros[9 - i] = aux;
                if (i == 4) { goto exit; }
            }
            exit:
            Console.WriteLine(string.Join(" ", numeros));


        }
    }
}
