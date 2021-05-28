using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string RazonSocial { get; set; }
        public int IdTipoCliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdCiudad { get; set; }
        public bool Estado { get; set; }

        public static Cliente Search(int id, List<Cliente> clientes)
        {
            foreach (var c in clientes)
            {
                if (c.IdCliente == id)
                {
                    return c;
                }
            }

            return null;
        }
    }
}
