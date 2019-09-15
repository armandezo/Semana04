using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Pedido
    {
        public int IdPedido { get; set ; }

        public string IdCliente { get; set ; }

        public int IdEmpleado { get; set ; }

        public DateTime FechaPedido { get; set; }

        public DateTime FechaEntrega { get; set; }

        public DateTime FechaEnvío { get; set; }

        public int FormaEnvío { get; set; }
        
        public decimal Cargo { get; set; }

        public string Destinatario { get; set; }

        public string DireccionesDestinatario { get; set; }

        public string CiudadDestinatario { get; set; }

        public string RegionDestinatario { get; set; }

        public string CodPostalDestinatario { get; set; }

        public string PaisDestinario { get; set; }
              
        public List<Pedido> Pedidos { get; set; }
        //Filtros de la Ventana
        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }


    }
}
