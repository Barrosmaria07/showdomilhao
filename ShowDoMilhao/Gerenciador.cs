using ShowDoMilhao;

namespace Showdomilhao;
public class Gerenciador
{
  List<Questao> ListaTodasQuestoes = new List<Questao>();
  List<Questao> ListTodasQuestoesRespondidas = new List<Questoes>();
  Questao QuestaoCorrente;
  public int pontuacao {get; private set;}
  int NivelAtual = 0;
  Label labelPontuacao;
  Label labelNivel;



  public Gerenciador(Label labelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05, Label labelPontuacao, Label labelNivel)
  {
    CriaPerguntas(labelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
    this.labelPontuacao = labelPontuacao;
    this.labelNivel = labelNivel;
  }

   public async void VerificaResposta(int Respondido)
  {
    if (QuestaoCorrente.VerificaResposta(Respondido))
    {
      await Task.Delay(1000);
      AdicionaPontuacao(NivelAtual);
      if (NivelAtual == 10)
        {
            await App.Current.MainPage.DisplayAlert("Parabéns!", "Você completou o nível 10!", "OK");
        }
      NivelAtual++;
      ProximaQuestao();
    }
    else 
    {
      await App.Current.MainPage.DisplayAlert("FIM!", "VOCÊ ERROU", "OK!");
            Inicializar();
    }
    labelPontuacao.Text = "Pontuacao:R$" + pontuacao.ToString();
    labelNivel.Text = "Nivel:" + NivelAtual.ToString(); 
  }


  void ProximaQuestao()
  {
    var listaQuestoes= ListaTodasQuestoes.Where(d=>.Nivel==NivelCorrente).ToList();
    var numRand=Random.Shared.Next (0,listaQuestoes.Count-1);
    var novaQuestao=listaQuestoes[numRand];
    while (ListaTodasQuestoesRespondidas.Contains(novaQuestao))
  }
  void AdicionaPontuacao(int n)
    {
        if ( n==1)
            pontuacao = 1000;
        else if ( n==2)
            pontuacao = 2000;
        else if ( n == 3)
            pontuacao = 5000;
        else if ( n==4)
            pontuacao = 10000;
        else if ( n==5)
            pontuacao = 20000;
        else if ( n==6)
            pontuacao = 50000;
        else if ( n==7)
            pontuacao = 100000;
        else if ( n==8)
            pontuacao = 200000;
        else if ( n==9)
            pontuacao = 500000;
        else 
            pontuacao = 1000000;
    }

    void Inicializar()
    {
        pontuacao = 0;
        NivelAtual = 1;
        ProximaQuestao();
    }

  async void CriaPerguntas(Label LabelPerg, Button btnResp01, Button btnResp02, Button btnResp03, Button btnResp04, Button btnResp05)
  {
    var Q1 = new Questao();
    Q1.Nivel = 1;
    Q1.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
    Q1.Pergunta = "Quanto é 2+2?";
    Q1.Resposta1 = "2";
    Q1.Resposta2 = "22";
    Q1.Resposta3 = "34";
    Q1.Resposta4 = "1";
    Q1.Resposta5 = "5";
    Q1.RespostaCerta = 3;
    ListaTodasQuestoes.Add(Q1);

    var Q2 = new Questao();
    Q2.Nivel = 1;
    Q2.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
    Q2.Pergunta = "Qual a capital da França?";
    Q2.Resposta1 = "Paris"; // Resposta correta
    Q2.Resposta2 = "Londres";
    Q2.Resposta3 = "Berlim";
    Q2.Resposta4 = "Madri";
    Q2.Resposta5 = "Roma";
    Q2.RespostaCerta = 1;
    ListaTodasQuestoes.Add(Q2);

    // Pergunta 3
    var Q3 = new Questao();
    Q3.Nivel = 1;
    Q3.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
    Q3.Pergunta = "Qual é o maior planeta do sistema solar?";
    Q3.Resposta1 = "Terra";
    Q3.Resposta2 = "Marte";
    Q3.Resposta3 = "Júpiter"; // Resposta correta
    Q3.Resposta4 = "Saturno";
    Q3.Resposta5 = "Netuno";
    Q3.RespostaCerta = 3;
    ListaTodasQuestoes.Add(Q3);

    // Pergunta 4
    var Q4 = new Questao();
    Q4.Nivel = 1;
    Q4.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
    Q4.Pergunta = "Quantos continentes existem?";
    Q4.Resposta1 = "5";
    Q4.Resposta2 = "6";
    Q4.Resposta3 = "7"; // Resposta correta
    Q4.Resposta4 = "8";
    Q4.Resposta5 = "4";
    Q4.RespostaCerta = 2;
    ListaTodasQuestoes.Add(Q4);

    // Pergunta 5
    var Q5 = new Questao();
    Q5.Nivel = 1;
    Q5.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
    Q5.Pergunta = "Quem escreveu 'Dom Casmurro'?";
    Q5.Resposta1 = "Machado de Assis"; // Resposta correta
    Q5.Resposta2 = "Joaquim Manuel de Macedo";
    Q5.Resposta3 = "José de Alencar";
    Q5.Resposta4 = "Clarice Lispector";
    Q5.Resposta5 = "Graciliano Ramos";
    Q5.RespostaCerta = 1;
    ListaTodasQuestoes.Add(Q5);

    // Pergunta 6
    var Q6 = new Questao();
    Q6.Nivel = 1;
    Q6.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
    Q6.Pergunta = "Qual o símbolo químico do ouro?";
    Q6.Resposta1 = "Au"; // Resposta correta
    Q6.Resposta2 = "Ag";
    Q6.Resposta3 = "Fe";
    Q6.Resposta4 = "Pb";
    Q6.Resposta5 = "Hg";
    Q6.RespostaCerta = 1;
    ListaTodasQuestoes.Add(Q6);

    // Pergunta 7
    var Q7 = new Questao();
    Q7.Nivel = 1;
    Q7.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
    Q7.Pergunta = "Qual a fórmula da água?";
    Q7.Resposta1 = "H2O"; // Resposta correta
    Q7.Resposta2 = "O2";
    Q7.Resposta3 = "CO2";
    Q7.Resposta4 = "H2";
    Q7.Resposta5 = "NaCl";
    Q7.RespostaCerta = 1;
    ListaTodasQuestoes.Add(Q7);

    // Pergunta 8
    var Q8 = new Questao();
    Q8.Nivel = 1;
    Q8.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
    Q8.Pergunta = "Quantos anos tem uma década?";
    Q8.Resposta1 = "5";
    Q8.Resposta2 = "10"; // Resposta correta
    Q8.Resposta3 = "15";
    Q8.Resposta4 = "20";
    Q8.Resposta5 = "25";
    Q8.RespostaCerta = 2;
    ListaTodasQuestoes.Add(Q8);

    // Pergunta 9
    var Q9 = new Questao();
    Q9.Nivel = 1;
    Q9.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
    Q9.Pergunta = "Qual é o elemento mais abundante no universo?";
    Q9.Resposta1 = "Oxigênio";
    Q9.Resposta2 = "Hidrogênio"; // Resposta correta
    Q9.Resposta3 = "Carbono";
    Q9.Resposta4 = "Nitrogênio";
    Q9.Resposta5 = "Hélio";
    Q9.RespostaCerta = 2;
    ListaTodasQuestoes.Add(Q9);

    // Pergunta 10
    var Q10 = new Questao();
    Q10.Nivel = 1;
    Q10.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
    Q10.Pergunta = "Quem pintou a Mona Lisa?";
    Q10.Resposta1 = "Vincent van Gogh";
    Q10.Resposta2 = "Pablo Picasso";
    Q10.Resposta3 = "Leonardo da Vinci"; // Resposta correta
    Q10.Resposta4 = "Claude Monet";
    Q10.Resposta5 = "Michelangelo";
    Q10.RespostaCerta = 3;
    ListaTodasQuestoes.Add(Q10);

    // Pergunta 11
var Q11 = new Questao();
Q11.Nivel = 2;
Q11.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q11.Pergunta = "Qual é a raiz quadrada de 144?";
Q11.Resposta1 = "10";
Q11.Resposta2 = "11";
Q11.Resposta3 = "12"; // Resposta correta
Q11.Resposta4 = "14";
Q11.Resposta5 = "15";
Q11.RespostaCerta = 3;
ListaTodasQuestoes.Add(Q11);

// Pergunta 12
var Q12 = new Questao();
Q12.Nivel = 2;
Q12.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q12.Pergunta = "Qual é a fórmula da gravidade?";
Q12.Resposta1 = "F = m * a";
Q12.Resposta2 = "F = G * (m1*m2)/r^2"; // Resposta correta
Q12.Resposta3 = "F = m * g";
Q12.Resposta4 = "F = m * v";
Q12.Resposta5 = "F = G * m";
Q12.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q12);

// Pergunta 13
var Q13 = new Questao();
Q13.Nivel = 2;
Q13.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q13.Pergunta = "Quem é conhecido como o pai da física moderna?";
Q13.Resposta1 = "Isaac Newton";
Q13.Resposta2 = "Albert Einstein"; // Resposta correta
Q13.Resposta3 = "Galileu Galilei";
Q13.Resposta4 = "Niels Bohr";
Q13.Resposta5 = "Stephen Hawking";
Q13.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q13);

// Pergunta 14
var Q14 = new Questao();
Q14.Nivel = 2;
Q14.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q14.Pergunta = "Qual é o maior animal terrestre?";
Q14.Resposta1 = "Elefante"; // Resposta correta
Q14.Resposta2 = "Girafa";
Q14.Resposta3 = "Hipopótamo";
Q14.Resposta4 = "Urso-polar";
Q14.Resposta5 = "Rinoceronte";
Q14.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q14);

