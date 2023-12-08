namespace Test06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] operatorss = new string[] { "+", "-", "*", "/" };

            Console.WriteLine("Escribe el primer numero: ");
            string operand1 = Console.ReadLine();

            int number1 = 0;
            
            if (!int.TryParse(operand1, out number1))
            {
                Console.WriteLine("No es un numero");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Escribe el operador: ");
            string op = Console.ReadLine();

            if (!operatorss.Contains(op))
            {
                string resultado = "operador no soportado. Solo se permite:";

                foreach(string opt in operatorss)
                {
                    resultado += " " + opt;
                }
                Console.WriteLine(resultado);
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Escribe el segundo numero: ");
            string operand2 = Console.ReadLine();

            int number2 = 0;

            if (!int.TryParse(operand2, out number2))
            {
                Console.WriteLine("No es un numero");
                Console.ReadLine();
                return;
            }

            if(op == "+")
            {
                Console.WriteLine(number1 + number2);
            }
            else if (op == "-")
            {
                Console.WriteLine(number1 - number2);
            }
            else if (op == "*")
            {
                Console.WriteLine(number1 * number2);
            }
            else if (op == "/")
            {
                Console.WriteLine(number1 / number2);
            }
            
            
            Console.ReadLine();

            //TestForEach();
            //TestArrayInt();
            //TestSimpleConsoleInput(args);
            //TestArrayString();
            //TestDoWhile();
            //TestWhile();
            //TestFor();
        }

        private static void TestForEach()
        {
            int[] miListaNumeros = new int[]
{
                1,
                2,
                3,
                4,
                5
};

            foreach (int mi in miListaNumeros)
            {
                Console.WriteLine("Hola " + mi);
            }

            Console.ReadLine();
        }

        private static void TestArrayInt()
        {
            int[] miListaNumeros = new int[]
            {
                1,
                2,
                3,
                4,
                5
            };

            for (int i = 0; i < miListaNumeros.Length; i++)
            {
                Console.WriteLine("Hola " + miListaNumeros[i]);
            }
            Console.ReadLine();
        }

        private static void TestSimpleConsoleInput(string[] args)
        {
            if (args.Length != 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine("Hola " + args[i]);
                }

            }
            else
            {
                Console.WriteLine("No hay entrada");
            }

            Console.ReadLine();
        }

        private static void TestArrayString()
        {
            string[] listaCadenas = new string[]
{
                "Hola",
                "Adios",
                "Buenos Dias",
                "Buenas tardes",
                "Buenas Noches",
                "Permiso"
};

            string[] listaCadenasGrande = new string[15];
            listaCadenas.CopyTo(listaCadenasGrande, 0);
            {

            };

            for (int i = 0; i < listaCadenas.Length; i++)
            {
                Console.WriteLine(listaCadenas[i]);
            }

            Console.ReadLine();
        }

        private static void TestDoWhile()
        {
            int i = 1;

            do
            {
                i++;
                Console.WriteLine("i vale " + i);
            }
            while (i > 0);

            Console.ReadLine();
        }

        private static void TestFor()
        {

            for (int i = 0, j = 0; i < 10 || j > -9; i++, j--)
            {
                Console.WriteLine("i vale " + i);
                Console.WriteLine("j vale " + j);

            }
            Console.ReadLine();
        }

        private static void TestWhile()
        {
            int i = 0;

            while (i <= 10)
            {
                i++;

                if (i / 2 == 0)
                {
                    break;
                }
                Console.WriteLine("i vale " + i);
                
            }
            Console.ReadLine();

        }
    }
}