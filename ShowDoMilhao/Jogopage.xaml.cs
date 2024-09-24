using Showdomilhao;

namespace ShowDoMilhao;

public partial class Jogopage : ContentPage
{

	Gerenciador gerenciador;

	public Jogopage()
	{
		InitializeComponent();
    	gerenciador = new Gerenciador(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05, labelPontuacao,labelNivel);
	}

  private void OnBtnResposta01Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaResposta(1);
  }

  private void OnBtnResposta02Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaResposta(2);
  }

  private void OnBtnResposta03Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaResposta(3);
  }

  private void OnBtnResposta04Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaResposta(4);
  }

  private void OnBtnResposta05Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaResposta(5);
  }
}

