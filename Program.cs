using Subsistemas;

namespace PatronFachada
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos la instancia de la fachada
            Fachada fachada = new Fachada();
            //hacemos uso de los subsistemas a traves de la interfaz de la fachada
            fachada.Compra();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------");



            fachada.Compra();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------");

            fachada.Compra();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------");

            fachada.Compra();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------");
        }
    }
}
