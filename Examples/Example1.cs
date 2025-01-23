using System;

namespace PrincipiosSOLID
{
    public class Usuario1
    {
        public string Nombre { get; set; }
        public string Email { get; set; }

        public void EnviarCorreoBienvenida()
        {
            Console.WriteLine($"Enviando correo a {Email}: ¡Bienvenido, {Nombre}!");
        }
    }


    // Solución
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
    }

    public class ServicioCorreo
    {
        public void EnviarCorreoBienvenida(Usuario usuario)
        {
            Console.WriteLine($"Enviando correo a {usuario.Email}: ¡Bienvenido, {usuario.Nombre}!");
        }
    }
}
