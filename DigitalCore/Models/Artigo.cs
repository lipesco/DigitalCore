using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DigitalCore.Models
{
    public class Artigo
    {
        public Artigo()
        {
            ListaDeObjectosArtigoCompra = new HashSet<ArtigoCompra>();
        }

        public int ID { get; set; }

        [ForeignKey("NumSerie")]
        public int numeroSerieFK { get; set; }
        public virtual NumSerie NumSerie { get; set; }

        [ForeignKey("TipoArtigo")]
        public int TipoFK { get; set; }
        public virtual TipoArtigo TipoArtigo { get; set; }

        [Required]
        public string descricao { get; set; }

        [Required]
        public string caracteristicas { get; set; }

        [Required]
        public string preco { get; set; }

        public string imagem { get; set; }

        public virtual ICollection<ArtigoCompra> ListaDeObjectosArtigoCompra { get; set; }


    }
}
