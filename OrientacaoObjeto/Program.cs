using OrientacaoObjeto;
using static System.Console;

namespace POO
{
    /// <summary>
    //Uma linguagem orientada a objeto tem que permitir os 4 pilares(estruturas):
    //Abstração -  Um método abstrato é um método que não possui implementação na classe abstrata.
        //Um método abstrato possui somente a definição de sua assinatura.
        //A sua implementação deve ser feita na classe derivada. -
        //Um método abstrato é um método virtual e deve ser implementado usando o modificador override.
    //Encapsulamento - Restringir o nível de acesso ao atributo da classe - Ok
    //Herança - A classe filho herdado todas as caracteristicas da classe Pai, 
        //também herdar o construtor das duas classes(cc ^ cp) como da super classe
        //e herdar método implementando diferentes através do virtual e override 
    //Polimorfismo - o principal conceito é a propriedade de duas ou mais classes derivadas de uma
        //mesma superclasse responderem a mesma mensagem, cada uma de uma forma diferente.
        //quando realizamos um método/funcionalidade de várias classes diferentes,
        //porém, todas são filhas do mesmo pai
    //----------------------------------------------
    //Interface - significa que uma classe que implementa uma interface é obrigada a implementar todo os seus membros,
    //ou seja, funciona como um contrato entre si e qualquer classe ou estrutura que a implementa.
    //-----------------------------------------------
    //Debugging Break
    //Podemos colocar um ponto de para com uma bolinha vermelha na coluna lateral
    //Se essa parada for dentro de um loop, podemos clicar com o botão direito do mouse
    //e add um condicional de parada, assim, evita para todas as vezes que o loop rodar
    //Com o botão direito do mouse, podemos add um "Add Watch", serve para visualizar os dados de uma variavel ou objeto
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("POO - Orientação a Objeto");
            //Utilizamos o try para tratamento de erro ou exceções, ex: Não existe divisão por 0
            try
            {
                int a = 2;
                int b = 0;

                if(b == 0)
                {
                    WriteLine("Meu erro");
                    throw new MinhaExcecao().MensagemErro();
                }

                int c = a/b;
                WriteLine("Sem erro - Soma: " + c);

                int[] vetor = new int[] { 1,2,3 };
                WriteLine("Tratando Vetor: " + vetor[0]);
            }
            //catch (MinhaExcecao ex)
            //{
            //    WriteLine("Erro: " + ex);
            //}
            //Exception é uma classe que faz o tratamento de erro
            //Tratando erros diferente, para cada catch posso tratar erros diferentes
            catch (System.DivideByZeroException)
            {
                //Throw é usado no tratamento do erro
                //throw ex;
                WriteLine("Erro: Divisão por zero");
                //Explorando o objeto ex
                //Não deu erro e apresenta uma mensagem
                //WriteLine("Erro.explorado - Mensagem: " + ex.Message + " Pilha: " + ex.StackTrace);
            }
            catch (System.IndexOutOfRangeException)
            {
                WriteLine("Erro: Indice fora do intervalo");
            }
            catch (Exception ex) //Genérico
            {
                //Throw é usado no tratamento do erro
                //throw ex;
                WriteLine("Erro:" + ex.Message);
                //Explorando o objeto ex
                //Não deu erro e apresenta uma mensagem
               // WriteLine("Erro.explorado - Mensagem: " + ex.Message + " Pilha: " + ex.StackTrace);
            ////Para saber qual classe que está dando erro, podemos fazer o seguinte:
            //WriteLine("Descobrindo as classes de erro: " + ex.GetType());
            }
            //Finally - quando quero que faça algo independente se deu certo ou não
            //Ele tem que ficar no final dos tratamentos de erro.
            //Para isso utilizo o finally, pois se colocar dentro do try e algo dê errado ou se colocar fora do try não será executada.
            finally
            {
                WriteLine("Fim da execução.");
            }
                       

            //Instância da Classe
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();
            Relatorio rel = new Relatorio();

            //Se criar um objeto/instância de uma classe do tipo conta(exemplo),
            //Fica a pergunta: que tipo da conta?
            //Então, para que isto não ocorra a tornamos em uma a classe abstract
            //Conta conta = new Conta();

            //Outro conceito que iremos explorar - método virtuais
            //cp.Saldo = 1000;
            //cc.Saldo = 1000;
            //Com o polimorfismo não posso mais utilizar saldo por aqui, mais, posso depositar

            cp.Depositar(1000);
            cc.Depositar(1000);

            cc.Sacar(100);
            cp.Sacar(100);

            WriteLine("Saldo cc: " + cc.Saldo);
            WriteLine("Saldo cp: " + cp.Saldo);

            //Depois que criado a instância do relatório, posso utiliza-lo
            rel.Somar(cc);//Toda cc tem saldo
            rel.Somar(cp);//Toda cp tem saldo

            //Ainda com Polimorfismo agora de metodo
            //Polimorfismo de método ou Polimorfismo de paramétodos
            rel.SomarValor(10);
            rel.SomarValor(10, 10);


            WriteLine("Saldo geral: " + rel.SaldoGeral);
            //Com a interface de calcular tributos implementada
            cp.CalcularTributo();
            rel.SomarTributos(cp);
            WriteLine("Relatório Tributo: " + rel.TributoGeral);

            //Limite definido na classe pai
            //Acessando as propriedades privadas da Classe
            //Encapsuladas - Valor definido no construtor
            WriteLine("Ag.: " + cc.Agencia);
            WriteLine("Limite: " + cc.Limite);
            WriteLine("Taxa: " + cc.TaxaMovimento);

            //Para alterar o valor de agencia preciso acessar pelo metodo
            cc.SetAgencia(-33);
            WriteLine(cc.Agencia);

            //cp.Saldo = 1000.00m;
            WriteLine("Saldo CP: " + cp.Saldo);
            WriteLine("Limite CP: " +  cp.Limite);

            ReadLine();
        }
        
    }
}
