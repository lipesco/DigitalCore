namespace DigitalCore.Migrations
{
    using DigitalCore.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DigitalCore.Models.DigitalCoreDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DigitalCore.Models.DigitalCoreDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //*********************************************************************
            // adiciona Clientes
            var cliente = new List<Cliente> {
                new Cliente {ID=1, nome="Miguel Vitor", username="mvitor", password="123", morada="Rua do Comércio, Nº18", codPostal="2300-243", localidade="Tomar", email="mvitor@gmail.com", telefone=249123456, NIF=115347923 },
                new Cliente {ID=2, nome="Pedro Conceição", username="pconceicaor", password="213", morada="Rua João Torres, Nº94", codPostal="2300-538", localidade="Tomar", email="pconceicao@yahoo.com", telefone=249765638, NIF=115836783 },
                new Cliente {ID=3, nome="Maria Isabel", username="misabel", password="321", morada="Praça do Bom Jardim, Nº25", codPostal="2300-623", localidade="Tomar", email="misabel@sapo.pt", telefone=249654321, NIF=102385734 },
                new Cliente {ID=4, nome="João Silva", username="jsilva", password="132", morada="Rua da Alcântara, Nº142", codPostal="2300-743", localidade="Tomar", email="jsilva@gmail.pt", telefone=249538247, NIF=201482693 },
                new Cliente {ID=5, nome="Teresa Pinheiro", username="tpinheiro", password="312", morada="Rua D. Pedro, Nº11", codPostal="2300-235", localidade="Tomar", email="tpinheiro@hotmail.com", telefone=249823953, NIF=159385395 },
                new Cliente {ID=6, nome="Marta Santos", username="msantos", password="231", morada="Rua Oliveira Gaio, Nº275", codPostal="2300-844", localidade="Tomar", email="msantos@sapo.pt", telefone=249839258, NIF=128573957 }

            };
            cliente.ForEach(CL => context.Cliente.AddOrUpdate(cl => cl.nome, CL));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Tipo de Artigos
            var tipoArtigo = new List<TipoArtigo> {
                new TipoArtigo {ID=1, descricao="Computador Desktop"},
                new TipoArtigo {ID=2, descricao="Monitor"},
                new TipoArtigo {ID=3, descricao="Portátil"},
                new TipoArtigo {ID=4, descricao="Tablet"},
                new TipoArtigo {ID=5, descricao="Disco"},
                new TipoArtigo {ID=6, descricao="Memória RAM"},
                new TipoArtigo {ID=7, descricao="Placa Gráfica"},
                new TipoArtigo {ID=8, descricao="Impressora"},
                new TipoArtigo {ID=9, descricao="Pen USB"},
                new TipoArtigo {ID=10, descricao="Rato"},
                new TipoArtigo {ID=11, descricao="Teclado"}

            };
            tipoArtigo.ForEach(TA => context.TipoArtigo.AddOrUpdate(tar => tar.descricao, TA));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Artigos
            var numSerie = new List<NumSerie> {
                new NumSerie {ID=1, numero="123456789"},
                new NumSerie {ID=2, numero="123456790"},
                new NumSerie {ID=3, numero="123456791"},
                new NumSerie {ID=4, numero="123456792"},
                new NumSerie {ID=5, numero="123456793"},
                new NumSerie {ID=6, numero="123456794"},
                new NumSerie {ID=7, numero="123456795"},
                new NumSerie {ID=8, numero="123456796"},
                new NumSerie {ID=9, numero="123456796"},
                new NumSerie {ID=10, numero="123456796"},
                new NumSerie {ID=11, numero="123456796"},
                new NumSerie {ID=12, numero="123456796"},
                new NumSerie {ID=13, numero="123456796"},
                new NumSerie {ID=14, numero="123456796"},
                new NumSerie {ID=15, numero="123456796"}

            };
            numSerie.ForEach(NS => context.NumSerie.AddOrUpdate(ns => ns.numero, NS));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Artigos
            var artigo = new List<Artigo> {
                new Artigo {ID=1, numeroSerieFK=1, TipoFK=1, descricao="HP Omen 880-106Np", caracteristicas ="Processador Intel i7 8700, RAM 16GB", preco="€1200", imagem="computador01.jpg" },
                new Artigo {ID=2, numeroSerieFK=8, TipoFK=5, descricao="Toshiba TR200 3D TLC SATA III", caracteristicas ="Disco SSD 240GB", preco="€55", imagem="discossd01.jpg" },
                new Artigo {ID=3, numeroSerieFK=3, TipoFK=1, descricao="Asus ROG GR8II-T022Z Auta", caracteristicas ="Processador Intel i5 7400, RAM 9GB", preco="€950", imagem="computador02.jpg" },
                new Artigo {ID=4, numeroSerieFK=7, TipoFK=1, descricao="Asus D320MT", caracteristicas ="Processador Intel i7 7700, RAM 8GB", preco="€600", imagem="computador03.jpg" },
                new Artigo {ID=5, numeroSerieFK=15, TipoFK=5, descricao="Samsung 500GB EVO 850", caracteristicas ="Disco SSD 500GB", preco="€125", imagem="discossd02.jpg" },
                new Artigo {ID=6, numeroSerieFK=2, TipoFK=5, descricao="Kingston 120GB SSD A400 SATA III", caracteristicas ="Disco SSD 120GB", preco="€35", imagem="discossd03.jpg" },
                new Artigo {ID=7, numeroSerieFK=9, TipoFK=3, descricao="HP 15-bs109np", caracteristicas ="Processador Intel i5 8250U, RAM 8GB, Disco 1TB", preco="€550", imagem="portatil01.jpg" },
                new Artigo {ID=8, numeroSerieFK=12, TipoFK=3, descricao="Asus Zenbook UX430UA-78DHDCB1", caracteristicas ="Processador Intel i7-8550U, 16GB RAM, Disco SSD 512GB", preco="€55", imagem="portatil02.jpg" }

            };
            artigo.ForEach(A => context.Artigo.AddOrUpdate(a => a.numeroSerieFK, A));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Tipo de Pagamentos
            var tipoPagamento = new List<TipoPagamento> {
                new TipoPagamento {ID=1, descricao="Cartão de Crédito"},
                new TipoPagamento {ID=2, descricao="Referência Multibanco"},
                new TipoPagamento {ID=3, descricao="Paypal"},
                new TipoPagamento {ID=4, descricao="PayShop"}
            };
            tipoPagamento.ForEach(TP => context.TipoPagamento.AddOrUpdate(tp => tp.descricao, TP));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Compras
            var compra = new List<Compra> {
                new Compra {ID=1, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=1, PagamentoFK=1 },
                new Compra {ID=2, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=3, PagamentoFK=2 },
                new Compra {ID=3, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=6, PagamentoFK=1 },
                new Compra {ID=4, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=1, PagamentoFK=1 },
                new Compra {ID=5, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=2, PagamentoFK=1 },
                new Compra {ID=6, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=5, PagamentoFK=3 },
                new Compra {ID=7, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=2, PagamentoFK=1 },
                new Compra {ID=8, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=4, PagamentoFK=1 },
                new Compra {ID=9, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=5, PagamentoFK=3 },
                new Compra {ID=10, dataCompra=new DateTime(2018,05,06), dataEntrega=new DateTime(2018,05,07), ClienteFK=3, PagamentoFK=2 },
                new Compra {ID=11, dataCompra=new DateTime(2018,05,07), dataEntrega=new DateTime(2018,05,08), ClienteFK=3, PagamentoFK=2 },
                new Compra {ID=12, dataCompra=new DateTime(2018,05,07), dataEntrega=new DateTime(2018,05,08), ClienteFK=4, PagamentoFK=1 }

            };
            compra.ForEach(C => context.Compra.AddOrUpdate(c => c.dataCompra, C));
            context.SaveChanges();

            //*********************************************************************
            // adiciona Relação Compras & Artigo
            var artigoCompra = new List<ArtigoCompra> {
                new ArtigoCompra {ID=1, IDArtig=1, IDCompr=1, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=2, IDArtig=2, IDCompr=1, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=3, IDArtig=4, IDCompr=2, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=4, IDArtig=8, IDCompr=3, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=5, IDArtig=4, IDCompr=3, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=6, IDArtig=1, IDCompr=3, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=7, IDArtig=3, IDCompr=4, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=8, IDArtig=1, IDCompr=5, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=9, IDArtig=5, IDCompr=6, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=10, IDArtig=6, IDCompr=7, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=11, IDArtig=2, IDCompr=8, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=12, IDArtig=7, IDCompr=9, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=13, IDArtig=1, IDCompr=10, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=14, IDArtig=3, IDCompr=11, quantidade=1, IVA="23" },
                new ArtigoCompra {ID=15, IDArtig=3, IDCompr=12, quantidade=1, IVA="23" }
            };
            artigoCompra.ForEach(AC => context.ArtigoCompra.AddOrUpdate(ac => ac.IDCompr, AC));
            context.SaveChanges();

        }
    }
}

