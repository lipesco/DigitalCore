﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DigitalCore.Models
{
    public class TipoArtigo
    {
        public TipoArtigo()
        {
            // inicialização da lista de Artigos de um Tipo de Artigo
            ListaArtigos = new HashSet<Artigo>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string descricao { get; set; }

        // um TipoPagamento tem uma coleção de compras
        public virtual ICollection<Artigo> ListaArtigos { get; set; }
    }
}