// Pergunta 15
var Q15 = new Questao();
Q15.Nivel = 2;
Q15.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q15.Pergunta = "Qual é a capital do Japão?";
Q15.Resposta1 = "Seul";
Q15.Resposta2 = "Pequim";
Q15.Resposta3 = "Tóquio"; // Resposta correta
Q15.Resposta4 = "Bangkok";
Q15.Resposta5 = "Hanoi";
Q15.RespostaCerta = 3;
ListaTodasQuestoes.Add(Q15);

// Pergunta 16
var Q16 = new Questao();
Q16.Nivel = 2;
Q16.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q16.Pergunta = "Qual é a distância da Terra à Lua?";
Q16.Resposta1 = "384.400 km"; // Resposta correta
Q16.Resposta2 = "500.000 km";
Q16.Resposta3 = "300.000 km";
Q16.Resposta4 = "250.000 km";
Q16.Resposta5 = "450.000 km";
Q16.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q16);

// Pergunta 17
var Q17 = new Questao();
Q17.Nivel = 2;
Q17.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q17.Pergunta = "Qual a principal função das mitocôndrias?";
Q17.Resposta1 = "Produzir energia"; // Resposta correta
Q17.Resposta2 = "Armazenar DNA";
Q17.Resposta3 = "Produzir proteínas";
Q17.Resposta4 = "Reproduzir células";
Q17.Resposta5 = "Proteger a célula";
Q17.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q17);

// Pergunta 18
var Q18 = new Questao();
Q18.Nivel = 2;
Q18.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q18.Pergunta = "Quem pintou o teto da Capela Sistina?";
Q18.Resposta1 = "Raphael";
Q18.Resposta2 = "Michelangelo"; // Resposta correta
Q18.Resposta3 = "Leonardo da Vinci";
Q18.Resposta4 = "Caravaggio";
Q18.Resposta5 = "Botticelli";
Q18.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q18);

// Pergunta 19
var Q19 = new Questao();
Q19.Nivel = 2;
Q19.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q19.Pergunta = "Qual é a moeda oficial da União Europeia?";
Q19.Resposta1 = "Dólar";
Q19.Resposta2 = "Libra";
Q19.Resposta3 = "Euro"; // Resposta correta
Q19.Resposta4 = "Franco";
Q19.Resposta5 = "Yen";
Q19.RespostaCerta = 3;
ListaTodasQuestoes.Add(Q19);

// Pergunta 20
var Q20 = new Questao();
Q20.Nivel = 2;
Q20.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q20.Pergunta = "Qual é a fórmula química do ácido sulfúrico?";
Q20.Resposta1 = "H2SO4"; // Resposta correta
Q20.Resposta2 = "HCl";
Q20.Resposta3 = "NaOH";
Q20.Resposta4 = "CH3COOH";
Q20.Resposta5 = "NH3";
Q20.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q20);

