using System;

namespace OrientacaoObjeto
{
    //Classe criadas - Conta Corrente
    public class ContaCorrente : Conta //A classe ContaCorrente está herdando
                                       //todos os atributos/propriedades, metodos e comportamentos da classe Conta
    {
        //Propriedades
        //Herança Generalização Especifica - é quando herdo as caracteristicas de uma super classe 
        //E preciso acrescentar uma informação especifica na minha classe.
        decimal taxaMovimento;
        
        //Construtor
        //Como o metodo set é privado, ou seja, só pode se acessado de dentro da classe
        //Iremos precisar de um Construtor
        //Como a classe pai tem 2 construtores temos que passar qual queremos chamar
        public ContaCorrente() : base(2500) 
        {
            //Dentro do construtor posso definir os valores default dos atributos da minha classe
            this.TaxaMovimento = 0.1m;

        }

        //
        public decimal TaxaMovimento 
        { 
            get => taxaMovimento; 
            set => taxaMovimento = value; 
        }

        //Métodos
        //Para herdar o sacar da super classe:
        //1º O sacar pai tem que está virtual
        //2º O sacar filho override,
        //3º Assim podemos implementar a particularidade desta classe no método
        public override void Sacar(decimal valor)
        {
            //Saldo está na classe pai, então, 
            //this.Saldo -= valor + (valor * this.TaxaMovimento);
            //o ideal
            base.Sacar(valor + (valor * this.TaxaMovimento));
        }
        //O método Depositar foi criado como abstract na super classe
        //e aqui é implementado. Saldo base é uma propriedade da super classe
        public override void Depositar(decimal valor)
        {
            base.Saldo += valor;
        }
    }
}
