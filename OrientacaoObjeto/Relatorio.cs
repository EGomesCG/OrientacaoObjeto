using System;

namespace OrientacaoObjeto
{
    public class Relatorio
    {
        //prop e 2tab: o vs completa => public int MyProperty { get; set; }
        public decimal SaldoGeral { get; private set; }

        //Em relatório temos SaldoGeral também teremos criar a propriedade
        //TributoGeral que será atualizada todas as vezes que uma classe for atualizada
        //e que possua a interface Tributo
        public decimal TributoGeral { get; private set; }

        //Para realizar a soma dos tributos no relatório,
        //Iremos criar o método SomarTributo,
        //nele não podemos receber qualquer tipo de dados, mas,
        //Toda conta que possuir ITributo
        public void SomarTributos(ITributo conta) 
        {
            //Então, a propriedade TributoGeral vai receber qualquer conta que contenha
            //a interface ITributo e invocar o método CalcularTributo, assim, teremos 
            //o calculo total do tributo.
            this.TributoGeral += conta.CalcularTributo();
        }

        //Este método pode se usado em todas as classes herdeiras de Conta
        //Fazendo assim a manutenção é mais ágil.
        public void Somar(Conta conta)
        {
            this.SaldoGeral += conta.Saldo;
        }

        //O metodo Somar valor existe duas vezes, porém,
        //um recebe apenas 1 parametro e o outro recebe 2 parametros
        public void SomarValor(decimal valor1) 
        {
            this.SaldoGeral += valor1;
        }
        public void SomarValor(decimal valor1, decimal valor2)
        {
            this.SaldoGeral += (valor1 + valor2);
        }
    }
}
