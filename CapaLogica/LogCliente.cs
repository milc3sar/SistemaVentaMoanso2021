using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogica
{
    public class LogCliente
    {
        public static LogCliente Instancia { get; } = new LogCliente();

        public List<Cliente> ListarCliente()
        {
            return SqlCliente.Instancia.ListarCliente();
        }

        public bool InsertarCliente(Cliente c)
        {
            return SqlCliente.Instancia.InsertarCliente(c);
        }

        public bool EditarCliente(Cliente c)
        {
            return SqlCliente.Instancia.EditarCliente(c);
        }
    }
}
