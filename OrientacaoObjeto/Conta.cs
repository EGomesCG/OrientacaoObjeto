using System;

namespace OrientacaoObjeto
{
    //Tornamos uma classe abstract para o sistema não ficar pedido em relação
    //as informações, as classes pai ou super classe são fortes candidatas para tal.
    //No entanto, quando uma classe é abstract as classe filhas terá o mesmo acesso e direitos que antes
    public abstract class Conta
    {
        private int numConta;
        private decimal saldo;
        private int agencia;
        //Encapsulando a classe - Restringir o nível de acesso ao atributo da classe
        public int Agencia
        {
            get { return agencia; }
            private set
            {
                //Podemos realizar validação no set, poderem, a propriedade não pode se privada e
                //se existir um metodo o tratamento tem que ser no metodo 
                if (value > 0)
                {
                    agencia = value;
                }
            }
        }

        decimal limite;
        public int NumConta { get => numConta; private set => numConta = value; }
        //Protected posso usar este método tanto na classe pai quanto nas classes filhas
        public decimal Saldo { get => saldo; protected set => saldo = value; }
        public decimal Limite { get => limite; private set => limite = value; }

        //Definição do construtor da classe base
        public Conta() 
        {
            agencia = 0257;
            numConta = 28500-1;
            this.limite = 3000;
        }

        public Conta(decimal limite)
        {
            agencia = 0236;
            numConta = 80475 - 1;
            this.limite = limite;
        }


        //Para realizar alterações em uma propriedade privada
        //É comum utilizar o metodo, para isto.
        public void SetAgencia(int agencia)
        {
            //this.agencia indica que se trata da variavel agencia da classe e não o parametro - agencia.
            //Se clicar o mouse em cima da variavel, irá destacar quais estão no mesmo endereço de memória.
            if (agencia > 0)
            {
                this.agencia = agencia;
            }

        }

        //Métodos
        //Para garantir que toda as classes herdeiras tenha acesso ao método sacar
        //Colocamos o termo virtual na sua definição
        public virtual void Sacar(decimal valor)
        {
            saldo -= valor;
        }

        //Abstract é a idea de uma futura implementação,
        //aqui apenas a declaro e nas classes filhas realizo as implementações
        public abstract void Depositar(decimal valor);
       

    }
}
