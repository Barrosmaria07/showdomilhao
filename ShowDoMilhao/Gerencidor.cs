using System.Security.Cryptography.X509Certificates;
using ShowDoMilhao;

namespace Shoewdomilhao
(
public class Gerenciador
{
    List <questao> ListaQuestoes=new List<questao>();
    List <int> ListaQuestoesRespondidas=new List<int>();
    questao QuestaoAtual;

    public Gerenciador(Label labelPerg, Button btnResp01,Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05 )
    {
        CriaPerguntas (labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
    }
    {
        async void CriaPerguntas (Label LabelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05)
        {
            var Q1 = new Questao();
            Q1.ConfigurarDesenho (LabelPerg, btnResp01,btnResp02,btnResp03,btnResp04,btnResp05 );
            Q1.Pergunta= "Quanto é 2+2?";
            Q1.Resposta1= "2";
            Q1.Resposta2="22";
            Q1.Resposta3="34";
            Q1.Resposta4="1";
            Q1.Resposta5="5";
            Q1.RespostaCorreta= 3;
            ListaQuestoes.Add(Q1);


            var Q2= new questao ();
                Q2.ConfigurarDesenho (LabelPerg, btnResp01,btnResp02,btnResp03,btnResp04,btnResp05 );
                Q2.Pergunta= "Quanto é 2+2?";
                Q2.Resposta1= "2";
                Q2.Resposta2="22";
                Q2.Resposta3="34";
                Q2.Resposta4="1";
                Q2.Resposta5="5";
                Q2.RespostaCorreta= 3;
                ListaQuestoes.Add(Q2);


             var Q3= new questao ();
                Q3.ConfigurarDesenho (LabelPerg, btnResp01,btnResp02,btnResp03,btnResp04,btnResp05 );
                Q3.Pergunta= "Quanto é 2+2?";
                Q3.Resposta1= "2";
                Q3.Resposta2="22";
                Q3.Resposta3="34";
                Q3.Resposta4="1";
                Q3.Resposta5="5";
                Q3.RespostaCorreta= 3;
                ListaQuestoes.Add(Q3);


             var Q4= new questao ();
                Q4.ConfigurarDesenho (LabelPerg, btnResp01,btnResp02,btnResp03,btnResp04,btnResp05 );
                Q4.Pergunta= "Quanto é 2+2?";
                Q4.Resposta1= "2";
                Q4.Resposta2="22";
                Q4.Resposta3="34";
                Q4.Resposta4="1";
                Q4.Resposta5="5";
                Q4.RespostaCorreta= 3;
                ListaQuestoes.Add(Q4);


              var Q5= new questao ();
                Q5.ConfigurarDesenho (LabelPerg, btnResp01,btnResp02,btnResp03,btnResp04,btnResp05 );
                Q5.Pergunta= "Quanto é 2+2?";
                Q5.Resposta1= "2";
                Q5.Resposta2="22";
                Q5.Resposta3="34";
                Q5.Resposta4="1";
                Q5.Resposta5="5";
                Q5.RespostaCorreta= 3;
                ListaQuestoes.Add(Q5);


              var Q6= new questao ();
                Q6.ConfigurarDesenho (LabelPerg, btnResp01,btnResp02,btnResp03,btnResp04,btnResp05 );
                Q6.Pergunta= "Quanto é 2+2?";
                Q6.Resposta1= "2";
                Q6.Resposta2="22";
                Q6.Resposta3="34";
                Q6.Resposta4="1";
                Q6.Resposta5="5";
                Q6.RespostaCorreta= 3;
                ListaQuestoes.Add(Q6);


              var Q7= new questao ();
                Q7.ConfigurarDesenho (LabelPerg, btnResp01,btnResp02,btnResp03,btnResp04,btnResp05 );
                Q7.Pergunta= "Quanto é 2+2?";
                Q7.Resposta1= "2";
                Q7.Resposta2="22";
                Q7.Resposta3="34";
                Q7.Resposta4="1";
                Q7.Resposta5="5";
                Q7.RespostaCorreta= 3;
                ListaQuestoes.Add(Q7);



               var Q8= new questao ();
                Q8.ConfigurarDesenho (LabelPerg, btnResp01,btnResp02,btnResp03,btnResp04,btnResp05 );
                Q8.Pergunta= "Quanto é 2+2?";
                Q8.Resposta1= "2";
                Q8.Resposta2="22";
                Q8.Resposta3="34";
                Q8.Resposta4="1";
                Q8.Resposta5="5";
                Q8.RespostaCorreta= 3;
                ListaQuestoes.Add(Q8);



             var Q9= new questao ();
                Q9.ConfigurarDesenho (LabelPerg, btnResp01,btnResp02,btnResp03,btnResp04,btnResp05 );
                Q9.Pergunta= "Quanto é 2+2?";
                Q9.Resposta1= "2";
                Q9.Resposta2="22";
                Q9.Resposta3="34";
                Q9.Resposta4="1";
                Q9.Resposta5="5";
                Q9.RespostaCorreta= 3;
                ListaQuestoes.Add(Q2);



             var Q10= new questao ();
                Q10.ConfigurarDesenho (LabelPerg, btnResp01,btnResp02,btnResp03,btnResp04,btnResp05 );
                Q10.Pergunta= "Quanto é 2+2?";
                Q10.Resposta1= "2";
                Q10.Resposta2="22";
                Q10.Resposta3="34";
                Q10.Resposta4="1";
                Q10.Resposta5="5";
                Q10.RespostaCorreta= 3;
                ListaQuestoes.Add(Q10);




             var Q11= new questao ();
                Q11.ConfigurarDesenho (LabelPerg, btnResp01,btnResp02,btnResp03,btnResp04,btnResp05 );
                Q11.Pergunta= "Quanto é 2+2?";
                Q11.Resposta1= "2";
                Q11.Resposta2="22";
                Q11.Resposta3="34";
                Q11.Resposta4="1";
                Q11.Resposta5="5";
                Q11.RespostaCorreta= 3;
                ListaQuestoes.Add(Q11);




             var Q12= new questao ();
                Q12.ConfigurarDesenho (LabelPerg, btnResp01,btnResp02,btnResp03,btnResp04,btnResp05 );
                Q12.Pergunta= "Quanto é 2+2?";
                Q12.Resposta1= "2";
                Q12.Resposta2="22";
                Q12.Resposta3="34";
                Q12.Resposta4="1";
                Q12.Resposta5="5";
                Q12.RespostaCorreta= 3;
                ListaQuestoes.Add(Q12); 



                Public async VerificaCorreta (int RespostaEscolhida)
                {
                    if (QuestaoAtual.VerificaResposta(RespostaEscolhida))
                    {
                        await Task.Delay(1000);
                        ProximaQuestao();
                    }
                }

                {
                    void ProximaQuestao()
                    {
                        var numAleat= Random.Shared.Next(0 , ListaQuestoes.Count);
                        while (ListaQuestoesRespondidas.Contains(numAleat))
                          numAleat=Random.Shared.Next(0, ListaQuestoes.Count);

                        ListaQuestoesRespondidas.Add(numAleat);
                            QuestaoCorrente = ListaQuestoes[numAleat];
                            QuestaoCorrente.Desenha();
                    }
                }


    }
}
)