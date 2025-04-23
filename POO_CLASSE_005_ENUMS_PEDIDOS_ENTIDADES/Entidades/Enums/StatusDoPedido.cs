using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CLASSE_005_ENUMS_PEDIDOS_ENTIDADES.Entidades.Enums
{
    enum StatusDoPedido : int
    {
        Pendende = 1,
        Processando = 2,
        Enviado = 3,
        Entregue = 4
    }
}
