

namespace ShowDoMilhao
{
    public class Questao
    {
        public string Pergunta;
        public string Resposta1;
        public string Resposta2;
        public string Resposta3;
        public string Resposta4;
        public string Resposta5;
        public int RespostaCerta;

        public int  Nivel;
        private Label labelPergunta;
        private Button btResposta01;
        private Button btResposta02;
        private Button btResposta03;
        private Button btResposta04;
        private Button btResposta05;
        private Button QualBtn (int rr)
        {
            if (rr ==1)
                return btResposta01;
                else if (rr ==2)
                return btResposta02;
                else if (rr ==3)
                return btResposta03;
                  else if (rr ==4)
                return btResposta04;
                  else if (rr ==5)
                return btResposta05;
                else
                return null;
               
        }
       
        public Questao ()
        {

        }
        public void Desenhar ()
        {
            labelPergunta.Text=Pergunta;
            btResposta01.Text= Resposta1;
            btResposta02.Text= Resposta2;
            btResposta03.Text= Resposta3;
            btResposta04.Text= Resposta4;
            btResposta05.Text= Resposta5;

            btResposta01!.BackgroundColor = Colors.DarkBlue;
            btResposta01!.TextColor       = Colors.White;
            btResposta02!.BackgroundColor = Colors.DarkBlue;
            btResposta02!.TextColor       = Colors.White;
            btResposta03!.BackgroundColor = Colors.DarkBlue;
            btResposta03!.TextColor       = Colors.White;
            btResposta04!.BackgroundColor = Colors.DarkBlue;
            btResposta04!.TextColor       = Colors.White;
            btResposta05!.BackgroundColor = Colors.DarkBlue;
            btResposta05!.TextColor       = Colors.White; 

        }
        public Questao (Label LP, Button bt01,Button bt02,Button bt03,Button bt04,Button bt05)
        {
            labelPergunta=LP;
            btResposta01=bt01;
            btResposta02=bt02;
            btResposta03=bt03;
            btResposta04=bt04;
            btResposta05=bt05; 

        }
  public void Estruturadedesenho (Label LP, Button bt01,Button bt02,Button bt03,Button bt04,Button bt05)
        {
            labelPergunta=LP;
            btResposta01=bt01;
            btResposta02=bt02;
            btResposta03=bt03;
            btResposta04=bt04;
            btResposta05=bt05;
        
        }
        public bool VerificaResposta(int Respondido)
        {
            if (Respondido == RespostaCerta)
            {
                var Btn =QualBtn (Respondido);
                    Btn.BackgroundColor= Colors.Green;
                    return true;
            }
                else
           {
            var BtnCorreto = QualBtn (RespostaCerta);
            var BtnIncorreto = QualBtn (Respondido);
                BtnCorreto.BackgroundColor = Colors.Yellow;
                BtnIncorreto.BackgroundColor= Colors.Purple;
                return false; 
           }
        }
    }
}
