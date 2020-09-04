﻿using lanches.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lanches.Repositories
{

   public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}