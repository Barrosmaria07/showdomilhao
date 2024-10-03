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

  private void Onbtnresposta01Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaResposta(1);
  }

  private void Onbtnresposta02Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaResposta(2);
  }

  private void Onbtnresposta03Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaResposta(3);
  }

  private void Onbtnresposta04Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaResposta(4);
  }

  private void Onbtnresposta05Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaResposta(5);
  }

    void OnAjudaRetirarClicked(object sender, EventArgs e)
    {
    var ajuda =new RetiraErradas();
		ajuda.ConfiguraDesenho (btnresposta01, btnresposta02, btnresposta03, btnresposta04, btnresposta05);
		ajuda.RealizaAjuda(Gerenciador.GetQuestaoCorrente());
		(s as Button).IsVisible=false; 
    }
	

  void OnAjudaPulaClicked(object sender, EventArgs e) 
  {
    gerenciador.ProximaQuestao();
    (s as Button).IsVisible=false;
  }


}

