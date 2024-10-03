using ShowDoMilhao;

public abstract class IAjuda
{
        protected Button btnResposta01;
        protected Button btnResposta02;
        protected Button btnResposta03;
        protected Button btnResposta04;
        protected Button btnResposta05;
        protected Frame btnAjuda;
         public void ConfiguraDesenho (Button btnresposta01, Button btnresposta02, Button btnresposta03, Button btnresposta04, Button btnresposta05)
         {
            this.btnResposta01= btnResposta01;
            this.btnResposta02= btnResposta02;
            this.btnResposta03= btnResposta03;
            this.btnResposta04= btnResposta04;
            this.btnResposta05= btnResposta05;
         }
          public void ConfiguraDesenho (Frame frameAjuda)
          {
            this.frameAjuda= frameAjuda;
        
          }
          public abstract void  RealizaAjuda (Questao questao);
}
