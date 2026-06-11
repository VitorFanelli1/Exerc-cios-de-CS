Random random = new Random();

        int numeroSorteado = random.Next(0, 101);
        int tentativa;

        Console.WriteLine("Tente adivinhar o número entre 0 e 100.");

        while (true)
        {
            Console.WriteLine("Digite um número:");
            tentativa = Convert.ToInt32(Console.ReadLine());

            if (tentativa == numeroSorteado)
            {
                Console.WriteLine("Parabéns! Você acertou o número.");
                break;
            }
            else if (tentativa > numeroSorteado)
            {
                Console.WriteLine("O número digitado é menor que o número sorteado.");
            }
            else
            {
                Console.WriteLine("O número digitado é maior que o número sorteado.");
            }
        }