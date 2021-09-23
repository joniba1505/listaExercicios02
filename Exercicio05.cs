using System;

namespace listaExercicios02
{
    class Exercicio05
    {
        static void Main(string[] args)
        {
            decimal salarioBruto = 0;
decimal impostoDeRenda = 0;
decimal valorInss = 0;
decimal valorFgts = 0;
decimal totalDesconto = 0;
decimal salarioLiquido = 0;
decimal horasTrabalhadas = 0;
decimal valorHora = 0;



            
            try {
                Console.WriteLine("Digite o valor da hora trabalhada:");
                valorHora = Convert.ToDecimal(Console.ReadLine());
                        }
catch (Exception ex) {
    Console.WriteLine("Valor da hora inválido! " + ex.Message);
}

            try {
                Console.WriteLine("Digite a quantidade de horas trabalhadas por mês:");
                horasTrabalhadas = Convert.ToDecimal(Console.ReadLine());
                        }
catch (Exception ex) {
    Console.WriteLine("Quantidade inválida de horas! " + ex.Message);
}

salarioBruto = horasTrabalhadas * valorHora;
valorInss = salarioBruto * 0.1;
valorFgts = salarioBruto * 0.11;

if (salarioBruto <= 2000) {
    impostoDeRenda = 0
}
else if (salarioBruto > 2000 && salarioBruto <= 5000) {
    impostoDeRenda = 5;
}
else if (salarioBruto > 5000 && salarioBruto )        
        
        }
    }
}