// Pergunta 21
var Q21 = new Questao();
Q21.Nivel = 3;
Q21.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q21.Pergunta = "Qual é a equação da energia em física?";
Q21.Resposta1 = "E = mc^2"; // Resposta correta
Q21.Resposta2 = "F = ma";
Q21.Resposta3 = "E = hf";
Q21.Resposta4 = "P = IV";
Q21.Resposta5 = "V = IR";
Q21.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q21);

// Pergunta 22
var Q22 = new Questao();
Q22.Nivel = 3;
Q22.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q22.Pergunta = "Quem desenvolveu a teoria da evolução?";
Q22.Resposta1 = "Isaac Newton";
Q22.Resposta2 = "Charles Darwin"; // Resposta correta
Q22.Resposta3 = "Albert Einstein";
Q22.Resposta4 = "Galileu Galilei";
Q22.Resposta5 = "Louis Pasteur";
Q22.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q22);

// Pergunta 23
var Q23 = new Questao();
Q23.Nivel = 3;
Q23.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q23.Pergunta = "Qual é o principal gás do efeito estufa?";
Q23.Resposta1 = "Dióxido de carbono"; // Resposta correta
Q23.Resposta2 = "Metano";
Q23.Resposta3 = "Oxigênio";
Q23.Resposta4 = "Nitrogênio";
Q23.Resposta5 = "Hélio";
Q23.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q23);

// Pergunta 24
var Q24 = new Questao();
Q24.Nivel = 3;
Q24.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q24.Pergunta = "Qual é a unidade de medida da força no Sistema Internacional?";
Q24.Resposta1 = "Joule";
Q24.Resposta2 = "Newton"; // Resposta correta
Q24.Resposta3 = "Pascal";
Q24.Resposta4 = "Watt";
Q24.Resposta5 = "Coulomb";
Q24.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q24);

// Pergunta 25
var Q25 = new Questao();
Q25.Nivel = 3;
Q25.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q25.Pergunta = "Qual é a capital da Islândia?";
Q25.Resposta1 = "Reiquiavique"; // Resposta correta
Q25.Resposta2 = "Oslo";
Q25.Resposta3 = "Copenhague";
Q25.Resposta4 = "Estocolmo";
Q25.Resposta5 = "Helsinque";
Q25.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q25);

// Pergunta 26
var Q26 = new Questao();
Q26.Nivel = 3;
Q26.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q26.Pergunta = "Qual foi a primeira mulher a ganhar um Prêmio Nobel?";
Q26.Resposta1 = "Marie Curie"; // Resposta correta
Q26.Resposta2 = "Rosalind Franklin";
Q26.Resposta3 = "Jane Goodall";
Q26.Resposta4 = "Ada Lovelace";
Q26.Resposta5 = "Barbara McClintock";
Q26.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q26);

// Pergunta 27
var Q27 = new Questao();
Q27.Nivel = 3;
Q27.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q27.Pergunta = "Qual é a estrutura básica das proteínas?";
Q27.Resposta1 = "Aminoácidos"; // Resposta correta
Q27.Resposta2 = "Ácidos nucleicos";
Q27.Resposta3 = "Carboidratos";
Q27.Resposta4 = "Lipídios";
Q27.Resposta5 = "Ácidos graxos";
Q27.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q27);

// Pergunta 28
var Q28 = new Questao();
Q28.Nivel = 3;
Q28.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q28.Pergunta = "Qual é o maior deserto do mundo?";
Q28.Resposta1 = "Sahara";
Q28.Resposta2 = "Ártico"; // Resposta correta
Q28.Resposta3 = "Saara";
Q28.Resposta4 = "Gobi";
Q28.Resposta5 = "Kalahari";
Q28.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q28);

// Pergunta 29
var Q29 = new Questao();
Q29.Nivel = 3;
Q29.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q29.Pergunta = "Qual é o principal componente do núcleo atômico?";
Q29.Resposta1 = "Elétrons";
Q29.Resposta2 = "Prótons"; // Resposta correta
Q29.Resposta3 = "Nêutrons";
Q29.Resposta4 = "Fótons";
Q29.Resposta5 = "Neutrinos";
Q29.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q29);

// Pergunta 30
var Q30 = new Questao();
Q30.Nivel = 3;
Q30.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q30.Pergunta = "Qual é a obra mais famosa de William Shakespeare?";
Q30.Resposta1 = "Hamlet"; // Resposta correta
Q30.Resposta2 = "Romeu e Julieta";
Q30.Resposta3 = "Macbeth";
Q30.Resposta4 = "Sonetos";
Q30.Resposta5 = "A Tempestade";
Q30.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q30);

// Pergunta 31
var Q31 = new Questao();
Q31.Nivel = 4;
Q31.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q31.Pergunta = "Qual é a fórmula da distância em movimento uniforme?";
Q31.Resposta1 = "d = vt"; // Resposta correta
Q31.Resposta2 = "d = v/t";
Q31.Resposta3 = "d = at^2";
Q31.Resposta4 = "d = 1/2at^2";
Q31.Resposta5 = "d = vt^2";
Q31.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q31);

// Pergunta 32
var Q32 = new Questao();
Q32.Nivel = 4;
Q32.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q32.Pergunta = "Qual é o nome do efeito que altera a percepção do tempo em alta velocidade?";
Q32.Resposta1 = "Efeito Doppler";
Q32.Resposta2 = "Efeito Relatividade"; // Resposta correta
Q32.Resposta3 = "Efeito da Luz";
Q32.Resposta4 = "Efeito Quântico";
Q32.Resposta5 = "Efeito Newtoniano";
Q32.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q32);

// Pergunta 33
var Q33 = new Questao();
Q33.Nivel = 4;
Q33.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q33.Pergunta = "Qual a função do fígado no corpo humano?";
Q33.Resposta1 = "Filtrar o sangue"; // Resposta correta
Q33.Resposta2 = "Produzir insulina";
Q33.Resposta3 = "Armazenar energia";
Q33.Resposta4 = "Respirar";
Q33.Resposta5 = "Produzir bile";
Q33.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q33);

