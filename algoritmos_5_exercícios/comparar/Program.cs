 int numero1;
        int numero2;

        Console.WriteLine("Digite o primeiro número:");
        numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        numero2 = Convert.ToInt32(Console.ReadLine());

        if (numero1 > numero2)
        {
            Console.WriteLine("O maior número é: " + numero1);
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine("O maior número é: " + numero2);
        }
        else
        {
            Console.WriteLine("Os números são iguais.");
        }
