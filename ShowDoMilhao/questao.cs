using System.Security.AccessControl;
using Microsoft.Maui.Controls.Compatibility.Platform.iOS;

namespace ShowDoMilhao
{
    public class questao
    {
        public string Pergunta;
        public string Resposta1;
        public string Resposta2;
        public string Resposta3;
        public string Resposta4;
        public string Resposta5;
        public string RespostaCerta;
        public int  Nivel;
        private Label labelPergunta;
        private Button btResposta01;
        private Button btResposta02;
        private Button btResposta03;
        private Button btResposta04;
        private Button btResposta05;

       
        public questao ()
        {

        }
        public void desenhar ()
        {
            labelPergunta.Text=Pergunta;
            btResposta01.Text= Resposta1
            btResposta02.Text= Resposta2
            btResposta03.Text= Resposta3
            btResposta04.Text= Resposta4
            btResposta05.Text= Resposta5

        }
        public questao (Label LP, Button bt01,Button bt02,Button bt03,Button bt04,Button bt05)
        {
            labelPergunta=LP;
            btResposta01=bt01;
            btResposta02=bt02;
            btResposta03=bt03;
            btResposta04=bt04;
            btResposta05=bt05; 

        }
  public void estruturadedesenho (Label LP, Button bt01,Button bt02,Button bt03,Button bt04,Button bt05)
        {
            labelPergunta=LP;
            btResposta01=bt01;
            btResposta02=bt02;
            btResposta03=bt03;
            btResposta04=bt04;
            btResposta05=bt05;
        
        }
        public bool VerificaResposta(int respondido)
        {
            if (respondido == RespostaCerta)
            {
                var BTN =Qual BTN (RR);
                    BTN. BackgroundColor= Colors.Green;
            }
            return true;
            {
                else
            }
            ReturnFalse;
            {
                
            }
        }
    }
}
