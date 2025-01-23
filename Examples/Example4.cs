using System;

namespace PrincipiosSOLID
{
    public interface IDispositivoOficina
    {
        void Imprimir();
        void Escanear();
        void Fax();
    }

    public class ImpresoraBasica : IDispositivoOficina
    {
        public void Imprimir()
        {
            /* ... */
        }

        public void Escanear()
        {
            throw new Exception("No soportado");
        }

        public void Fax()
        {
            throw new Exception("No soportado");
        }
    }


    // Solución
    public interface IImprimible
    {
        void Imprimir();
    }

    public interface IEscaneable
    {
        void Escanear();
    }

    public class ImpresoraAvanzada : IImprimible, IEscaneable
    {
        public void Escanear()
        {
            /* ... */
        }

        public void Imprimir()
        {
            /* ... */
        }
    }
}