// Pergunta 34
var Q34 = new Questao();
Q34.Nivel = 4;
Q34.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q34.Pergunta = "Quem propôs a teoria do Big Bang?";
Q34.Resposta1 = "Stephen Hawking";
Q34.Resposta2 = "Albert Einstein";
Q34.Resposta3 = "Georges Lemaître"; // Resposta correta
Q34.Resposta4 = "Niels Bohr";
Q34.Resposta5 = "Isaac Newton";
Q34.RespostaCerta = 3;
ListaTodasQuestoes.Add(Q34);

// Pergunta 35
var Q35 = new Questao();
Q35.Nivel = 4;
Q35.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q35.Pergunta = "Qual é a capital da Austrália?";
Q35.Resposta1 = "Sydney";
Q35.Resposta2 = "Canberra"; // Resposta correta
Q35.Resposta3 = "Melbourne";
Q35.Resposta4 = "Brisbane";
Q35.Resposta5 = "Perth";
Q35.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q35);

// Pergunta 36
var Q36 = new Questao();
Q36.Nivel = 4;
Q36.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q36.Pergunta = "Qual é a velocidade da luz no vácuo?";
Q36.Resposta1 = "300.000 km/s"; // Resposta correta
Q36.Resposta2 = "150.000 km/s";
Q36.Resposta3 = "500.000 km/s";
Q36.Resposta4 = "1.000.000 km/s";
Q36.Resposta5 = "250.000 km/s";
Q36.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q36);

// Pergunta 37
var Q37 = new Questao();
Q37.Nivel = 4;
Q37.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q37.Pergunta = "Qual é o principal neurotransmissor responsável pela sensação de prazer?";
Q37.Resposta1 = "Serotonina";
Q37.Resposta2 = "Dopamina"; // Resposta correta
Q37.Resposta3 = "Noradrenalina";
Q37.Resposta4 = "Acetilcolina";
Q37.Resposta5 = "Glutamato";
Q37.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q37);

// Pergunta 38
var Q38 = new Questao();
Q38.Nivel = 4;
Q38.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q38.Pergunta = "Qual é o planeta mais próximo do Sol?";
Q38.Resposta1 = "Vênus";
Q38.Resposta2 = "Terra";
Q38.Resposta3 = "Mercúrio"; // Resposta correta
Q38.Resposta4 = "Marte";
Q38.Resposta5 = "Júpiter";
Q38.RespostaCerta = 3;
ListaTodasQuestoes.Add(Q38);

// Pergunta 39
var Q39 = new Questao();
Q39.Nivel = 4;
Q39.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q39.Pergunta = "Qual é a principal fonte de energia da Terra?";
Q39.Resposta1 = "Energia Geotérmica";
Q39.Resposta2 = "Energia Solar"; // Resposta correta
Q39.Resposta3 = "Energia Eólica";
Q39.Resposta4 = "Energia Hidráulica";
Q39.Resposta5 = "Energia Nuclear";
Q39.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q39);


// Pergunta 40
var Q40 = new Questao();
Q40.Nivel = 5;
Q40.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q40.Pergunta = "Qual é a principal característica da biologia celular?";
Q40.Resposta1 = "Estudo da química dos seres vivos";
Q40.Resposta2 = "Estudo das interações entre organismos";
Q40.Resposta3 = "Estudo das células"; // Resposta correta
Q40.Resposta4 = "Estudo do comportamento animal";
Q40.Resposta5 = "Estudo dos ecossistemas";
Q40.RespostaCerta = 3;
ListaTodasQuestoes.Add(Q40);

// Pergunta 41
var Q41 = new Questao();
Q41.Nivel = 5;
Q41.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q41.Pergunta = "Qual é o nome do processo de transformação de uma larva em inseto adulto?";
Q41.Resposta1 = "Metamorfose"; // Resposta correta
Q41.Resposta2 = "Crescimento";
Q41.Resposta3 = "Reprodução";
Q41.Resposta4 = "Desenvolvimento";
Q41.Resposta5 = "Evolução";
Q41.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q41);

// Pergunta 42
var Q42 = new Questao();
Q42.Nivel = 5;
Q42.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q42.Pergunta = "Qual é o principal elemento da tabela periódica usado na construção de estruturas metálicas?";
Q42.Resposta1 = "Cobre";
Q42.Resposta2 = "Ferro"; // Resposta correta
Q42.Resposta3 = "Alumínio";
Q42.Resposta4 = "Ouro";
Q42.Resposta5 = "Prata";
Q42.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q42);

// Pergunta 43
var Q43 = new Questao();
Q43.Nivel = 5;
Q43.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q43.Pergunta = "Quem é conhecido como o 'pai da psicanálise'?";
Q43.Resposta1 = "Carl Jung";
Q43.Resposta2 = "Sigmund Freud"; // Resposta correta
Q43.Resposta3 = "Jean Piaget";
Q43.Resposta4 = "B.F. Skinner";
Q43.Resposta5 = "Wilhelm Wundt";
Q43.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q43);

// Pergunta 44
var Q44 = new Questao();
Q44.Nivel = 5;
Q44.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q44.Pergunta = "Qual é a principal causa do aquecimento global?";
Q44.Resposta1 = "Desmatamento";
Q44.Resposta2 = "Poluição do ar"; // Resposta correta
Q44.Resposta3 = "Excesso de água";
Q44.Resposta4 = "Desertificação";
Q44.Resposta5 = "Acidificação dos oceanos";
Q44.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q44);

// Pergunta 45
var Q45 = new Questao();
Q45.Nivel = 5;
Q45.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q45.Pergunta = "Qual é o nome da maior floresta tropical do mundo?";
Q45.Resposta1 = "Floresta Amazônica"; // Resposta correta
Q45.Resposta2 = "Floresta do Congo";
Q45.Resposta3 = "Floresta Boreal";
Q45.Resposta4 = "Floresta de Taiga";
Q45.Resposta5 = "Floresta de Savanah";
Q45.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q45);

// Pergunta 46
var Q46 = new Questao();
Q46.Nivel = 5;
Q46.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q46.Pergunta = "Qual é o nome da camada da atmosfera onde ocorrem os fenômenos meteorológicos?";
Q46.Resposta1 = "Estratosfera";
Q46.Resposta2 = "Troposfera"; // Resposta correta
Q46.Resposta3 = "Mesosfera";
Q46.Resposta4 = "Termosfera";
Q46.Resposta5 = "Exosfera";
Q46.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q46);

