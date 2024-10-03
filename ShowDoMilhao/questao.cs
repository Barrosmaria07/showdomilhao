

namespace ShowDoMilhao;

 public class Questao: IEquatable <Questao>
        {
            public bool Equals (Questao q)
            {
                return this.Nivel == q.Nivel &&
                this.Pergunta == q.Pergunta;
            }
        

        public string Pergunta;
        public string Resposta1;
        public string Resposta2;
        public string Resposta3;
        public string Resposta4;
        public string Resposta5;
        public int RespostaCerta;

        public int  Nivel;
        private Label labelPergunta;
        private Button btnresposta01;
        private Button btnresposta02;
        private Button btnresposta03;
        private Button btnresposta04;
        private Button btnresposta05;
        private Button QualBtn (int rr)
        {
            if (rr ==1)
                return btnresposta01;
                else if (rr ==2)
                return btnresposta02;
                else if (rr ==3)
                return btnresposta03;
                  else if (rr ==4)
                return btnresposta04;
                  else if (rr ==5)
                return btnresposta05;
                else
                return null;
               
        }
       
        public Questao ()
        {

        }
        public void Desenhar ()
        {
            labelPergunta.Text=Pergunta;
            btnresposta01.Text= Resposta1;
            btnresposta02.Text= Resposta2;
            btnresposta03.Text= Resposta3;
            btnresposta04.Text= Resposta4;
            btnresposta05.Text= Resposta5;

            btnresposta01!.BackgroundColor = Colors.DarkBlue;
            btnresposta01!.TextColor       = Colors.White;
            btnresposta02!.BackgroundColor = Colors.DarkBlue;
            btnresposta02!.TextColor       = Colors.White;
            btnresposta03!.BackgroundColor = Colors.DarkBlue;
            btnresposta03!.TextColor       = Colors.White;
            btnresposta04!.BackgroundColor = Colors.DarkBlue;
            btnresposta04!.TextColor       = Colors.White;
            btnresposta05!.BackgroundColor = Colors.DarkBlue;
            btnresposta05!.TextColor       = Colors.White; 

        }
        public Questao (Label LP, Button bt01,Button bt02,Button bt03,Button bt04,Button bt05)
        {
            labelPergunta=LP;
            btnresposta01=bt01;
            btnresposta02=bt02;
            btnresposta03=bt03;
            btnresposta04=bt04;
            btnresposta05=bt05; 

        }
  public void Estruturadedesenho (Label LP, Button bt01,Button bt02,Button bt03,Button bt04,Button bt05)
        {
            labelPergunta=LP;
            btnresposta01=bt01;
            btnresposta02=bt02;
            btnresposta03=bt03;
            btnresposta04=bt04;
            btnresposta05=bt05;
        
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

