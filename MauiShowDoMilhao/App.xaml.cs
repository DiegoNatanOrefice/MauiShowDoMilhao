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
        };
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
