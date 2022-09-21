using ExemplosFundamentos.Models;

string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite uma opção do menu.");
    Console.WriteLine("1 - Cadastrar Cliente.");
    Console.WriteLine("2 - Buscar Cliente.");
    Console.WriteLine("3 - Apagar Cliente.");
    Console.WriteLine("4 - Encerrar.");
    
    Console.WriteLine("");
    opcao = Console.ReadLine();
    

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de Cliente.");
            Console.WriteLine("");
            break;
        case "2":
            Console.WriteLine("Busca de Cliente.");
            Console.WriteLine("");
            break;
        case "3":
            Console.WriteLine("Apagar Cliente.");
            Console.WriteLine("");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            Console.WriteLine("");
            // Environment.Exit(0);
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;

    }

}

Console.WriteLine("O programa se encerrou.");


//--------------------------------------------------------------------------
// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um numero ou '0' para parar a soma e obter a soma.");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while (numero != 0);
// Console.WriteLine($"O total da soma dos numeros digitados é {soma}");

//--------------------------------------------------------------------------
// int numero = 5;
// int contador = 0;

// Console.WriteLine($"#--------------#");
// Console.WriteLine($"# Tabuada do {numero}");
// Console.WriteLine($"#--------------#");

// while(contador<=10)
// {
//     Console.WriteLine($"{numero} X {contador} = {numero * contador}");
//     contador++;
// }

//--------------------------------------------------------------------------
// int numero = 5;
// Console.WriteLine($"#--------------#");
// Console.WriteLine($"# Tabuada do {numero}");
// Console.WriteLine($"#--------------#");

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($" {numero} X {contador} = {numero * contador} ");
// }

//--------------------------------------------------------------------------
// Calculadora calc = new Calculadora();

// calc.Somar( 10, 30 );
// calc.Subtrair( 30, 10 );
// calc.Multiplicar( 5, 20 );
// calc.Dividir( 2, 2 );

// calc.Potencia(3, 3);
// calc.raizQuadrada(9);

//--------------------------------------------------------------------------
// bool choveu = false;
// bool estaTarde = false;

// if ( !choveu && !estaTarde )
// {
//     Console.WriteLine("Vou pedalar.");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia.");
// }

//--------------------------------------------------------------------------
// bool possuiPresencaMinima = true;
// double media = 7.5;

// if ( possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }

//--------------------------------------------------------------------------
// bool ehMaiordeIdade = false;
// bool possuiAutitizacaoDoResponsavel = false;

// if ( ehMaiordeIdade || possuiAutitizacaoDoResponsavel )
// {
//     Console.WriteLine("Entrada Liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }

//--------------------------------------------------------------------------
// Console.WriteLine("Digite uma letra.");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//     Console.WriteLine("Vogal");
//         break;

//     default:
//     Console.WriteLine("Não é uma Vogal");
//         break;
// }



//--------------------------------------------------------------------------
// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if ( quantidadeCompra == 0 )
// {
//     Console.WriteLine("Venda invalida.");
// } 
// else if(possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }


//--------------------------------------------------------------------------
// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);

//--------------------------------------------------------------------------
//Cast - Casting
// int a = Convert.ToInt32("5");
// int a = int.Parse("5");
// int a = Convert.ToInt32(null);
// int a = int.Parse(null); // Gera erro pois não aceita null
// Console.WriteLine(a);

//--------------------------------------------------------------------------
// int a = 10;
// int b = 20;

// int c = a + b;
// c = c + 5;
// c += 5;
// c -= 5;
// c *= 5;
//c /= 5;

// Console.WriteLine(c);

//--------------------------------------------------------------------------
// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
//--------------------------------------------------------------------------
// string apresentacao = "Olá, seja bem vindo!";

// int quantidade  = 1;
// Console.WriteLine("Valor da variável quantidade " + quantidade);

// quantidade  = 10;
// Console.WriteLine("Valor da variável quantidade " + quantidade);

// double altura = 1.80;

// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade " + quantidade);
// Console.WriteLine("Valor da variável altura " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preço " + preco);
// Console.WriteLine("Valor da variável condição " + condicao);
//--------------------------------------------------------------------------
// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Sergio";
// pessoa1.Idade = 39;
// pessoa1.Apresentar();

// Pessoa pessoaFisicaRepresentacao = new Pessoa();