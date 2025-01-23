using System;

namespace PrincipiosSOLID
{
    public class Pajaro
    {
        public virtual void Volar()
        {
            Console.WriteLine("Volando...");
        }
    }

    public class Pinguino1 : Pajaro
    {
        public override void Volar()
        {
            throw new Exception("¡Los pingüinos no vuelan!");
        }
    }





    // Solución
    public interface IAnimalVolador
    {
        void Volar();
    }

    public interface IAnimalNadador
    {
        void Nadar();
    }

    public class Aguila : IAnimalVolador
    {
        public void Volar()
        {
            /* ... */
        }
    }

    public class Pinguino : IAnimalNadador
    {
        public void Nadar()
        {
            /* ... */
        }
    }
}
