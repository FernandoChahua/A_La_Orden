﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Data
{
    public interface IRepositorioPedido : IRepositorioCRUD<Pedido>
    {
        List<Pedido> GetByUsuario(int idUsuario);
    }
}
