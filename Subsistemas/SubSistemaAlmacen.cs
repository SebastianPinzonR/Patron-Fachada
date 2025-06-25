namespace Subsistemas
{
    class SubSistemaAlmacen
    {
        private int cantidad;
        public SubSistemaAlmacen()
        {
            cantidad = 3;
        }
        public bool ValidacionStock()
        {
            if (cantidad > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Producto listo para enviarse");
                cantidad--;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Producto agotado, espera a que haya mas stock");
                return false;
            }
        }
    }
}
