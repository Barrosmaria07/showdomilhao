using Showdomilhao;

namespace ShowDoMilhao;

public partial class Jogopage : ContentPage
{

	Gerenciador gerenciador;
int pulou=1;
	public Jogopage()
  
	{
		InitializeComponent();
    	gerenciador = new Gerenciador(labelPergunta, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05, labelPontuacao,labelNivel);
	}

  private void OnbtnResposta01Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaResposta(1);
  }

  private void OnbtnResposta02Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaResposta(2);
  }

  private void OnbtnResposta03Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaResposta(3);
  }

  private void OnbtnResposta04Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaResposta(4);
  }

  private void OnbtnResposta05Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaResposta(5);
  }

    void OnAjudaRetirarClicked(object sender, EventArgs e)
    {
    var ajuda =new RetiraErradas();
		ajuda.ConfiguraDesenho (btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
		ajuda.RealizaAjuda(gerenciador.GetQuestaoCorrente());
		(sender as Button).IsVisible=false; 
    }
	

  void OnPularClicked(object sender, EventArgs e) 
  {
    if (pulou==3)
    (sender as Button).IsVisible=false;
    else
    {
      gerenciador.ProximaQuestao();
      pulou++;
    }
  }
    
  }




