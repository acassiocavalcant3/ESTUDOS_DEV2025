using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_CLASSE_005_ENUMS_PEDIDOS_ENTIDADES.Entidades.Enums;

namespace POO_CLASSE_005_ENUMS_PEDIDOS_ENTIDADES.Entidades
{
    class Pedido
    {
        public int Id { get; set; }
        public DateTime HoraDoPedido { get; set; }
        public StatusDoPedido Status { get; set; }

        public override string ToString()
        {
            string texto =

            $"\n************************************"
            + "\n_________DADOS DO PEDIDO___________"
            + "\n*************************************"
            + "\nID DO PEDIDO:                 ".PadRight(15) + Id
            + "\nHORA DO PEDIDO:               ".PadRight(15) + HoraDoPedido
            + "\nSTATUS DO PEDIDO:             ".PadRight(15) + Status
            + "\n************************************";
            return texto;
        }

    }
}
