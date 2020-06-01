using System;

namespace Aula07Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartao Card = new Cartao();
            Card.AprovarCompra();

            MasterCard master = new MasterCard();
            master.parcelas = 30;
            master.ComprarComDescontoMasterCard(200);

        }
    }
}
