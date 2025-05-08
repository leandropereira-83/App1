using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("CÁLCULO DO LEC - LOTE ECONÔMICO DE COMPRA");
        Console.WriteLine("-----------------------------------------");

        // Solicita a demanda anual
        Console.Write("Informe a demanda anual (D): ");
        double demandaAnual = double.Parse(Console.ReadLine());

        // Solicita o custo por pedido
        Console.Write("Informe o custo por pedido (S): ");
        double custoPedido = double.Parse(Console.ReadLine());

        // Solicita o custo de armazenagem por unidade por ano
        Console.Write("Informe o custo de armazenagem por unidade por ano (H): ");
        double custoArmazenagem = double.Parse(Console.ReadLine());

        // Calcula o LEC usando a fórmula
        double lec = Math.Sqrt((2 * demandaAnual * custoPedido) / custoArmazenagem);

        // Mostra o resultado
        Console.WriteLine($"\nO Lote Econômico de Compra (LEC) é: {lec:F2} unidades");
    }
}