// Pergunta 47
var Q47 = new Questao();
Q47.Nivel = 5;
Q47.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q47.Pergunta = "Qual é a principal linguagem de programação para desenvolvimento web?";
Q47.Resposta1 = "Java";
Q47.Resposta2 = "C#";
Q47.Resposta3 = "Python";
Q47.Resposta4 = "JavaScript"; // Resposta correta
Q47.Resposta5 = "Ruby";
Q47.RespostaCerta = 4;
ListaTodasQuestoes.Add(Q47);

// Pergunta 48
var Q48 = new Questao();
Q48.Nivel = 5;
Q48.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q48.Pergunta = "Qual é o nome do maior órgão do corpo humano?";
Q48.Resposta1 = "Coração";
Q48.Resposta2 = "Fígado";
Q48.Resposta3 = "Pele"; // Resposta correta
Q48.Resposta4 = "Cérebro";
Q48.Resposta5 = "Pulmão";
Q48.RespostaCerta = 3;
ListaTodasQuestoes.Add(Q48);

// Pergunta 49
var Q49 = new Questao();
Q49.Nivel = 6;
Q49.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q49.Pergunta = "Qual é a unidade de medida da pressão no Sistema Internacional?";
Q49.Resposta1 = "Pascal"; // Resposta correta
Q49.Resposta2 = "Bar";
Q49.Resposta3 = "Joule";
Q49.Resposta4 = "Newton";
Q49.Resposta5 = "Watt";
Q49.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q49);

// Pergunta 50
var Q50 = new Questao();
Q50.Nivel = 6;
Q50.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q50.Pergunta = "Qual é o nome da teoria que descreve a origem do universo a partir de uma explosão?";
Q50.Resposta1 = "Teoria do Big Bang"; // Resposta correta
Q50.Resposta2 = "Teoria da Relatividade";
Q50.Resposta3 = "Teoria das Cordas";
Q50.Resposta4 = "Teoria do Multiverso";
Q50.Resposta5 = "Teoria da Evolução";
Q50.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q50);

// Pergunta 51
var Q51 = new Questao();
Q51.Nivel = 6;
Q51.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q51.Pergunta = "Quem é conhecido como o pai da genética moderna?";
Q51.Resposta1 = "Charles Darwin";
Q51.Resposta2 = "Gregor Mendel"; // Resposta correta
Q51.Resposta3 = "Louis Pasteur";
Q51.Resposta4 = "James Watson";
Q51.Resposta5 = "Francis Crick";
Q51.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q51);

// Pergunta 52
var Q52 = new Questao();
Q52.Nivel = 6;
Q52.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q52.Pergunta = "Qual é o nome da estrutura que controla as atividades da célula?";
Q52.Resposta1 = "Membrana celular";
Q52.Resposta2 = "Mitocôndria";
Q52.Resposta3 = "Núcleo"; // Resposta correta
Q52.Resposta4 = "Ribossomo";
Q52.Resposta5 = "Lisossomo";
Q52.RespostaCerta = 3;
ListaTodasQuestoes.Add(Q52);

// Pergunta 53
var Q53 = new Questao();
Q53.Nivel = 6;
Q53.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q53.Pergunta = "Qual é o principal componente da atmosfera terrestre?";
Q53.Resposta1 = "Oxigênio";
Q53.Resposta2 = "Nitrogênio"; // Resposta correta
Q53.Resposta3 = "Dióxido de carbono";
Q53.Resposta4 = "Argônio";
Q53.Resposta5 = "Hélio";
Q53.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q53);

// Pergunta 54
var Q54 = new Questao();
Q54.Nivel = 6;
Q54.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q54.Pergunta = "Qual é a função das ribossomos?";
Q54.Resposta1 = "Produzir energia";
Q54.Resposta2 = "Síntese de proteínas"; // Resposta correta
Q54.Resposta3 = "Produzir lipídios";
Q54.Resposta4 = "Armazenar DNA";
Q54.Resposta5 = "Proteger a célula";
Q54.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q54);

// Pergunta 55
var Q55 = new Questao();
Q55.Nivel = 6;
Q55.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q55.Pergunta = "Qual é a unidade de medida da temperatura no Sistema Internacional?";
Q55.Resposta1 = "Celsius";
Q55.Resposta2 = "Fahrenheit";
Q55.Resposta3 = "Kelvin"; // Resposta correta
Q55.Resposta4 = "Rankine";
Q55.Resposta5 = "Reaumur";
Q55.RespostaCerta = 3;
ListaTodasQuestoes.Add(Q55);

// Pergunta 56
var Q56 = new Questao();
Q56.Nivel = 6;
Q56.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q56.Pergunta = "Qual é o nome do sistema que conecta os neurônios?";
Q56.Resposta1 = "Sistema nervoso";
Q56.Resposta2 = "Sistema linfático";
Q56.Resposta3 = "Sistema circulatório"; // Resposta correta
Q56.Resposta4 = "Sistema respiratório";
Q56.Resposta5 = "Sistema digestivo";
Q56.RespostaCerta = 3;
ListaTodasQuestoes.Add(Q56);

// Pergunta 57
var Q57 = new Questao();
Q57.Nivel = 6;
Q57.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q57.Pergunta = "Quem escreveu a obra 'O Capital'?";
Q57.Resposta1 = "Karl Marx"; // Resposta correta
Q57.Resposta2 = "Friedrich Engels";
Q57.Resposta3 = "Adam Smith";
Q57.Resposta4 = "John Maynard Keynes";
Q57.Resposta5 = "David Ricardo";
Q57.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q57);

// Pergunta 58
var Q58 = new Questao();
Q58.Nivel = 7;
Q58.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q58.Pergunta = "Qual é o nome da teoria que explica a natureza quântica da luz?";
Q58.Resposta1 = "Teoria da Relatividade";
Q58.Resposta2 = "Teoria Quântica"; // Resposta correta
Q58.Resposta3 = "Teoria da Gravidade";
Q58.Resposta4 = "Teoria do Big Bang";
Q58.Resposta5 = "Teoria da Evolução";
Q58.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q58);

// Pergunta 59
var Q59 = new Questao();
Q59.Nivel = 7;
Q59.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q59.Pergunta = "Qual a função do aparelho respiratório?";
Q59.Resposta1 = "Transportar oxigênio"; // Resposta correta
Q59.Resposta2 = "Produzir hormônios";
Q59.Resposta3 = "Filtrar impurezas";
Q59.Resposta4 = "Regular a temperatura";
Q59.Resposta5 = "Armazenar nutrientes";
Q59.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q59);

