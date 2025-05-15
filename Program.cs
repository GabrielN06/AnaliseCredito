
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
            Console.WriteLine("\nEmpréstimo aprovado!");
            Console.WriteLine($"Valor da parcela: {valorParcela:C2}"); 
        }
        else
        {
            Console.WriteLine("\nEmpréstimo negado.");
            Console.WriteLine($"Valor das parcelas: {valorParcela:C2}");
            Console.WriteLine($"Limite máximo da parcela (30% da renda): {limiteParcela:C2}");
        }
    

