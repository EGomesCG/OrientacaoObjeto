using OrientacaoObjeto;
using static System.Console;

namespace POO
{
    //Uma linguagem orientada a objeto tem que permitir os 4 pilares(estruturas):
    //Abstração - 
    //Encapsulamento - Restringir o nível de acesso ao atributo da classe - Ok
    //Herança - A classe filho herdado todas as caracteristicas da classe Pai, 
        //também herdar o construtor das duas classes(cc ^ cp) como da super classe
        //e herdar método implementando diferentes através do virtual e override 
    //Polimorfismo - quando realizamos um método/funcionalidade de várias classes diferentes,
        //porém, todas são filhas do mesmo pai

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("POO - Orientação a Objeto");
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