// Pergunta 60
var Q60 = new Questao();
Q60.Nivel = 7;
Q60.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q60.Pergunta = "Qual é a estrutura responsável pela troca gasosa nos pulmões?";
Q60.Resposta1 = "Brônquios";
Q60.Resposta2 = "Alvéolos"; // Resposta correta
Q60.Resposta3 = "Traquéia";
Q60.Resposta4 = "Pulmões";
Q60.Resposta5 = "Diafragma";
Q60.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q60);

// Pergunta 61
var Q61 = new Questao();
Q61.Nivel = 7;
Q61.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q61.Pergunta = "Qual é a unidade de medida da carga elétrica?";
Q61.Resposta1 = "Volt";
Q61.Resposta2 = "Ampere"; // Resposta correta
Q61.Resposta3 = "Coulomb";
Q61.Resposta4 = "Ohm";
Q61.Resposta5 = "Farad";
Q61.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q61);

// Pergunta 62
var Q62 = new Questao();
Q62.Nivel = 7;
Q62.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q62.Pergunta = "Qual é o nome do processo pelo qual as plantas produzem energia?";
Q62.Resposta1 = "Respiração";
Q62.Resposta2 = "Fermentação";
Q62.Resposta3 = "Fotossíntese"; // Resposta correta
Q62.Resposta4 = "Quimiossíntese";
Q62.Resposta5 = "Decomposição";
Q62.RespostaCerta = 3;
ListaTodasQuestoes.Add(Q62);

// Pergunta 63
var Q63 = new Questao();
Q63.Nivel = 7;
Q63.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q63.Pergunta = "Quem foi o primeiro homem a viajar ao espaço?";
Q63.Resposta1 = "Yuri Gagarin"; // Resposta correta
Q63.Resposta2 = "Neil Armstrong";
Q63.Resposta3 = "Buzz Aldrin";
Q63.Resposta4 = "John Glenn";
Q63.Resposta5 = "Gus Grissom";
Q63.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q63);

// Pergunta 64
var Q64 = new Questao();
Q64.Nivel = 7;
Q64.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q64.Pergunta = "Qual é o maior animal do planeta?";
Q64.Resposta1 = "Elefante";
Q64.Resposta2 = "Baleia Azul"; // Resposta correta
Q64.Resposta3 = "Tubarão Branco";
Q64.Resposta4 = "Girafa";
Q64.Resposta5 = "Ostra";
Q64.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q64);

// Pergunta 65
var Q65 = new Questao();
Q65.Nivel = 7;
Q65.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q65.Pergunta = "Qual é a capital da Rússia?";
Q65.Resposta1 = "Moscovo"; // Resposta correta
Q65.Resposta2 = "São Petersburgo";
Q65.Resposta3 = "Kiev";
Q65.Resposta4 = "Minsk";
Q65.Resposta5 = "Astana";
Q65.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q65);

// Pergunta 66
var Q66 = new Questao();
Q66.Nivel = 8;
Q66.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q66.Pergunta = "Qual é o principal gás responsável pelo efeito estufa?";
Q66.Resposta1 = "Dióxido de carbono"; // Resposta correta
Q66.Resposta2 = "Metano";
Q66.Resposta3 = "Oxigênio";
Q66.Resposta4 = "Nitrogênio";
Q66.Resposta5 = "Hélio";
Q66.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q66);

// Pergunta 67
var Q67 = new Questao();
Q67.Nivel = 8;
Q67.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q67.Pergunta = "Qual é o nome da teoria que afirma que a Terra é o centro do universo?";
Q67.Resposta1 = "Teoria Geocêntrica"; // Resposta correta
Q67.Resposta2 = "Teoria Heliocêntrica";
Q67.Resposta3 = "Teoria da Relatividade";
Q67.Resposta4 = "Teoria Quântica";
Q67.Resposta5 = "Teoria da Gravidade";
Q67.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q67);

// Pergunta 68
var Q68 = new Questao();
Q68.Nivel = 8;
Q68.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q68.Pergunta = "Qual é a fórmula química da água?";
Q68.Resposta1 = "H2O"; // Resposta correta
Q68.Resposta2 = "CO2";
Q68.Resposta3 = "NaCl";
Q68.Resposta4 = "O2";
Q68.Resposta5 = "C6H12O6";
Q68.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q68);

// Pergunta 69
var Q69 = new Questao();
Q69.Nivel = 8;
Q69.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q69.Pergunta = "Qual é a maior floresta tropical do mundo?";
Q69.Resposta1 = "Floresta Amazônica"; // Resposta correta
Q69.Resposta2 = "Floresta do Congo";
Q69.Resposta3 = "Floresta Boreal";
Q69.Resposta4 = "Floresta de Taiga";
Q69.Resposta5 = "Floresta de Savanah";
Q69.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q69);

// Pergunta 70
var Q70 = new Questao();
Q70.Nivel = 8;
Q70.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q70.Pergunta = "Qual é o elemento químico com o símbolo Au?";
Q70.Resposta1 = "Prata";
Q70.Resposta2 = "Ouro"; // Resposta correta
Q70.Resposta3 = "Cobre";
Q70.Resposta4 = "Ferro";
Q70.Resposta5 = "Mercúrio";
Q70.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q70);

// Pergunta 72
var Q72 = new Questao();
Q72.Nivel = 8;
Q72.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q72.Pergunta = "Qual é o maior planeta do Sistema Solar?";
Q72.Resposta1 = "Terra";
Q72.Resposta2 = "Júpiter"; // Resposta correta
Q72.Resposta3 = "Saturno";
Q72.Resposta4 = "Marte";
Q72.Resposta5 = "Netuno";
Q72.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q72);

// Pergunta 73
var Q73 = new Questao();
Q73.Nivel = 8;
Q73.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q73.Pergunta = "Qual é a capital da França?";
Q73.Resposta1 = "Berlim";
Q73.Resposta2 = "Madrid";
Q73.Resposta3 = "Paris"; // Resposta correta
Q73.Resposta4 = "Lisboa";
Q73.Resposta5 = "Roma";
Q73.RespostaCerta = 3;
ListaTodasQuestoes.Add(Q73);

