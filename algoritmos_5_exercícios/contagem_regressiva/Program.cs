int numero;

        Console.WriteLine("Digite um número:");
        numero = Convert.ToInt32(Console.ReadLine());

        while (numero >= 0)
        {
            Console.WriteLine(numero);
            numero--;
        }