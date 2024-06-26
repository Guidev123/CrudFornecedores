﻿using System;
using System.Collections.Generic;

namespace CrudFornecedores.Domain.Models
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        // ENTITY FRAMEWORK RELATION
        public IEnumerable<Produto> Produtos { get; set; }
    }
}