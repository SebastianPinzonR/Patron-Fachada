namespace Subsistemas
{//Clase que representa el subsistema de compra
    class SistemaCompra
    {
        public bool Comprar()
        {
            string? dato = "";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el numero de la tarjeta");
            dato = Console.ReadLine();

            if (dato == "12345")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Compra realizada con exito");
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pago rechazado");
                return false;
            }
        }


    }
}

