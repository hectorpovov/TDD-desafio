using TDD.services;

while (true)
{
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Verificar se é par");
    Console.WriteLine("6 - verificar se é ímpar");
    Console.WriteLine("7 - Elevar ao quadrado");
    Console.WriteLine("8 - Elevar ao cubo");
    Console.WriteLine("9 - Encerrar programa");
    
    Console.WriteLine("Escolha uma opção:");
    int escolha = Convert.ToInt32(Console.ReadLine());

//---------------------------------------------------------------------------------//
//---------------------------------------------------------------------------------//
//---------------------------------------------------------------------------------//

    if (escolha == 1) //somar
    {
        Calculadora calc = new Calculadora();
        Console.WriteLine("escolha o primeiro numero a ser somado:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("escolha o segundo numero a ser somado:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int resultado = calc.Somar(num1, num2);
        Console.WriteLine($"A soma de {num1} e {num2} é igual a {resultado}");
        
        
        Console.WriteLine("Continuar? sim |y|, não |n|");
        string cont = Console.ReadLine() ?? ""; 
        if (cont == "y")
        {
            continue;
        }
        else
        {
            Console.WriteLine("Encerrando Programa");
            break;
        }
        
    }

//---------------------------------------------------------------------------------//
//---------------------------------------------------------------------------------//
//---------------------------------------------------------------------------------//

    else if (escolha == 2) //subtrair
    {
        Calculadora calc = new Calculadora();
        Console.WriteLine("escolha o primeiro numero:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("escolha um numero para subtrai-lo:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int resultado = calc.Substrair(num1, num2);
        Console.WriteLine($"A subtração de {num1} por {num2} é igual a {resultado}");
        
        
        Console.WriteLine("Continuar? sim |y|, não |n|");
        string cont = Console.ReadLine() ?? ""; 
        if (cont == "y")
        {
            continue;
        }
        else
        {
            Console.WriteLine("Encerrando Programa");
            break;
        }
    }

//---------------------------------------------------------------------------------//
//---------------------------------------------------------------------------------//
//---------------------------------------------------------------------------------//

    else if (escolha == 3) // multiplicar
    {
        Calculadora calc = new Calculadora();
        Console.WriteLine("escolha o primeiro numero a ser multiplicado:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("escolha o segundo numero a ser multiplicado:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int resultado = calc.Multiplicar(num1, num2);
        Console.WriteLine($"A multiplicação de {num1} e {num2} é igual a {resultado}");
        
        
        Console.WriteLine("Continuar? sim |y|, não |n|");
        string cont = Console.ReadLine() ?? ""; 
        if (cont == "y")
        {
            continue;
        }
        else
        {
            Console.WriteLine("Encerrando Programa");
            break;
        }
    }

//---------------------------------------------------------------------------------//
//---------------------------------------------------------------------------------//
//---------------------------------------------------------------------------------//

    else if (escolha == 4) // dividir
    {
        Calculadora calc = new Calculadora();
        Console.WriteLine("escolha o primeiro numero:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("escolha um numero para dividi-lo:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int resultado = calc.Dividir(num1, num2);
        Console.WriteLine($"A divisão de {num1} por {num2} é igual a {resultado}");
        
        
        Console.WriteLine("Continuar? sim |y|, não |n|");
        string cont = Console.ReadLine() ?? ""; 
        if (cont == "y")
        {
            continue;
        }
        else
        {
            Console.WriteLine("Encerrando Programa");
            break;
        }
    }

//---------------------------------------------------------------------------------//
//---------------------------------------------------------------------------------//
//---------------------------------------------------------------------------------//

    else if (escolha == 5) //verificar se é par
    {
        Calculadora calc = new Calculadora();
        Console.WriteLine("escolha um numero:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        bool resultado = calc.EhPar(num1);
        if (resultado)
            Console.WriteLine($"{num1} é par");
        else
        {
            Console.WriteLine($"{num1} não é par");
        }
        
        Console.WriteLine("Continuar? sim |y|, não |n|");
        string cont = Console.ReadLine() ?? ""; 
        if (cont == "y")
        {
            continue;
        }
        else
        {
            Console.WriteLine("Encerrando Programa");
            break;
        }
    }

//---------------------------------------------------------------------------------//
//---------------------------------------------------------------------------------//
//---------------------------------------------------------------------------------//

    else if (escolha == 6) //verificar se é ímpar
    {
        Calculadora calc = new Calculadora();
        Console.WriteLine("escolha um numero:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        bool resultado = calc.NaoEhPar(num1);
        if (resultado)
            Console.WriteLine($"{num1} é ímpar");
        else
        {
            Console.WriteLine($"{num1} não é ímpar");
        }
        
        Console.WriteLine("Continuar? sim |y|, não |n|");
        string cont = Console.ReadLine() ?? ""; 
        if (cont == "y")
        {
            continue;
        }
        else
        {
            Console.WriteLine("Encerrando Programa");
            break;
        }
    }

//---------------------------------------------------------------------------------//
//---------------------------------------------------------------------------------//
//---------------------------------------------------------------------------------//

    else if (escolha == 7) //elevar ao quadrado
    {
        Calculadora calc = new Calculadora();
        Console.WriteLine("escolha um numero:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int resultado = calc.ElevarAoQuadrado(num1);
        Console.WriteLine($"O quadrado de {num1} é {resultado}");
        
        Console.WriteLine("Continuar? sim |y|, não |n|");
        string cont = Console.ReadLine() ?? ""; 
        if (cont == "y")
        {
            continue;
        }
        else
        {
            Console.WriteLine("Encerrando Programa");
            break;
        }
    }

//---------------------------------------------------------------------------------//
//---------------------------------------------------------------------------------//
//---------------------------------------------------------------------------------//

    else if (escolha == 8) //elevar ao cubo
    {
        Calculadora calc = new Calculadora();
        Console.WriteLine("escolha um numero:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int resultado = calc.ElevarAoCubo(num1);
        Console.WriteLine($"O cubo de {num1} é {resultado}");
        
        Console.WriteLine("Continuar? sim |y|, não |n|");
        string cont = Console.ReadLine() ?? ""; 
        if (cont == "y")
        {
            continue;
        }
        else
        {
            Console.WriteLine("Encerrando Programa");
            break;
        }
    }

//---------------------------------------------------------------------------------//
//---------------------------------------------------------------------------------//
//---------------------------------------------------------------------------------//

    else if (escolha == 9) //encerrar
    {
        Console.WriteLine("Encerrando programa");
        break;
    }
    else
    {
        Console.WriteLine("Escolha inválida");
    }

    

}