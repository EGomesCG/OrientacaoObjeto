using System;

namespace OrientacaoObjeto
{
    //Classe criadas - Conta Poupança
    //A classe pode se herdeira apenas de uma super classe, mas, pode herdar diversas interfaces
    //Então, a forma de declara:
    //1º public ou private
    //2º Declara que é uma classe
    //3º Dois pontos indicando que é herdeira de uma super classe
    //4º Declara a super classe, e por fim
    //5º Virgula e a Interface - é como um contrato
    public class ContaPoupanca : Conta, ITributo
    {
        //O construtor da contaPoupança está herdando do construtor de Conta
        public ContaPoupanca():base(500) { }
        
        //O método Depositar foi criado como abstract na super classe
        //e aqui é implementado. Saldo base é uma propriedade da super classe
        public override void Depositar(decimal valor)
        {
            base.Saldo += valor;
        }
        //Tudo que existe na interface tem que se implementado na classe
        public decimal CalcularTributo()
        {
            return base.Saldo * 0.02m;
        }

    }
}