// Pergunta 74
var Q74 = new Questao();
Q74.Nivel = 8;
Q74.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q74.Pergunta = "Qual é a moeda oficial do Japão?";
Q74.Resposta1 = "Yuan";
Q74.Resposta2 = "Won";
Q74.Resposta3 = "Dólar";
Q74.Resposta4 = "Iene"; // Resposta correta
Q74.Resposta5 = "Rúpia";
Q74.RespostaCerta = 4;
ListaTodasQuestoes.Add(Q74);

// Pergunta 75
var Q75 = new Questao();
Q75.Nivel = 8;
Q75.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q75.Pergunta = "Qual é o gás mais abundante na atmosfera terrestre?";
Q75.Resposta1 = "Oxigênio";
Q75.Resposta2 = "Dióxido de carbono";
Q75.Resposta3 = "Hélio";
Q75.Resposta4 = "Nitrogênio"; // Resposta correta
Q75.Resposta5 = "Argônio";
Q75.RespostaCerta = 4;
ListaTodasQuestoes.Add(Q75);

// Pergunta 76
var Q76 = new Questao();
Q76.Nivel = 8;
Q76.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q76.Pergunta = "Qual é o elemento químico com o símbolo Fe?";
Q76.Resposta1 = "Ferro"; // Resposta correta
Q76.Resposta2 = "Fluor";
Q76.Resposta3 = "Fósforo";
Q76.Resposta4 = "Cálcio";
Q76.Resposta5 = "Mercúrio";
Q76.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q76);

// Pergunta 77
var Q77 = new Questao();
Q77.Nivel = 8;
Q77.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q77.Pergunta = "Qual é o nome do continente onde se encontra o Egito?";
Q77.Resposta1 = "África"; // Resposta correta
Q77.Resposta2 = "Ásia";
Q77.Resposta3 = "Europa";
Q77.Resposta4 = "América";
Q77.Resposta5 = "Oceania";
Q77.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q77);

// Pergunta 78
var Q78 = new Questao();
Q78.Nivel = 8;
Q78.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q78.Pergunta = "Qual é o rio mais longo do mundo?";
Q78.Resposta1 = "Rio Nilo"; // Resposta correta
Q78.Resposta2 = "Rio Amazonas";
Q78.Resposta3 = "Rio Yangtze";
Q78.Resposta4 = "Rio Mississippi";
Q78.Resposta5 = "Rio Ganges";
Q78.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q78);

// Pergunta 79
var Q79 = new Questao();
Q79.Nivel = 8;
Q79.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q79.Pergunta = "Qual é a capital do Brasil?";
Q79.Resposta1 = "Rio de Janeiro";
Q79.Resposta2 = "São Paulo";
Q79.Resposta3 = "Brasília"; // Resposta correta
Q79.Resposta4 = "Belo Horizonte";
Q79.Resposta5 = "Salvador";
Q79.RespostaCerta = 3;
ListaTodasQuestoes.Add(Q79);

// Pergunta 80
var Q80 = new Questao();
Q80.Nivel = 8;
Q80.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q80.Pergunta = "Qual é a fórmula da glicose?";
Q80.Resposta1 = "C6H12O6"; // Resposta correta
Q80.Resposta2 = "H2O";
Q80.Resposta3 = "CO2";
Q80.Resposta4 = "NaCl";
Q80.Resposta5 = "O2";
Q80.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q80);

// Pergunta 81
var Q81 = new Questao();
Q81.Nivel = 9;
Q81.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q81.Pergunta = "Qual é o nome da primeira mulher a ganhar um Prêmio Nobel?";
Q81.Resposta1 = "Marie Curie"; // Resposta correta
Q81.Resposta2 = "Rosalind Franklin";
Q81.Resposta3 = "Jane Goodall";
Q81.Resposta4 = "Ada Lovelace";
Q81.Resposta5 = "Lise Meitner";
Q81.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q81);

// Pergunta 82
var Q82 = new Questao();
Q82.Nivel = 9;
Q82.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q82.Pergunta = "Qual é a teoria que explica a evolução das espécies?";
Q82.Resposta1 = "Teoria da Evolução"; // Resposta correta
Q82.Resposta2 = "Teoria da Relatividade";
Q82.Resposta3 = "Teoria da Criacionismo";
Q82.Resposta4 = "Teoria do Big Bang";
Q82.Resposta5 = "Teoria das Cordas";
Q82.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q82);

// Pergunta 83
var Q83 = new Questao();
Q83.Nivel = 9;
Q83.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q83.Pergunta = "Qual é o maior deserto do mundo?";
Q83.Resposta1 = "Deserto do Saara";
Q83.Resposta2 = "Deserto da Antártica"; // Resposta correta
Q83.Resposta3 = "Deserto de Gobi";
Q83.Resposta4 = "Deserto de Kalahari";
Q83.Resposta5 = "Deserto de Atacama";
Q83.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q83);

// Pergunta 84
var Q84 = new Questao();
Q84.Nivel = 9;
Q84.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q84.Pergunta = "Qual é o maior órgão do corpo humano?";
Q84.Resposta1 = "Coração";
Q84.Resposta2 = "Fígado";
Q84.Resposta3 = "Pele"; // Resposta correta
Q84.Resposta4 = "Cérebro";
Q84.Resposta5 = "Pulmão";
Q84.RespostaCerta = 3;
ListaTodasQuestoes.Add(Q84);

// Pergunta 85
var Q85 = new Questao();
Q85.Nivel = 9;
Q85.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q85.Pergunta = "Qual é a fórmula da água?";
Q85.Resposta1 = "H2O"; // Resposta correta
Q85.Resposta2 = "CO2";
Q85.Resposta3 = "O2";

var Q86 = new Questao();
Q86.Nivel = 9;
Q86.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q86.Pergunta = "Quem pintou a Mona Lisa?";
Q86.Resposta1 = "Vincent van Gogh";
Q86.Resposta2 = "Pablo Picasso";
Q86.Resposta3 = "Leonardo da Vinci"; // Resposta correta
Q86.Resposta4 = "Michelangelo";
Q86.Resposta5 = "Claude Monet";
Q86.RespostaCerta = 3;
ListaTodasQuestoes.Add(Q86);

