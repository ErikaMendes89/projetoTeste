using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] faturamentoDiario = new int[]
        {   //numeros aletorios para simular o faturamento
            100, 200, 0, 400, 0, 600, 700, 800, 0, 1000, 1100, 1200, 0, 1400, 1500, 1600, 1700, 1800, 0,
            2000, 2100, 2200, 2300, 2400, 0, 2600, 2700, 2800, 2900, 3000, 0, 3200, 3300, 3400, 3500, 3600, 0,
            3800, 3900, 4000, 4100, 4200, 0, 4400, 4500, 4600, 4700, 4800, 0, 5000, 5100, 5200, 5300, 5400, 0,
            5600, 5700, 5800, 5900, 6000, 0, 6200, 6300, 6400, 6500, 6600, 0, 6800, 6900, 7000, 7100, 7200, 0,
            7400, 7500, 7600, 7700, 7800, 0, 8000, 8100, 8200, 8300, 8400, 0, 8600, 8700, 8800, 8900, 9000, 0,
            9200, 9300, 9400, 9500, 9600, 0, 9800, 9900, 10000
        };

        int menorValor = faturamentoDiario.Min();
        int maiorValor = faturamentoDiario.Max();

         // Calcular a média anual, ignorando os dias sem faturamento
        var diasComFaturamento = faturamentoDiario.Where(valor => valor > 0);
        double mediaAnual = diasComFaturamento.Average();

        // Encontrar o número de dias com faturamento acima da média anual
        int diasAcimaMedia = diasComFaturamento.Count(valor => valor > mediaAnual);

        // Exibir os resultados
        Console.WriteLine($"Menor valor de faturamento: {menorValor}");
        Console.WriteLine($"Maior valor de faturamento: {maiorValor}");
        Console.WriteLine($"Número de dias com faturamento acima da média anual: {diasAcimaMedia}");
    }
}

  