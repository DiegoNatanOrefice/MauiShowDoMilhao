using MauiShowDoMilhao.Models;

namespace MauiShowDoMilhao
{
    public partial class App : Application
    {
        List<Pergunta> perguntas_faceis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Em que estado brasileiro nasceu a apresentadora Xuxa?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "RIO DE JANEIRO" },
                    new Alternativa { Correta = true, Descricao = "RIO GRANDE DO SUL" },
                    new Alternativa { Correta = false, Descricao = "SANTA CATARINA" },
                    new Alternativa { Correta = false, Descricao = "GOIÁS" },
                }
            },
            new Pergunta
            {
                Id = 2,
                Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "LÍQUIDO" },
                    new Alternativa { Correta = true, Descricao = "SÓLIDO" },
                    new Alternativa { Correta = false, Descricao = "GASOSO" },
                    new Alternativa { Correta = false, Descricao = "VAPOROSO" },
                }
            },

            new Pergunta
            {
                Id = 3,
                Enunciado = "Qual era o apelido da cantora Elis Regina?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "GAUCHINHA" },
                    new Alternativa { Correta = false, Descricao = "PAULISTINHA" },
                    new Alternativa { Correta = true, Descricao = "PIMENTINHA" },
                    new Alternativa { Correta = false, Descricao = "ANDORINHA" },
                }
            },

            new Pergunta
            {
                Id = 4,
                Enunciado = "Quem é a namorada do Mickey?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MARGARIDA" },
                    new Alternativa { Correta = true, Descricao = "MINNIE" },
                    new Alternativa { Correta = false, Descricao = "A PEQUENA SEREIA" },
                    new Alternativa { Correta = false, Descricao = "OLÍVIA PALITO" },
                }
            },

            new Pergunta
            {
                Id = 5,
                Enunciado = "Qual é o personagem do folclore brasileiro que tem uma perna só?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "CUCA" },
                    new Alternativa { Correta = false, Descricao = "NEGRINHO DO PASTOREIO" },
                    new Alternativa { Correta = false, Descricao = "BOITATÁ" },
                    new Alternativa { Correta = true, Descricao = "SACI-PERERÊ" },
                }
            },

            new Pergunta
            {
                Id = 6,
                Enunciado = "Fidel Castro nasceu em que país?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "JAMAICA" },
                    new Alternativa { Correta = true, Descricao = "CUBA" },
                    new Alternativa { Correta = false, Descricao = "EL SALVADOR" },
                    new Alternativa { Correta = false, Descricao = "MÉXICO" },
                }
            },

            new Pergunta
            {
                Id = 7,
                Enunciado = "Quem proclamou a república no Brasil em 1889?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DUQUE DE CAXIAS" },
                    new Alternativa { Correta = false, Descricao = "MARECHAL RONDON" },
                    new Alternativa { Correta = false, Descricao = "DOM PEDRO II" },
                    new Alternativa { Correta = true, Descricao = "MARECHAL DEODORO" },
                }
            },

            new Pergunta
            {
                Id = 8,
                Enunciado = "Quem é o patrono do exército brasileiro?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MARECHAL DEODORO" },
                    new Alternativa { Correta = false, Descricao = "BARÃO DE MAUÁ" },
                    new Alternativa { Correta = true, Descricao = "DUQUE DE CAXIAS" },
                    new Alternativa { Correta = false, Descricao = "MARQUÊS DE POMBAL" },
                }
            },

            new Pergunta
            {
                Id = 9,
                Enunciado = "Quem era o apresentador que reprovava os calouros tocando uma buzina?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "RAUL GIL" },
                    new Alternativa { Correta = false, Descricao = "BOLINHA" },
                    new Alternativa { Correta = false, Descricao = "FLÁVIO CAVALCANTI" },
                    new Alternativa { Correta = true, Descricao = "CHACRINHA" },
                }
            },

            new Pergunta
            {
                Id = 10,
                Enunciado = "O que era Frankenstein, de Mary Shelley?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "MONSTRO" },
                    new Alternativa { Correta = false, Descricao = "GORILA" },
                    new Alternativa { Correta = false, Descricao = "PRÍNCIPE" },
                    new Alternativa { Correta = false, Descricao = "SAPO" },
                }
            },

            new Pergunta
            {
                Id = 11,
                Enunciado = "Qual é o signo do zodíaco de quem nasce no dia do ano-novo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "VIRGEM" },
                    new Alternativa { Correta = false, Descricao = "AQUÁRIO" },
                    new Alternativa { Correta = true, Descricao = "CAPRICÓRNIO" },
                    new Alternativa { Correta = false, Descricao = "ÁRIES" },
                }
            },

            new Pergunta
            {
                Id = 12,
                Enunciado = "Quem fundou a fábrica de automóveis Ford?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "HARRISON FORD" },
                    new Alternativa { Correta = false, Descricao = "GERALD FORD" },
                    new Alternativa { Correta = true, Descricao = "HENRY FORD" },
                    new Alternativa { Correta = false, Descricao = "ANNA FORD" },
                }
            },

            new Pergunta
            {
                Id = 13,
                Enunciado = "Qual é a cor que se associa com os grupos ecológicos?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "PRETA" },
                    new Alternativa { Correta = false, Descricao = "VERMELHA" },
                    new Alternativa { Correta = false, Descricao = "AZUL" },
                    new Alternativa { Correta = true, Descricao = "VERDE" },
                }
            },

            new Pergunta
            {
                Id = 14,
                Enunciado = "A água ferve a quantos graus centígrados?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "200" },
                    new Alternativa { Correta = true, Descricao = "100" },
                    new Alternativa { Correta = false, Descricao = "170" },
                    new Alternativa { Correta = false, Descricao = "220" },
                }
            },

            new Pergunta
            {
                Id = 15,
                Enunciado = "Quando é comemorado o dia da independência do Brasil?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "21 DE ABRIL" },
                    new Alternativa { Correta = false, Descricao = "12 DE OUTUBRO" },
                    new Alternativa { Correta = true, Descricao = "7 DE SETEMBRO" },
                    new Alternativa { Correta = false, Descricao = "25 DE DEZEMBRO" },
                }
            },

            new Pergunta
            {
                Id = 16,
                Enunciado = "Qual lugar é também chamado de Santa Sé?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "VENEZA" },
                    new Alternativa { Correta = false, Descricao = "VITÓRIA" },
                    new Alternativa { Correta = false, Descricao = "VANCOUVER" },
                    new Alternativa { Correta = true, Descricao = "VATICANO" },
                }
            },

            new Pergunta
            {
                Id = 17,
                Enunciado = "Quem tem por lema a frase: 'Sempre alerta'?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MÉDICOS" },
                    new Alternativa { Correta = true, Descricao = "ESCOTEIROS" },
                    new Alternativa { Correta = false, Descricao = "BOMBEIROS" },
                    new Alternativa { Correta = false, Descricao = "POLICIAIS" },
                }
            },

            new Pergunta
            {
                Id = 18,
                Enunciado = "Quem foi o grande amor de Julieta?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "ROME" },
                    new Alternativa { Correta = false, Descricao = "ORFEU" },
                    new Alternativa { Correta = false, Descricao = "HAMLET" },
                    new Alternativa { Correta = false, Descricao = "IAGO" },
                }
            },

            new Pergunta
            {
                Id = 19,
                Enunciado = "Quantos signos formam o zodíaco?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "NOVE" },
                    new Alternativa { Correta = false, Descricao = "DEZ" },
                    new Alternativa { Correta = false, Descricao = "ONZE" },
                    new Alternativa { Correta = true, Descricao = "DOZE" },
                }
            },

            new Pergunta
            {
                Id = 20,
                Enunciado = "Vatapá é uma comida típica de qual estado?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "PARANÁ" },
                    new Alternativa { Correta = false, Descricao = "SANTA CATARINA" },
                    new Alternativa { Correta = false, Descricao = "SÃO PAULO" },
                    new Alternativa { Correta = true, Descricao = "BAHIA" },
                }
            },

            new Pergunta
            {
                Id = 21,
                Enunciado = "Quantos jogadores um jogo de vôlei reúne na quadra?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "SEIS" },
                    new Alternativa { Correta = false, Descricao = "OITO" },
                    new Alternativa { Correta = false, Descricao = "DEZ" },
                    new Alternativa { Correta = true, Descricao = "DOZE" },
                }
            },

            new Pergunta
            {
                Id = 22,
                Enunciado = "Qual é o país do tango?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "URUGUAI" },
                    new Alternativa { Correta = true, Descricao = "ARGENTINA" },
                    new Alternativa { Correta = false, Descricao = "PARAGUAI" },
                    new Alternativa { Correta = false, Descricao = "ESPANHA" },
                }
            },

            new Pergunta
            {
                Id = 23,
                Enunciado = "Que imperador pôs fogo em Roma?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "TRAJANO" },
                    new Alternativa { Correta = true, Descricao = "NERO" },
                    new Alternativa { Correta = false, Descricao = "BRUTUS" },
                    new Alternativa { Correta = false, Descricao = "CALÍGULA" },
                }
            },

            new Pergunta
            {
                Id = 24,
                Enunciado = "A cidade de Pompéia, que foi soterrada por um vulcão fica em qual desses países?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "JAPÃO" },
                    new Alternativa { Correta = false, Descricao = "MÉXICO" },
                    new Alternativa { Correta = true, Descricao = "ITÁLIA" },
                    new Alternativa { Correta = false, Descricao = "ESTADOS UNIDOS" },
                }
            },

            new Pergunta
            {
                Id = 25,
                Enunciado = "Como é chamado quem nasce em Milão, na Itália?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MILANENSE" },
                    new Alternativa { Correta = false, Descricao = "MILANOSO" },
                    new Alternativa { Correta = false, Descricao = "MILISTA" },
                    new Alternativa { Correta = true, Descricao = "MILANÊS" },
                }
            },

            new Pergunta
            {
                Id = 26,
                Enunciado = "Que profissional usa uma ferramenta chamada formão?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "CARPINTEIRO" },
                    new Alternativa { Correta = false, Descricao = "RELOJOEIRO" },
                    new Alternativa { Correta = false, Descricao = "CONFEITEIRO" },
                    new Alternativa { Correta = false, Descricao = "BOMBEIRO" },
                }
            },

            new Pergunta
            {
                Id = 27,
                Enunciado = "Em qual estádio Pelé marcou seu milésimo gol?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MORUMBI" },
                    new Alternativa { Correta = false, Descricao = "PACAEMBU" },
                    new Alternativa { Correta = true, Descricao = "MARACANÃ" },
                    new Alternativa { Correta = false, Descricao = "MINEIRÃO" },
                }
            },

            new Pergunta
            {
                Id = 28,
                Enunciado = "O que é um oboé?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "VULCÃO" },
                    new Alternativa { Correta = false, Descricao = "COMIDA" },
                    new Alternativa { Correta = true, Descricao = "INSTRUMENTO MUSICAL" },
                    new Alternativa { Correta = false, Descricao = "TRIBO INDÍGENA" },
                }
            },

            new Pergunta
            {
                Id = 29,
                Enunciado = "Como eram chamados os pilotos suicidas da Segunda Guerra?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "CAMICASES" },
                    new Alternativa { Correta = false, Descricao = "SASHIMIS" },
                    new Alternativa { Correta = false, Descricao = "HARAQUIRIS" },
                    new Alternativa { Correta = false, Descricao = "SUMÔS" },
                }
            },

            new Pergunta
            {
                Id = 30,
                Enunciado = "O que é gôndola?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "EMBARCAÇÃO" },
                    new Alternativa { Correta = false, Descricao = "BRINQUEDO" },
                    new Alternativa { Correta = false, Descricao = "MÚSICA" },
                    new Alternativa { Correta = false, Descricao = "SÍMBOLO" },
                }
            },

            new Pergunta
            {
                Id = 31,
                Enunciado = "Sashimi é um prato originário de qual país?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "JAPÃO" },
                    new Alternativa { Correta = false, Descricao = "CHINA" },
                    new Alternativa { Correta = false, Descricao = "ÍNDIA" },
                    new Alternativa { Correta = false, Descricao = "INDONÉSIA" },
                }
            },

            new Pergunta
            {
                Id = 32,
                Enunciado = "Como é chamada a cantora que representa o papel principal em uma ópera?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "PRIMEIRA DAMA" },
                    new Alternativa { Correta = false, Descricao = "DONA-PRIMA" },
                    new Alternativa { Correta = true, Descricao = "PRIMA-DONA" },
                    new Alternativa { Correta = false, Descricao = "OBRA-PRIMA" },
                }
            },

            new Pergunta
            {
                Id = 33,
                Enunciado = "Peroba é uma espécie de?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "INSETO" },
                    new Alternativa { Correta = true, Descricao = "ÁRVORE" },
                    new Alternativa { Correta = false, Descricao = "VERME" },
                    new Alternativa { Correta = false, Descricao = "VERDURA" },
                }
            },

            new Pergunta
            {
                Id = 34,
                Enunciado = "O alpinismo é praticado em que lugar?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MAR" },
                    new Alternativa { Correta = true, Descricao = "MONTANHA" },
                    new Alternativa { Correta = false, Descricao = "RIO" },
                    new Alternativa { Correta = false, Descricao = "PRAIA" },
                }
            },

            new Pergunta
            {
                Id = 35,
                Enunciado = "O Coliseu é um monumento histórico de que cidade europeia?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "PARIS" },
                    new Alternativa { Correta = false, Descricao = "COPENHAGUE" },
                    new Alternativa { Correta = true, Descricao = "ROMA" },
                    new Alternativa { Correta = false, Descricao = "LONDRES" },
                }
            },

            new Pergunta
            {
                Id = 36,
                Enunciado = "Qual é o ponto mais alto da Terra?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "EVEREST" },
                    new Alternativa { Correta = false, Descricao = "MONTE SINAI" },
                    new Alternativa { Correta = false, Descricao = "MONTE CASTELO" },
                    new Alternativa { Correta = false, Descricao = "MONT BLANC" },
                }
            },

            new Pergunta
            {
                Id = 37,
                Enunciado = "Que rio corta a cidade de Londres, na Inglaterra?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "TÂMISA" },
                    new Alternativa { Correta = false, Descricao = "SENA" },
                    new Alternativa { Correta = false, Descricao = "RENO" },
                    new Alternativa { Correta = false, Descricao = "AUBE" },
                }
            },

            new Pergunta
            {
                Id = 38,
                Enunciado = "Qual é a raça do personagem principal do filme “Beethoven”?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "FILA" },
                    new Alternativa { Correta = false, Descricao = "PASTOR ALEMÃO" },
                    new Alternativa { Correta = false, Descricao = "POODLE" },
                    new Alternativa { Correta = true, Descricao = "SÃO-BERNARDO" },
                }
            },

            new Pergunta
            {
                Id = 39,
                Enunciado = "Quem foi eleito presidente da África do Sul em 1994?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "NELSON PIQUET" },
                    new Alternativa { Correta = true, Descricao = "NELSON MANDELA" },
                    new Alternativa { Correta = false, Descricao = "NELSON NED" },
                    new Alternativa { Correta = false, Descricao = "JOHN NELSON" },
                }
            },

            new Pergunta
            {
                Id = 40,
                Enunciado = "Qual cantor ficou conhecido como “O rei da voz”?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ORLANDO SILVA" },
                    new Alternativa { Correta = false, Descricao = "VICENTE CELESTINO" },
                    new Alternativa { Correta = true, Descricao = "FRANCISCO ALVES" },
                    new Alternativa { Correta = false, Descricao = "CARLOS GALHARDO" },
                }
            },
            new Pergunta
            {
                Id = 41,
                Enunciado = "Em qual espécie o macho choca os ovos e a fêmea procura alimento?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ANDORINHA" },
                    new Alternativa { Correta = false, Descricao = "PATO SELVAGEM" },
                    new Alternativa { Correta = true, Descricao = "PINGÜIM" },
                    new Alternativa { Correta = false, Descricao = "MARRECO" },
                }
            },

            new Pergunta
            {
                Id = 42,
                Enunciado = "Em qual país está localizado o ‘Muro das lamentações’?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ALEMANHA" },
                    new Alternativa { Correta = false, Descricao = "BRASIL" },
                    new Alternativa { Correta = false, Descricao = "VENEZUELA" },
                    new Alternativa { Correta = true, Descricao = "ISRAEL" },
                }
            },

            new Pergunta
            {
                Id = 43,
                Enunciado = "Qual desses países não fica na Ásia?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "PAQUISTÃO" },
                    new Alternativa { Correta = false, Descricao = "JAPÃO" },
                    new Alternativa { Correta = false, Descricao = "TAILÂNDIA" },
                    new Alternativa { Correta = true, Descricao = "EGITO" },
                }
            },

            new Pergunta
            {
                Id = 44,
                Enunciado = "Qual desses astros de filmes de ação é belga?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ARNOLD SCHWARZENEGGER" },
                    new Alternativa { Correta = false, Descricao = "SYLVESTER STALLONE" },
                    new Alternativa { Correta = false, Descricao = "STEVEN SEAGAL" },
                    new Alternativa { Correta = true, Descricao = "JEAN CLAUDE VAN DAMME" },
                }
            },

            new Pergunta
            {
                Id = 45,
                Enunciado = "Onde foi conduzida a vitória das forças aliadas na Segunda Guerra Mundial?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "CANNES" },
                    new Alternativa { Correta = true, Descricao = "NORMANDIA" },
                    new Alternativa { Correta = false, Descricao = "CAPRI" },
                    new Alternativa { Correta = false, Descricao = "MARSELHA" },
                }
            },

            new Pergunta
            {
                Id = 46,
                Enunciado = "Onde nasceu Van Gogh, o grande pintor impressionista?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "POLÔNIA" },
                    new Alternativa { Correta = false, Descricao = "FRANÇA" },
                    new Alternativa { Correta = false, Descricao = "ITÁLIA" },
                    new Alternativa { Correta = true, Descricao = "HOLANDA" },
                }
            },

            new Pergunta
            {
                Id = 47,
                Enunciado = "Qual é a primeira letra do alfabeto grego?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DELTA" },
                    new Alternativa { Correta = false, Descricao = "BETA" },
                    new Alternativa { Correta = true, Descricao = "ALFA" },
                    new Alternativa { Correta = false, Descricao = "GAMA" },
                }
            },

            new Pergunta
            {
                Id = 48,
                Enunciado = "Qual presidente brasileiro instituiu o AI-5?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "COSTA E SILVA" },
                    new Alternativa { Correta = false, Descricao = "ERNESTO GEISEL" },
                    new Alternativa { Correta = false, Descricao = "JOÃO FIGUEIREDO" },
                    new Alternativa { Correta = false, Descricao = "ITAMAR FRANCO" },
                }
            },

            new Pergunta
            {
                Id = 49,
                Enunciado = "O que significa literalmente Perestroika?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "CONVERSÃO" },
                    new Alternativa { Correta = false, Descricao = "INVOLUÇÃO" },
                    new Alternativa { Correta = true, Descricao = "REESTRUTURAÇÃO" },
                    new Alternativa { Correta = false, Descricao = "REGRESSÃO" },
                }
            },

            new Pergunta
            {
                Id = 50,
                Enunciado = "Qual desses quatro pesos é o mais leve?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "10 ONÇAS" },
                    new Alternativa { Correta = true, Descricao = "10 GRAMAS" },
                    new Alternativa { Correta = false, Descricao = "10 QUILOS" },
                    new Alternativa { Correta = false, Descricao = "10 LIBRAS" },
                }
            },

            new Pergunta
            {
                Id = 51,
                Enunciado = "Brahma é o deus de que religião?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "HINDUÍSMO" },
                    new Alternativa { Correta = false, Descricao = "XINTOÍSMO" },
                    new Alternativa { Correta = false, Descricao = "BUDISMO" },
                    new Alternativa { Correta = false, Descricao = "ISLAMISMO" },
                }
            },

            new Pergunta
            {
                Id = 52,
                Enunciado = "Os nazistas foram julgados em:",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "BERLIM" },
                    new Alternativa { Correta = true, Descricao = "NUREMBERGUE" },
                    new Alternativa { Correta = false, Descricao = "MUNIQUE" },
                    new Alternativa { Correta = false, Descricao = "PARIS" },
                }
            },

            new Pergunta
            {
                Id = 53,
                Enunciado = "Que ramo da pecuária ocupa-se de bodes e cabras?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ASININO" },
                    new Alternativa { Correta = true, Descricao = "CAPRINO" },
                    new Alternativa { Correta = false, Descricao = "BUFALINO" },
                    new Alternativa { Correta = false, Descricao = "MUAR" },
                }
            },

            new Pergunta
            {
                Id = 54,
                Enunciado = "Qual oceano tem o maior volume de água?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ATLÂNTICO" },
                    new Alternativa { Correta = true, Descricao = "PACÍFICO" },
                    new Alternativa { Correta = false, Descricao = "ÍNDICO" },
                    new Alternativa { Correta = false, Descricao = "ÁRTICO" },
                }
            },

            new Pergunta
            {
                Id = 55,
                Enunciado = "Qual foi o último presidente militar do Brasil?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "FERNANDO COLLOR" },
                    new Alternativa { Correta = true, Descricao = "JOÃO FIGUEIREDO" },
                    new Alternativa { Correta = false, Descricao = "TANCREDO NEVES" },
                    new Alternativa { Correta = false, Descricao = "JOÃO GOULART" },
                }
            },

            new Pergunta
            {
                Id = 56,
                Enunciado = "Que conflito ideológico envolveu os EUA e a União Soviética?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "GUERRA FRIA" },
                    new Alternativa { Correta = false, Descricao = "GUERRA DO VIETNÃ" },
                    new Alternativa { Correta = false, Descricao = "GUERRA NAS ESTRELAS" },
                    new Alternativa { Correta = false, Descricao = "GUERRA DA CORÉIA" },
                }
            },

            new Pergunta
            {
                Id = 57,
                Enunciado = "O trapézio é um músculo que está situado:",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "NO PESCOÇO" },
                    new Alternativa { Correta = true, Descricao = "NO OMBRO" },
                    new Alternativa { Correta = false, Descricao = "NA CABEÇA" },
                    new Alternativa { Correta = false, Descricao = "NO BRAÇO" },
                }
            },

            new Pergunta
            {
                Id = 58,
                Enunciado = "Quem escreveu o livro ‘A sangue frio’ em 1966?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "TRUMAN CAPOTE" },
                    new Alternativa { Correta = false, Descricao = "HENRY JAMES" },
                    new Alternativa { Correta = false, Descricao = "JOHN STEINBECK" },
                    new Alternativa { Correta = false, Descricao = "TONI MORRISON" },
                }
            },

            new Pergunta
            {
                Id = 59,
                Enunciado = "Quem escreveu ‘Ulisses’ em 1922?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ERNEST HEMINGWAY" },
                    new Alternativa { Correta = false, Descricao = "MARCEL PROUST" },
                    new Alternativa { Correta = false, Descricao = "T.S. ELLIOT" },
                    new Alternativa { Correta = true, Descricao = "JAMES JOYCE" },
                }
            },

            new Pergunta
            {
                Id = 60,
                Enunciado = "Qual o símbolo químico do radônio?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Rr" },
                    new Alternativa { Correta = false, Descricao = "Rd" },
                    new Alternativa { Correta = true, Descricao = "Rn" },
                    new Alternativa { Correta = false, Descricao = "Ro" },
                }
            },
        };
        public App()
        {
            InitializeComponent()

            MainPage = new AppShell();
        }
    }
}
