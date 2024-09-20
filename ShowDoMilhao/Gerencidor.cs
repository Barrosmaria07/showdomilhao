using System.Security.Cryptography.X509Certificates;
using ShowDoMilhao;

namespace Showdomilhao;
public class Gerenciador
{
  List<questao> ListaQuestoes = new List<questao>();
  List<int> ListaQuestoesRespondidas = new List<int>();
  questao QuestaoCorrente;

  public Gerenciador(Label labelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05)
  {
    CriaPerguntas(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
  }

  async void CriaPerguntas(Label LabelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05)
  {
    var Q1 = new questao();
    Q1.estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
    Q1.Pergunta = "Quanto é 2+2?";
    Q1.Resposta1 = "2";
    Q1.Resposta2 = "22";
    Q1.Resposta3 = "34";
    Q1.Resposta4 = "1";
    Q1.Resposta5 = "5";
    Q1.RespostaCerta = 3;
    ListaQuestoes.Add(Q1);

  }


  public async void VerificaResposta(int Respondido)
  {
    if (QuestaoCorrente.VerificaResposta(Respondido))
    {
      await Task.Delay(1000);
      ProximaQuestao();
    }
  }
  void ProximaQuestao()
  {
    var numAleat = Random.Shared.Next(0, ListaQuestoes.Count);
    while (ListaQuestoesRespondidas.Contains(numAleat))
      numAleat = Random.Shared.Next(0, ListaQuestoes.Count);

    ListaQuestoesRespondidas.Add(numAleat);
    QuestaoCorrente = ListaQuestoes [numAleat];
    QuestaoCorrente.Desenhar();
  }
}


