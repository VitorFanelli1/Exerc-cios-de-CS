int produtos = 10;
        int opcao;

        while (true)
        {
            Console.WriteLine("Quantidade de produtos: " + produtos);
            Console.WriteLine("1 - Comprar");
            Console.WriteLine("2 - Vender");

            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    produtos = produtos + 1;
                    Console.WriteLine("Produto comprado");
                    break;

                case 2:
                    if (produtos > 0)
                    {
                        produtos = produtos - 1;
                        Console.WriteLine("Venda realizada.");
                    }
                    else
                    {
                        Console.WriteLine("Você não possui produtos no seu estoque.");
                    }
                    break;
            }

            Console.WriteLine();
        }
