namespace PTurismo.Migrations
{
    using DAL;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PTurismo.DAL.PastoralContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());
        }

        protected override void Seed(PastoralContext Context)
        {
            var categorias = new List<Categoria>
            {
                new Categoria {CategoriaID=1,nome="Igreja", genero="Religioso"},
                new Categoria {CategoriaID=2,nome="Catedral", genero="Religioso"},
                new Categoria {CategoriaID=3,nome="Capela", genero="Religioso"},
                new Categoria {CategoriaID=4,nome="Mosteiro", genero="Religioso"},
                new Categoria {CategoriaID=5,nome="Santu�rio", genero="Religioso"},
                new Categoria {CategoriaID=6,nome="Bas�lica", genero="Religioso"},
                new Categoria {CategoriaID=7,nome="Museu", genero="Civil"},
                new Categoria {CategoriaID=8,nome="Castelo", genero="Militar"}
            };

            categorias.ForEach(c => Context.Categoria.Add(c));
            Context.SaveChanges();

            var pois = new List<Poi>
            {
               

                new Poi { PoiID=1, nome="S� Velha", CategoriaID = 2, latitude=41.805923, longitude=-6.756663,
                    descricao ="S� Velha descrita", 
                    resumo = "S� Velha resumida"},

                new Poi { PoiID=2, nome="S� de Miranda", CategoriaID = 2, latitude=41.492987, longitude=-6.273409,
                    descricao ="Catedral Miranda descri��o", 
                    resumo = "Catedral de Miranda resumida"},

                new Poi { PoiID=3, nome="Nossa Senhora do Amparo", CategoriaID = 5, latitude=41.483889, longitude=-7.187343,
                    descricao ="Nossa Senhora do Amparo descri��o", 
                    resumo = "Nossa Senhora do Amparo resumida"},

                new Poi { PoiID=4, nome="Igreja de Vinhais", CategoriaID = 1, latitude=41.832420, longitude=-7.007088,
                    descricao ="Igreja de Vinhais descrita", 
                    resumo = "Igreja de Vinhais resumida"},

                new Poi { PoiID=5, nome="Museu Municipal Armindo Teixeira Lopes", CategoriaID = 7, latitude=41.485280, longitude=-7.178779,
                    descricao ="Museu Municipal Armindo Teixeira Lopes descrita", 
                    resumo = "Museu Municipal Armindo Teixeira Lopes resumida"},

                new Poi { PoiID=6, nome="Bas�lica Menor do Santo Cristo de Outeiro", CategoriaID = 6, latitude=41.683693, longitude=-6.600570,
                    descricao ="Basilica Menor do Santo Cristo de Outeiro descrita", 
                    resumo = "Basilica Menor do Santo Cristo de Outeiro resumida"},

                new Poi { PoiID=7, nome="Convento de Balsem�o", CategoriaID = 4, latitude=41.474379, longitude=-6.855900,
                    descricao ="Convento de Balsem�o descrita", 
                    resumo = "Convento de Balsem�o resumida"},

                new Poi { PoiID=8, nome="Capela de Santo Amaro", CategoriaID = 3, latitude=41.645415, longitude=-6.600713,
                    descricao ="Capela de Santo Amaro descrita",
                    resumo = "Capela de Santo Amaro resumida"},
                new Poi { PoiID=9, nome="Igreja de S�o Miguel Arcanjo", CategoriaID = 1, latitude=41.4124905, longitude=-7.1734237, descricao="Arquitectura religiosa, barroca e rococ�. Fachada principal em empena recortada, com portal em arco abatido, sobrepujado por nicho concheado ladeado por dois �culos el�pticos.Ret�bulos laterais rococ�, sendo os colaterais, em �ngulo, e o mor revivalistas neobarrocos.", resumo="" },
                new Poi { PoiID=10, nome="Igreja de Santo Estev�o", CategoriaID=1, latitude=41.8654563, longitude=-6.9876812, descricao="Igreja maneirista de planta rectangular, com um alpendre quadrangular. Tem uma nave �nica, capela-mor e sacristia adossada do lado esquerdo. Apresenta cobertura �nica em telhados de duas �guas, excepto no alpendre onde a cobertura � de tr�s �guas. Todos os al�ados s�o percorridos por um embasamento e cornija, com cunhais rematados por pin�culos.",  resumo="" },
                new Poi { PoiID=11, nome="Santu�rio da Senhora da Serra", CategoriaID=5, latitude=41.5001888, longitude=-7.5123275, descricao="o Santu�rio da Senhora da Serra, tamb�m conhecido como o Santu�rio de Nossa Senhora das Neves, � uma igreja de tr�s naves, separadas por colunas e pilastras cujos capit�is, de aspecto arcaico, parecem ser do s�culo XV ou XVI.O altar-mor, de talha setecentista, foi restaurado nos anos 70 e a imagem da Senhora da Serra � do in�cio do s�culo XX.",  resumo="" },
                new Poi { PoiID=12, nome="Igreja de S�o Pedro", CategoriaID=1, latitude=41.8036206,longitude=-6.7509715,descricao="A igreja da Moimenta, vista exteriormente, imp�e-se sobremaneira, em todo o conjunto arquitet�nico. A fachada principal, de linhas simples, contrasta com a magnific�ncia das torres quadradas de estilo rom�nico e a eleg�ncia art�stica da balaustrada de granito entre os flocos das suas bases retas. Deve ser um dos templos maiores da regi�o, provavelmente a maior igreja Paroquial de terras de Vinhais.",  resumo=""},
                new Poi { PoiID=13, nome="Capela De Nossa Senhora do Areal", CategoriaID=3, latitude=41.6954632, longitude=-7.0612736, descricao="Capela de planta longitudinal, com alpendre no frontisp�cio. Na nave, do lado do Evangelho, numa ed�cula h� uma representa��o escult�rica de S�o Pedro. Na parte de tr�s do altar - mor, de talha e da pintura, subsistem frescos numa �rea de 3,80m X 2m.", resumo="" },
                new Poi { PoiID=14, nome="Capela de S�o Bartolomeu", CategoriaID=3, latitude=41.6620952,longitude=-6.9084036, descricao="no recinto da capela h� um cruzeiro, colocado em frente � sua entrada. A ermida de linhas modernas, tem adossada do lado direito uma torre sineira de tr�s registos, no dos quais se rasga um �culo e no terceiro surgem os sinos.",  resumo=""},
                new Poi { PoiID=15, nome="Santu�rio de Nossa Senhora do Aviso", CategoriaID=5, latitude=41.599406, longitude=-6.765357, descricao="Neste local al�m do santu�rio, composto por oito templetes alusivos ao calv�rio, fica tamb�m a fonte dos Engaranhos com umas inscri��es impercept�veis.", resumo="" },
                new Poi { PoiID=16, nome="Igreja Matriz de Santa Comba da Vilari�a", CategoriaID=1, latitude=41.1533885, longitude=-7.0148377, descricao=" Igreja barroca que guarda no seu interior dois altares de talha dourada e, no lado do Evangelho, um p�lpito quadrado com m�sula p�trea. Ostenta um tecto de madeira formado por grandes pain�is.",  resumo="" },
                new Poi { PoiID=17, nome="Igreja de Vale de Prados", CategoriaID=1, latitude=41.6178244,longitude=-7.2266654, descricao="Vale de Prados de Ledra chamava se assim porque existia na Terra de Ledra e para distinguir de Vale de Prados de Macedo de Cavaleiros.O Orago era Santo Andr�.A par�quia foi institu�da pela abadia de Guide depois do s�culo XV na ermida local dedicada ao ap�stolo.Foi unida a M�rias depois da extin��o da par�quia(cerca de 1834).",  resumo="" },
                new Poi { PoiID=18, nome="Santu�rio de N. Sra. da Assun��o", CategoriaID=5, latitude=41.2837901, longitude=-7.4999258, descricao="� o maior e um dos mais importantes santu�rios Marianos de Tr�s-os-Montes. Erguido no s�culo XIX no alto de um monte que domina toda a paisagem envolvente, representa um dos pontos mais altos do Concelho, com cerca de 760 metros de altitude.O Santu�rio de N. Sra.da Assun��o, � tamb�m Miradouro de primeira qualidade.Junto ao varandim do adro obt�m-se uma rara e vasta paisagem, cobrindo a vizinha San�bria, Montesinho, Bornes, Mirandela e as vilas e aldeias vizinhas num raio de 100km.A sua hist�ria � milenar visto ter existido um castro neste magn�fico monte, que justamente foi escolhido pela sua capacidade de Posto de Vigia.Possui uma igreja de nave �nica e capela-mor retangulares, v�rias capelinhas espalhadas pelo recinto e um monumental escad�rio, tudo envolto em imensos tufos de floresta.Santu�rio de N.Sra. do Ros�rio, em Freixiel.",  resumo="" },
                 new Poi { PoiID=19, nome="Igreja Matriz Vale de Salgueiro", CategoriaID = 1, latitude=41.590878, longitude=-7.235249,
                    descricao ="Igreja descrita",
                    resumo = "Igreja resumida"}
            };

            pois.ForEach(p => Context.Poi.Add(p));
            Context.SaveChanges();

            var elementos = new List<Elemento>
            {
                new Elemento { ElementoID=1, nome="Nave central da igreja", descricao="Entrada da Igreja",
                    PoiID=2},
                new Elemento { ElementoID=2, nome="Capela Mor", descricao="Capela Mor descri��o",
                     PoiID=2},
                new Elemento { ElementoID=3, nome="Portal de S�o Gon�alo de Amarante", descricao="S�o Gon�alo Amarante",
                     PoiID=2}
            };

            elementos.ForEach(e => Context.Elemento.Add(e));
            Context.SaveChanges();

            var galeriaElementos = new List<GaleriaElemento>
            {
                new GaleriaElemento { GaleriaElementoID=1, ElementoID=1 },
                new GaleriaElemento { GaleriaElementoID=2, 
                    legenda ="Fotografia do Teto da Nave Central", ElementoID=1 },
                new GaleriaElemento { GaleriaElementoID=2, legenda ="Video Capela Mor",  ElementoID=2 }
            };

            galeriaElementos.ForEach(g => Context.GaleriaElemento.Add(g));
            Context.SaveChanges();
            
            var galeriaPois = new List<GaleriaPoi>
            {
                new GaleriaPoi {GaleriaPoiID=1, Legenda="Video do Exterior da Catedral",  PoiID=2 },
                new GaleriaPoi {GaleriaPoiID=2, Legenda="Video do Interior da Catedral",  PoiID=2 }
            };

            galeriaPois.ForEach(p => Context.GaleriaPoi.Add(p));
            Context.SaveChanges();
            
        }
    }
}
