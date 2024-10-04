namespace ShowDoMilhao;
public class RetiraErradas:IAjuda
{
    public override void RealizaAjuda(Questao questao)
    {
        switch (questao.RespostaCerta)
        {
            case 1:
            btnResposta02.IsVisible=false;
            btnResposta03.IsVisible=false;
            btnResposta04.IsVisible=false;
            break;
            case 2:
            btnResposta01.IsVisible=false;
            btnResposta03.IsVisible=false;
            btnResposta05.IsVisible=false;
            break;
           case 3:
            btnResposta02.IsVisible=false;
            btnResposta01.IsVisible=false;
            btnResposta04.IsVisible=false;
            break;
            case 4:
            btnResposta01.IsVisible=false;
            btnResposta03.IsVisible=false;
            btnResposta05.IsVisible=false;
            break; 
            case 5:
            btnResposta01.IsVisible=false;
            btnResposta03.IsVisible=false;
            btnResposta02.IsVisible=false;
            break;           
         
        }
    }
}