
namespace PrincipiosSOLID
{
    public class ProcesadorPagos
    {
        public void Procesar(string metodo, float importe)
        {
            if (metodo == "PayPal")
            {
                // Lógica para PayPal  
            }
            else if (metodo == "Tarjeta")
            {
                // Lógica para tarjeta  
            }
        }
    }


    // Solución
    public interface IMetodoPago
    {
        void Procesar(string metodo, float importe);
    }

    public class PayPal : IMetodoPago
    {
        public void Procesar(string metodo, float importe)
        {
            // Lógica específica para PayPal
        }
    }

    public class Bitcoin : IMetodoPago
    {
        public void Procesar(string metodo, float importe)
        {
            // Lógica específica para Bitcoin
        }
    }


}
