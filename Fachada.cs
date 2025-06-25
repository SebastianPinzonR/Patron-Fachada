using System.Text;
using System.Threading.Tasks;

namespace Subsistemas
{
    class Fachada
    {
        //estos son los subsistemas que se estan utilizando(instancias de los diferetes subsistemas)
        private SistemaCompra compra = new SistemaCompra();
        private SubSistemaAlmacen almacen = new SubSistemaAlmacen();
        private SubSistemaEnvio envio = new SubSistemaEnvio();

        //este metodo se usa para realizar de forma sencilla una operacion
        //que involucra a varios subsistemas
        public void Compra()
        {
            if (compra.Comprar())
            {
                if (almacen.ValidacionStock())
                {
                    envio.EnviarProducto();
                }
            }
        }
    }
}