 int numero;

        Console.WriteLine("Digite um número:");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("Seu número é par.");
        }
        else
        {
            Console.WriteLine("Seu número é ímpar.");
        }