// Pergunta 87
var Q87 = new Questao();
Q87.Nivel = 9;
Q87.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q87.Pergunta = "Qual é a capital da Austrália?";
Q87.Resposta1 = "Sydney";
Q87.Resposta2 = "Canberra"; // Resposta correta
Q87.Resposta3 = "Melbourne";
Q87.Resposta4 = "Brisbane";
Q87.Resposta5 = "Perth";
Q87.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q87);

// Pergunta 88
var Q88 = new Questao();
Q88.Nivel = 9;
Q88.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q88.Pergunta = "Qual é a maior cadeia de montanhas do mundo?";
Q88.Resposta1 = "Cordilheira dos Andes"; // Resposta correta
Q88.Resposta2 = "Himalaias";
Q88.Resposta3 = "Alpes";
Q88.Resposta4 = "Montanhas Rochosas";
Q88.Resposta5 = "Apalaches";
Q88.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q88);

// Pergunta 89
var Q89 = new Questao();
Q89.Nivel = 9;
Q89.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q89.Pergunta = "Quem foi o autor de 'Dom Casmurro'?";
Q89.Resposta1 = "Jorge Amado";
Q89.Resposta2 = "Machado de Assis"; // Resposta correta
Q89.Resposta3 = "Guimarães Rosa";
Q89.Resposta4 = "Clarice Lispector";
Q89.Resposta5 = "Carlos Drummond de Andrade";
Q89.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q89);

// Pergunta 90
var Q90 = new Questao();
Q90.Nivel = 9;
Q90.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q90.Pergunta = "Qual é a camada mais externa da Terra?";
Q90.Resposta1 = "Manto";
Q90.Resposta2 = "Núcleo";
Q90.Resposta3 = "Crosta"; // Resposta correta
Q90.Resposta4 = "Sial";
Q90.Resposta5 = "Sima";
Q90.RespostaCerta = 3;
ListaTodasQuestoes.Add(Q90);


// Pergunta 91
var Q91 = new Questao();
Q91.Nivel = 10;
Q91.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q91.Pergunta = "Qual é a velocidade da luz?";
Q91.Resposta1 = "300.000 km/s"; // Resposta correta
Q91.Resposta2 = "150.000 km/s";
Q91.Resposta3 = "1.000 km/s";
Q91.Resposta4 = "500.000 km/s";
Q91.Resposta5 = "200.000 km/s";
Q91.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q91);

// Pergunta 92
var Q92 = new Questao();
Q92.Nivel = 10;
Q92.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q92.Pergunta = "Qual é a equação famosa de Einstein sobre a energia?";
Q92.Resposta1 = "E=mc²"; // Resposta correta
Q92.Resposta2 = "F=ma";
Q92.Resposta3 = "PV=nRT";
Q92.Resposta4 = "a² + b² = c²";
Q92.Resposta5 = "E=hf";
Q92.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q92);

// Pergunta 93
var Q93 = new Questao();
Q93.Nivel = 10;
Q93.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q93.Pergunta = "Qual é a partícula subatômica com carga negativa?";
Q93.Resposta1 = "Próton";
Q93.Resposta2 = "Nêutron";
Q93.Resposta3 = "Elétron"; // Resposta correta
Q93.Resposta4 = "Méson";
Q93.Resposta5 = "Bóson";
Q93.RespostaCerta = 3;
ListaTodasQuestoes.Add(Q93);

// Pergunta 94
var Q94 = new Questao();
Q94.Nivel = 10;
Q94.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q94.Pergunta = "Qual é a teoria que descreve a origem do universo?";
Q94.Resposta1 = "Teoria do Big Bang"; // Resposta correta
Q94.Resposta2 = "Teoria da Evolução";
Q94.Resposta3 = "Teoria da Relatividade";
Q94.Resposta4 = "Teoria da Gravitação";
Q94.Resposta5 = "Teoria das Cordas";
Q94.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q94);

// Pergunta 95
var Q95 = new Questao();
Q95.Nivel = 10;
Q95.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q95.Pergunta = "Qual é a estrutura responsável pelo controle das funções do corpo?";
Q95.Resposta1 = "Cérebro"; // Resposta correta
Q95.Resposta2 = "Coração";
Q95.Resposta3 = "Fígado";
Q95.Resposta4 = "Pulmão";
Q95.Resposta5 = "Rins";
Q95.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q95);

// Pergunta 96
var Q96 = new Questao();
Q96.Nivel = 10;
Q96.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q96.Pergunta = "Qual é o conceito de entropia na termodinâmica?";
Q96.Resposta1 = "Medida da desordem"; // Resposta correta
Q96.Resposta2 = "Energia potencial";
Q96.Resposta3 = "Pressão atmosférica";
Q96.Resposta4 = "Temperatura";
Q96.Resposta5 = "Força";
Q96.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q96);

// Pergunta 97
var Q97 = new Questao();
Q97.Nivel = 10;
Q97.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q97.Pergunta = "Qual é a maior estrutura viva do planeta?";
Q97.Resposta1 = "Coração de uma baleia";
Q97.Resposta2 = "A Grande Barreira de Coral"; // Resposta correta
Q97.Resposta3 = "A Floresta Amazônica";
Q97.Resposta4 = "O Corpo Humano";
Q97.Resposta5 = "Uma Sequóia";
Q97.RespostaCerta = 2;
ListaTodasQuestoes.Add(Q97);

// Pergunta 98
var Q98 = new Questao();
Q98.Nivel = 10;
Q98.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q98.Pergunta = "Qual é a fórmula da velocidade média?";
Q98.Resposta1 = "Distância/Tempo"; // Resposta correta
Q98.Resposta2 = "Tempo/Distância";
Q98.Resposta3 = "Distância*Tempo";
Q98.Resposta4 = "Distância + Tempo";
Q98.Resposta5 = "Tempo - Distância";
Q98.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q98);

var Q100 = new Questao();
Q100.Nivel = 10;
Q100.Estruturadedesenho(LabelPerg, btnResp01, btnResp02, btnResp03, btnResp04, btnResp05);
Q100.Pergunta = "Qual é o elemento químico mais abundante no universo?";
Q100.Resposta1 = "Hidrogênio"; // Resposta correta
Q100.Resposta2 = "Hélio";
Q100.Resposta3 = "Oxigênio";
Q100.Resposta4 = "Carbono";
Q100.Resposta5 = "Nitrogênio";
Q100.RespostaCerta = 1;
ListaTodasQuestoes.Add(Q100);


    ProximaQuestao();
  }

 
}


