﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Categoria
    {
        public long CategoriaId { get; set; } // Identificar
        public string Nome { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }

    }
}