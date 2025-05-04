
        Console.Write("Digite o valor solicitado do empréstimo: R$ ");
        double valorSolicitado = double.Parse(Console.ReadLine()!);

        Console.Write("Digite a quantidade de parcelas desejada: ");
        int quantidadeParcelas = int.Parse(Console.ReadLine()!);

        Console.Write("Digite a renda mensal comprovada: R$ ");
        double rendaMensal = double.Parse(Console.ReadLine()!);
     
        double valorParcela = valorSolicitado / quantidadeParcelas;

        double limiteParcela = rendaMensal * 0.30; 

       
        if (valorParcela <= limiteParcela)
        {
            Console.WriteLine("Empréstimo aprovado!");
            Console.WriteLine($"Valor da parcela: R$ {valorParcela:F2}"); 
        }
        else
        {
            Console.WriteLine("Empréstimo negado.");
            Console.WriteLine($"Valor das parcelas: R$ {valorParcela:F2}");
            Console.WriteLine($"Limite máximo da parcela (30% da renda): R$ {limiteParcela:F2}");
        }
    

