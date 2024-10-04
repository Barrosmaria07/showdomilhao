using ShowDoMilhao;

public abstract class IAjuda
{
        protected Button btnResposta01;
        protected Button btnResposta02;
        protected Button btnResposta03;
        protected Button btnResposta04;
        protected Button btnResposta05;
        protected Frame btnAjuda;
         public void ConfiguraDesenho (Button btnResposta01, Button btnResposta02, Button btnResposta03, Button btnResposta04, Button btnResposta05)
         {
            this.btnResposta01= btnResposta01;
            this.btnResposta02= btnResposta02;
            this.btnResposta03= btnResposta03;
            this.btnResposta04= btnResposta04;
            this.btnResposta05= btnResposta05;
         }
  
          public abstract void  RealizaAjuda (Questao questao);
}
