
namespace PrincipiosSOLID
{
    public class ServicioUsuarios1
    {
        public void GuardarUsuario()
        {
            var baseDatos = new MyDataBase(); // Dependencia directa  
            baseDatos.Guardar();
        }
    }

    public class MyDataBase
    {
        public void Guardar()
        {
            /* ... */
        }
    }




    // Solución
    public interface IBaseDatos
    {
        void Guardar();
    }

    public class MySQL : IBaseDatos
    {
        public void Guardar() { /* ... */ }
    }

    public class ServicioUsuarios
    {
        private readonly IBaseDatos _baseDatos;
        public ServicioUsuarios(IBaseDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public void GuardarUsuario()
        {
            _baseDatos.Guardar();
        }
    }
}
