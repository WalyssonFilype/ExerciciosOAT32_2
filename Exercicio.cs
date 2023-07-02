using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOAT32_2
{
    public  class Exercicio
    {
        public void Questao33()
        {
            int alunos, matricula;
            double notas, media, nota;

            alunos = 0;
            notas = 0;
            Console.WriteLine("Informe um número negativo para encerrar.");
            while (true)
            {
                Console.Write("Informe o número da matrícula: ");
                matricula = Convert.ToInt32(Console.ReadLine());
                if (matricula < 0)
                    break;
                Console.Write("Informe a nota da prova: ");
                nota = Convert.ToDouble(Console.ReadLine());
                alunos++;
                notas += nota;
            }
            if (alunos > 0)
            {
                media = notas / alunos;
                Console.WriteLine($"A média das notas dos alunos é: {media.ToString("0.00")}");
            }
            else
            {
                Console.WriteLine("Nenhum aluno foi inserido.");
            }



        }
        public void Questao34()
        {

            int valor, menor, maior;

            Console.WriteLine("Digite um número positivo ou digite um número negativo para finalizar a sessão):");
            menor = int.MaxValue;
            maior = int.MinValue;
            while (true)
            {
                Console.Write("Informe um número: ");
                valor = Convert.ToInt32(Console.ReadLine());
                if (valor < 0)
                    break;
                if (valor < menor)
                    menor = valor;
                if (valor > maior)
                    maior = valor;
            }
            if (menor != int.MaxValue)
            {
                Console.WriteLine("O menor número é :" + menor + ".");
                Console.WriteLine("O maior número é :" + maior + ".");
            }
            else
            {
                Console.WriteLine("Nenhum número positivo foi inserido.");
            }

        }



        public void Questao35()
        {
            int i;

            for (i = 1; i <= 100; i++)
            {
                Console.WriteLine(i + ",");

                if (i % 10 == 0)
                {
                    Console.WriteLine(i + " é múltiplo de 10.");
                }
            }


        }
        public void Questao36()
        {
            int valor, maior, menor, soma;
            double media;

            valor = 10;
            maior = int.MinValue;
            menor = int.MaxValue;
            soma = 0;
            Console.WriteLine("Informe 10 valores inteiros e positivos:");
            for (int i = 1; i <= valor; i++)
            {
                Console.Write($"Digite o {i}º valor: ");
                valor = Convert.ToInt32(Console.ReadLine());
                if (valor > maior)
                    maior = valor;
                if (valor < menor)
                    menor = valor;
                soma += valor;
            }
            media = (double)soma / valor;
            Console.WriteLine("O maior valor é : " + maior + ".");
            Console.WriteLine("O menor valor é :" + menor + ".");
            Console.WriteLine($"A média dos valores é: {media.ToString("0.00")}");


        }
        public void Questao37()
        {
            int opcao;
            double valor1, valor2, result;
            bool menu;
            string resposta;

            menu = true;
            while (menu)
            {
                Console.WriteLine("Menu Principal");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - Sair");
                Console.Write("Informe a opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao == 0)
                {
                    menu = false;
                    continue;
                }
                Console.Write("Informe o primeiro número: ");
                valor1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe o segundo número: ");
                valor2 = Convert.ToDouble(Console.ReadLine());
                result = 0;
                switch (opcao)
                {
                    case 1:
                        result = valor1 + valor2;
                        Console.WriteLine("O resultado da adição é :" + result + ".");
                        break;
                    case 2:
                        result = valor1 - valor2;
                        Console.WriteLine("O resultado da subtração é :" + result + ".");
                        break;
                    case 3:
                        result = valor1 * valor2;
                        Console.WriteLine("O resulltado da multiplicação é :" + result + ".");
                        break;
                    case 4:
                        if (valor2 != 0)
                        {
                            result = valor1 / valor2;
                            Console.WriteLine("O resultado da divisão é :" + result + ".");
                        }
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
                Console.Write("Deseja voltar ao menu principal? (S/N): ");
                resposta = Console.ReadLine();
                if (resposta.Equals("S", StringComparison.OrdinalIgnoreCase))
                    menu = true;
                else
                    menu = false;
            }
            Console.WriteLine("Programa encerrado.");


        }
        public void Questao38()
        {
            int codigo, horasTrabalhadas, horasExcedentes;
            double salarioHora, salarioTotal, salarioExcedente;
            string resposta;

            resposta = string.Empty;
            do
            {
                Console.Write("Informe o código do operário: ");
                codigo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe o número de horas trabalhadas: ");
                horasTrabalhadas = Convert.ToInt32(Console.ReadLine());
                salarioHora = 10.00;
                salarioTotal = 0.00;
                salarioExcedente = 0.00;
                if (horasTrabalhadas > 50)
                {
                    horasExcedentes = horasTrabalhadas - 50;
                    salarioTotal = 50 * salarioHora;
                    salarioExcedente = horasExcedentes * 20.00;
                }
                else
                {
                    salarioTotal = horasTrabalhadas * salarioHora;
                }
                Console.WriteLine($"Salário Total: R$ {salarioTotal.ToString("0.00")}");
                Console.WriteLine($"Salário Excedente: R$ {salarioExcedente.ToString("0.00")}");
                Console.Write("Deseja encerrar o programa? (S/N): ");
                resposta = Console.ReadLine();
            }
            while (!resposta.Equals("S", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Programa encerrado.");

        }
        public void Questao39()
        {
            int valor;
            string res, parImpar, positivoNegativo;

            res = string.Empty;
            do
            {
                Console.Write("Digite um número inteiro: ");
                valor = Convert.ToInt32(Console.ReadLine());
                parImpar = (valor % 2 == 0) ? "par" : "ímpar";
                positivoNegativo = (valor >= 0) ? "positivo" : "negativo";
                Console.WriteLine($"O número digitado é {parImpar} e {positivoNegativo}.");
                Console.Write("Deseja encerrar o programa? (S/N): ");
                res = Console.ReadLine();
            }
            while (!res.Equals("S", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Programa encerrado.");


        }
        public void Questao40()
        {
            double indicePoluicao;
            string resposta;

            resposta = string.Empty;
            do
            {
                Console.Write("Informe o índice de poluição medido: ");
                indicePoluicao = Convert.ToDouble(Console.ReadLine());
                if (indicePoluicao >= 0.5)
                {
                    Console.WriteLine("Notificação para todos os grupos: Paralisar atividades!");
                }
                else if (indicePoluicao >= 0.4)
                {
                    Console.WriteLine("Notificação para o 1º e 2º grupos: Suspender atividades!");
                }
                else if (indicePoluicao >= 0.3)
                {
                    Console.WriteLine("Notificação para o 1º grupo: Suspender atividades!");
                }
                else
                {
                    Console.WriteLine("Índice de poluição aceitável.");
                }
                Console.Write("Deseja encerrar o programa? (S/N): ");
                resposta = Console.ReadLine();
            }
            while (!resposta.Equals("S", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Programa encerrado.");


        }
        public void Questao41()
        {
            int idade;

            Console.WriteLine("Informe sua idade:");
            idade = int.Parse(Console.ReadLine());
            if (idade > 4 && idade < 8)
            {
                Console.WriteLine("A categoria do nadador é INFANTIL A.");
            }
            else if (idade > 7 && idade < 12)
            {
                Console.WriteLine("A categoria do nadador é INFANTIL B.");
            }
            else if (idade > 11 && idade < 14)
            {
                Console.WriteLine("A categoria do nadador é JUVENIL A.");
            }
            else if (idade > 13 && idade < 18)
            {
                Console.WriteLine("A categoria do nadador é JUVENIL B.");
            }
            else if (idade > 17)
            {
                Console.WriteLine("A categoria do nadador é ADULTO.");
            }
            else
                Console.WriteLine("Informe uma idade válida");


        }
        public void Questao42()
        {
            int maior, menor, valor;

            maior = int.MinValue;
            menor = int.MaxValue;
            do
            {
                Console.Write("Informe um número ou 0 para sair): ");
                valor = Convert.ToInt32(Console.ReadLine());
                if (valor != 0)
                {
                    if (valor > maior)
                    {
                        maior = valor;
                    }
                    if (valor < menor)
                    {
                        menor = valor;
                    }
                }
            }
            while (valor != 0);
            if (maior != int.MinValue)
            {
                Console.WriteLine("O maior número é :" + maior + ".");
                Console.WriteLine($"O menor número é :" + menor + ".");
            }
            else
            {
                Console.WriteLine("Nenhum número foi digitado.");
            }



        }
        public void Questao43()
        {
            ulong total, graos;
            const int totalQuadros = 64;

            total = 0;
            graos = 1;
            for (int i = 1; i <= totalQuadros; i++)
            {
                total += graos;
                graos *= 2;
            }
            Console.WriteLine("O número total de grãos esperados pelo monge é : " + total + ".");



        }
        public void Questao44()
        {
            string opcao;

            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Conversão de Graus Celsius em Graus Fahrenheit");
                Console.WriteLine("2 - Conversão de Graus Fahrenheit em Graus Celsius");
                Console.WriteLine("3 - Peso ideal do homem");
                Console.WriteLine("4 - Peso ideal da mulher");
                Console.WriteLine("S - Encerrar o programa");
                Console.Write("Opção: ");
                opcao = Console.ReadLine();
                Console.WriteLine();
                switch (opcao)
                {
                    case "1":
                        ConverterCelsiusParaFahrenheit();
                        break;
                    case "2":
                        ConverterFahrenheitParaCelsius();
                        break;
                    case "3":
                        CalcularPesoIdealHomem();
                        break;
                    case "4":
                        CalcularPesoIdealMulher();
                        break;
                    case "S":
                    case "s":
                        Console.WriteLine("Encerrando o programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
                Console.WriteLine();
            }
            while (opcao != "S" && opcao != "s");
        }
        static void ConverterCelsiusParaFahrenheit()
        {
            Console.Write("Digite a temperatura em graus Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"A temperatura em graus Fahrenheit é: {fahrenheit}°F");
        }
        static void ConverterFahrenheitParaCelsius()
        {
            Console.Write("Digite a temperatura em graus Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"A temperatura em graus Celsius é: {celsius}°C");
        }
        static void CalcularPesoIdealHomem()
        {
            Console.Write("Digite a altura em metros: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            double pesoIdeal = (72.7 * altura) - 58;
            Console.Write("Digite o peso atual em kg: ");
            double pesoAtual = Convert.ToDouble(Console.ReadLine());
            if (pesoAtual < pesoIdeal)
            {
                Console.WriteLine("Você está abaixo do peso ideal.");
            }
            else if (pesoAtual > pesoIdeal)
            {
                Console.WriteLine("Você está acima do peso ideal.");
            }
            else
            {
                Console.WriteLine("Você está no peso ideal.");
            }
        }
        static void CalcularPesoIdealMulher()
        {
            Console.Write("Digite a altura em metros: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            double pesoIdeal = (62.1 * altura) - 44.7;
            Console.Write("Digite o peso atual em kg: ");
            double pesoAtual = Convert.ToDouble(Console.ReadLine());
            if (pesoAtual < pesoIdeal)
            {
                Console.WriteLine("Você está abaixo do peso ideal.");
            }
            else if (pesoAtual > pesoIdeal)
            {
                Console.WriteLine("Você está acima do peso ideal.");
            }
            else
            {
                Console.WriteLine("Você está no peso ideal.");
            }


        }

        public void Questao45()
        {

            int tamanho, i;

            {
                Console.Write("Digite o tamanho da sequência de números: ");
                tamanho = Convert.ToInt32(Console.ReadLine());
                int[] valor = new int[tamanho];
                for (i = 0; i < tamanho; i++)
                {
                    Console.Write($"Digite o {i + 1}º número: ");
                    valor[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("A sequência de números na ordem inversa é:");
                for (i = tamanho - 1; i >= 0; i--)
                {
                    Console.WriteLine(valor[i]);
                }
            }


        }



        public void Questao46()
        {
            Console.Write("Digite o valor dos vetores: ");
            int tamanho = Convert.ToInt32(Console.ReadLine());

            int[] x = new int[tamanho];
            int[] y = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o {i + 1}º elemento do vetor x: ");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o {i + 1}º elemento do vetor y: ");
                y[i] = Convert.ToInt32(Console.ReadLine());
            }
            int produtoEscalar = 0;
            for (int i = 0; i < tamanho; i++)
            {
                produtoEscalar += x[i] * y[i];
            }
            Console.WriteLine($"O produto escalar dos vetores é: {produtoEscalar}");


        }
        public void Questao47()
        {
            int[] vetor = new int[10];
            int x, maiores = 0, menores = 0, iguais = 0;

            Console.WriteLine("Digite os elementos do vetor:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Digite um número inteiro: ");
            x = Convert.ToInt32(Console.ReadLine());

            foreach (int numero in vetor)
            {
                if (numero > x)
                    maiores++;
                else if (numero < x)
                    menores++;
                else
                    iguais++;
            }

            Console.WriteLine($"Quantidade de números maiores que {x}: {maiores}");
            Console.WriteLine($"Quantidade de números menores que {x}: {menores}");
            Console.WriteLine($"Quantidade de números iguais a {x}: {iguais}");


        }
        public void Questao48()
        {
            string[] nomes = new string[20];
            int[] idades = new int[20];
            int quantidadeAptas = 0;

            Console.WriteLine("Insira os dados das candidatas:");

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Nome da candidata {i + 1}: ");
                nomes[i] = Console.ReadLine();

                Console.Write($"Idade da candidata {i + 1}: ");
                idades[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nCandidatas aptas:");

            for (int i = 0; i < 20; i++)
            {
                if (idades[i] >= 18 && idades[i] <= 20)
                {
                    Console.WriteLine(nomes[i]);
                    quantidadeAptas++;
                }
            }

            if (quantidadeAptas == 0)
                Console.WriteLine("Não há candidatas aptas.");


        }
        public void Questao49()
        {
            int[] V1 = new int[50];
            int[] V2 = new int[50];
            int N;

            Console.Write("Digite a quantidade de elementos dos vetores (máximo 50): ");
            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite os elementos do vetor V1:");

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Digite o {i + 1}º elemento: ");
                V1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Digite os elementos do vetor V2:");

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Digite o {i + 1}º elemento: ");
                V2[i] = Convert.ToInt32(Console.ReadLine());
            }

            int contagem = 0;

            for (int i = 0; i < N; i++)
            {
                if (V1[i] == V2[i])
                    contagem++;
            }

            Console.WriteLine($"Número de vezes que V1 e V2 possuem valores idênticos nas mesmas posições: {contagem}");



        }
        public void Questao50()
        {
            Random random = new Random();
            int numeroSorteado = random.Next(101);
            int tentativa;
            int tentativasFeitas = 0;

            Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
            Console.WriteLine("Tente adivinhar o número sorteado de 0 a 100.");

            do
            {
                Console.Write("Digite sua tentativa: ");
                tentativa = Convert.ToInt32(Console.ReadLine());
                tentativasFeitas++;

                if (tentativa < numeroSorteado)
                {
                    Console.WriteLine("O número sorteado é maior que a sua tentativa.");
                }
                else if (tentativa > numeroSorteado)
                {
                    Console.WriteLine("O número sorteado é menor que a sua tentativa.");
                }
                else
                {
                    Console.WriteLine("Parabéns! Você acertou o número sorteado.");
                    Console.WriteLine($"Número de tentativas: {tentativasFeitas}");
                }
            }
            while (tentativa != numeroSorteado);


        }
        public void Questao51()
        {
            Console.Write("Digite a quantidade de alunos: ");
            int quantidadeAlunos = Convert.ToInt32(Console.ReadLine());

            double[] notas = new double[quantidadeAlunos];
            double somaNotas = 0;
            int alunosAcimaDeSete = 0;

            for (int i = 0; i < quantidadeAlunos; i++)
            {
                Console.Write($"Digite a nota do aluno {i + 1}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                somaNotas += notas[i];

                if (notas[i] > 7.0)
                {
                    alunosAcimaDeSete++;
                }
            }

            if (quantidadeAlunos > 0)
            {
                double media = somaNotas / quantidadeAlunos;

                Console.WriteLine($"Média das notas: {media:F2}");
                Console.WriteLine($"Alunos com nota acima de 7.0: {alunosAcimaDeSete}");
            }
            else
            {
                Console.WriteLine("Não há nenhum aluno.");
            }


        }
        public void Questao52()
        {
            const int tamanhoMaximo = 100;
            int[] vetor = new int[tamanhoMaximo];
            int posicao = 0;

            Console.WriteLine("Digite os números inteiros e positivos (digite -1 para sair):");

            while (posicao < tamanhoMaximo)
            {
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero == -1)
                {
                    break;
                }

                vetor[posicao] = numero;
                posicao++;
            }

            int contador1 = 0;
            int contador3 = 0;
            int contador4 = 0;

            for (int i = 0; i < posicao; i++)
            {
                if (vetor[i] == 1)
                {
                    contador1++;
                }
                else if (vetor[i] == 3)
                {
                    contador3++;
                }
                else if (vetor[i] == 4)
                {
                    contador4++;
                }
            }

            Console.WriteLine($"Quantidade de vezes que o número 1 aparece: {contador1}");
            Console.WriteLine($"Quantidade de vezes que o número 3 aparece: {contador3}");
            Console.WriteLine($"Quantidade de vezes que o número 4 aparece: {contador4}");



        }
        public void Questao53()
        {
            Console.WriteLine("Informe a quantidade de voltas:");
            int numeroVoltas = Convert.ToInt32(Console.ReadLine());

            double[] tempos = new double[numeroVoltas];

            for (int i = 0; i < numeroVoltas; i++)
            {
                Console.WriteLine($"Informe o tempo da volta {i + 1}:");
                tempos[i] = Convert.ToDouble(Console.ReadLine());
            }

            double melhorTempo = tempos[0];
            int voltaMelhorTempo = 1;
            double somaTempos = tempos[0];

            for (int i = 1; i < numeroVoltas; i++)
            {
                if (tempos[i] < melhorTempo)
                {
                    melhorTempo = tempos[i];
                    voltaMelhorTempo = i + 1;
                }

                somaTempos += tempos[i];
            }

            double tempoMedio = somaTempos / numeroVoltas;

            Console.WriteLine($"Melhor tempo: {melhorTempo}");
            Console.WriteLine($"Volta do melhor tempo: {voltaMelhorTempo}");
            Console.WriteLine($"Tempo médio: {tempoMedio}");


        }
        public void Questao54()
        {
            int[] A = { 1, 2, 3, 4, 5 };
            int[] B = { 4, 5, 6, 7, 8, 9, 10, 11 };

            Console.Write("Elementos comuns nos vetores A e B: ");
            foreach (int elementA in A)
            {
                foreach (int elementB in B)
                {
                    if (elementA == elementB)
                    {
                        Console.Write(elementA + " ");
                        break;
                    }
                }
            }


        }
        public void Questao55()
        {
            static void Main(string[] args)
            {
                Console.Write("Digite uma frase de até 50 caracteres: ");
                string frase = Console.ReadLine();

                string fraseSemEspacos = frase.Replace(" ", "");

                Console.WriteLine("Frase sem espaços: " + fraseSemEspacos);
                Console.WriteLine("Quantidade de espaços em branco: " + ContarEspacos(frase));
            }

            static int ContarEspacos(string frase)
            {
                int contador = 0;
                foreach (char caractere in frase)
                {
                    if (caractere == ' ')
                        contador++;
                }
                return contador;
            }


        }

        public void Questao56()
        {

            static void Main(string[] args)
            {
                int[] vetor = new int[50];

                Console.WriteLine("Digite os valores do vetor:");

                for (int i = 0; i < vetor.Length; i++)
                {
                    Console.Write("Posição " + (i + 1) + ": ");
                    vetor[i] = int.Parse(Console.ReadLine());
                }

                int pares = 0;
                int multiplosDe5 = 0;

                foreach (int numero in vetor)
                {
                    if (numero % 2 == 0)
                        pares++;

                    if (numero % 5 == 0)
                        multiplosDe5++;
                }

                Console.WriteLine("Quantidade de números pares: " + pares);
                Console.WriteLine("Quantidade de múltiplos de 5: " + multiplosDe5);
            }


        }



        public void Questao57()
        {
            static void Main(string[] args)
            {
                Console.Write("Digite uma frase: ");
                string frase = Console.ReadLine();

                Console.Write("Vogais encontradas na frase: ");
                foreach (char c in frase)
                {
                    if (IsVowel(c))
                    {
                        Console.Write(c + " ");
                    }
                }
                Console.WriteLine();
            }

            static bool IsVowel(char c)
            {
                char lowerC = Char.ToLower(c);
                return lowerC == 'a' || lowerC == 'e' || lowerC == 'i' || lowerC == 'o' || lowerC == 'u';
            }


        }
        public void Questao58()
        {
            static void Main(string[] args)
            {
                Console.Write("Digite a quantidade de números a serem lidos: ");
                int quantidade = int.Parse(Console.ReadLine());

                int[] numeros = new int[quantidade];

                for (int i = 0; i < quantidade; i++)
                {
                    Console.Write("Digite o número " + (i + 1) + ": ");
                    numeros[i] = int.Parse(Console.ReadLine());
                }

                double soma = 0;
                int maior = numeros[0];

                foreach (int numero in numeros)
                {
                    soma += numero;

                    if (numero > maior)
                        maior = numero;
                }

                double media = soma / quantidade;

                Console.WriteLine("Média: " + media);
                Console.WriteLine("Maior número: " + maior);
            }




        }
        public void Questao59()
        {
            static void Main(string[] args)
            {
                Console.Write("Digite o primeiro caractere (de A a Z): ");
                char primeiroCaractere = char.ToUpper(Console.ReadKey().KeyChar);

                Console.WriteLine();

                Console.Write("Digite o segundo caractere (de A a Z): ");
                char segundoCaractere = char.ToUpper(Console.ReadKey().KeyChar);

                Console.WriteLine();

                if (primeiroCaractere >= 'A' && primeiroCaractere <= 'Z' &&
                    segundoCaractere >= 'A' && segundoCaractere <= 'Z')
                {
                    if (primeiroCaractere > segundoCaractere)
                    {
                        Console.WriteLine("Erro: Os caracteres não estão em ordem alfabética.");
                    }
                    else
                    {
                        int numeroCaracteres = segundoCaractere - primeiroCaractere - 1;
                        Console.WriteLine("O número de caracteres entre eles é: " + numeroCaracteres);
                    }
                }
                else
                {
                    Console.WriteLine("Erro: Os caracteres devem ser letras de A a Z.");
                }
            }



        }
        public void Questao60()
        {
            static void Main(string[] args)
            {
                Console.Write("Digite o valor de x: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor de y: ");
                int y = int.Parse(Console.ReadLine());

                int quadrante = VerificaQuadrante(x, y);
                Console.WriteLine("O ponto está no quadrante " + quadrante);
            }

            static int VerificaQuadrante(int x, int y)
            {
                if (x > 0 && y > 0)
                {
                    return 1; // Primeiro quadrante
                }
                else if (x < 0 && y > 0)
                {
                    return 2; // Segundo quadrante
                }
                else if (x < 0 && y < 0)
                {
                    return 3; // Terceiro quadrante
                }
                else if (x > 0 && y < 0)
                {
                    return 4; // Quarto quadrante
                }
                else
                {
                    return 0; // Origem (ponto central)
                }
            }


        }
        public void Questao61()
        {
            static void Main(string[] args)
            {
                Console.Write("Digite o valor do salário: ");
                double salario = double.Parse(Console.ReadLine());

                Console.Write("Digite o índice de reajuste (em decimal): ");
                double indice = double.Parse(Console.ReadLine());

                double salarioAtualizado = Reajuste(salario, indice);
                Console.WriteLine("O salário atualizado é: " + salarioAtualizado);
            }

            static double Reajuste(double salario, double indice)
            {
                double salarioAtualizado = salario + (salario * indice);
                return salarioAtualizado;
            }



        }
        public void Questao62()
        {
            static void Main(string[] args)
            {
                Console.Write("Digite o valor da base do triângulo: ");
                double baseTriangulo = double.Parse(Console.ReadLine());

                Console.Write("Digite o valor da altura do triângulo: ");
                double alturaTriangulo = double.Parse(Console.ReadLine());

                double hipotenusa = Hipotenusa(baseTriangulo, alturaTriangulo);
                Console.WriteLine("O valor da hipotenusa é: " + hipotenusa);
            }

            static double Hipotenusa(double baseTriangulo, double alturaTriangulo)
            {
                double hipotenusa = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
                return hipotenusa;
            }

        }



        public void Questao63()
        {
            static void Main(string[] args)
            {
                Console.Write("Digite um número inteiro: ");
                int numero = int.Parse(Console.ReadLine());

                string resultado = Verifica(numero);
                Console.WriteLine("O número é: " + resultado);
            }

            static string Verifica(int numero)
            {
                if (numero % 2 == 0)
                {
                    return "PAR";
                }
                else
                {
                    return "ÍMPAR";
                }
            }

        }
        public void Questao64()
        {
            int i, valor, soma, contador;

            {
                Console.Write("Informe um número que esteja entre 0 e 10: ");
                valor = Convert.ToInt32(Console.ReadLine());
                if (valor > 0 && valor < 10)
                {
                    soma = 0;
                    contador = 0;
                    for (i = valor; contador < 20; i++)
                    {
                        if (i % 2 != 0)
                        {
                            soma += i * i;
                            contador++;
                        }
                    }
                    Console.WriteLine("A soma dos quadrados dos 20 primeiros números ímpares a partir de " + valor + "é: " + soma + ".");
                }
                else
                {
                    Console.WriteLine("O número informado não corresponde aos valores entre 0 e 10.");
                }
            }



        }





    }
}
