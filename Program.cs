namespace _1erParcialTema2CattoniOctavio.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definir radio, generatriz Como Real;
            //Definir altura Como Real;
            //Definir area, volumen Como Real;

            //Ingresar Altura y base
            int contador = 0;
            double valtura = PedirDouble("Ingrese el valor de la altura de la piramide: ");
            double vbase = PedirDouble("Ingrese el valor de la basede la piramide: ");
            

            while (valtura!=0 & vbase !=0)
            {
                double area = CalcularArea(valtura, vbase);
                double volumen = CalcularVolumen(valtura, vbase);
                contador = contador + 1;
                Console.WriteLine($"El area de la piramide cono es: {area}");
                Console.WriteLine($"El volumen de la piramide es: {volumen}");
                Console.WriteLine(" ");
                valtura = PedirDouble("Ingrese el valor de la altura de la piramide: ");
                vbase = PedirDouble("Ingrese el valor de la basede la piramide: ");
            }
            Console.WriteLine(" ");
            Console.WriteLine($"Las piramides ingresadas fueron: { contador}");
        }


        private static double CalcularVolumen(double valtura, double vbase)
        {
            return (valtura * (Math.Pow(vbase, 2)))/3;
        }

        private static double CalcularArea(double valtura, double vbase)
        {
            return vbase * (vbase + (Math.Sqrt(4 * Math.Pow(valtura, 2)+ Math.Pow(vbase, 2))));
        }

        private static double PedirDouble(string Mensaje)
        {
            double nro = 0;
            do
            {
                Console.Write(Mensaje);
                string strConsola = Console.ReadLine();
                if (!double.TryParse(strConsola, out nro))
                {
                    Console.WriteLine("Número mal ingresado");

                }
                else
                {
                    break;
                }

            } while (true);
            return nro;
        }
        private static double PedirDoubleEntreMinYMax(string Mensaje, double min, double max)
        {
            double nro = 0;
            do
            {
                Console.Write(Mensaje);
                string strConsola = Console.ReadLine();
                strConsola = strConsola.Replace('.', ',');
                if (!double.TryParse(strConsola, out nro))
                {
                    Console.WriteLine("Número mal ingresado");

                }
                else if (nro >= min && nro <= max)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"El número debe estar entre {min} y {max}");
                }

            } while (true);
            return nro;
        }
    }
}