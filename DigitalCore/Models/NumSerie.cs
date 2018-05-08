using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DigitalCore.Models
{
    public class NumSerie
    {
        public NumSerie()
        {
            // inicialização da lista de Artigos de um NumSerie
            ListaArtigos = new HashSet<Artigo>();
        }
        public int ID { get; set; }
        [Required]
        public string numero { get; set; }
        // um TipoPagamento tem uma coleção de compras
        public virtual ICollection<Artigo> ListaArtigos { get; set; }
    }
}