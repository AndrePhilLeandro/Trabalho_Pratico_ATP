using System;
using System.IO;
namespace Trabalho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CriaMapa();
            int op = 0;
            while (op >= 11 || op <= 0)
            {
                Console.Write("Selecione o mapa de 1 a 10: ");
                op = int.Parse(Console.ReadLine());
                SelecionaMapa(op);
            }
            Console.ReadKey();
        }
        public static void CriaMapa()
        {
            using (StreamWriter Grava = new StreamWriter($"mapa1.txt"))
            {
                char[,] Mapa1 = new char[5, 6];
                for (int i = 0; i < Mapa1.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa1.GetLength(1); j++)
                    {
                        Mapa1[i, j] = 'X';
                    }
                }
                for (int i = 0; i < Mapa1.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa1.GetLength(1); j++)
                    {
                        if ((i == 0 && j == 1) || (i == 4 && j == 2))
                        {
                            Mapa1[i, j] = (i == 0 && j == 1) ? 'S' : 'E';
                        }
                        if ((i == 1 && (j >= 1 && j <= 4)) || (i == 2 && j == 4) || (i == 3 && (j == 2 || j == 3 || j == 4)))
                        {
                            Mapa1[i, j] = ' ';
                        }
                    }
                }
                for (int i = 0; i < Mapa1.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa1.GetLength(1); j++)
                    {
                        Grava.Write(Mapa1[i, j] + " ");
                    }
                    Grava.WriteLine();
                }
            }
            using (StreamWriter Grava = new StreamWriter($"mapa2.txt"))
            {
                char[,] Mapa2 = new char[5, 4];
                for (int i = 0; i < Mapa2.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa2.GetLength(1); j++)
                    {
                        Mapa2[i, j] = 'X';
                    }
                }
                for (int i = 0; i < Mapa2.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa2.GetLength(1); j++)
                    {
                        if (i == 0 && j == 1)
                        {
                            Mapa2[i, j] = 'S';
                        }
                        if (i == 3 && j == 0)
                        {
                            Mapa2[i, j] = 'E';
                        }
                        if ((i == 1 && j == 1) || (i == 1 && j == 2) || (i == 2 && j == 2) || (i == 3 && j == 2) || (i == 3 && j == 1))
                        {
                            Mapa2[i, j] = ' ';
                        }
                    }
                }
                for (int i = 0; i < Mapa2.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa2.GetLength(1); j++)
                    {
                        Grava.Write(Mapa2[i, j] + " ");
                    }
                    Grava.WriteLine();
                }
            }
            using (StreamWriter Grava = new StreamWriter($"mapa3.txt"))
            {
                char[,] Mapa3 = new char[7, 8];
                for (int i = 0; i < Mapa3.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa3.GetLength(1); j++)
                    {
                        Mapa3[i, j] = 'X';
                    }
                }
                for (int i = 0; i < Mapa3.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa3.GetLength(1); j++)
                    {
                        if (i == 1 && j == 7)
                        {
                            Mapa3[i, j] = 'S';
                        }
                        if (i == 6 && j == 6)
                        {
                            Mapa3[i, j] = 'E';
                        }
                        if ((i == 1 && (j == 6 || j == 5)) || (i == 2 && (j == 5 || j == 4 || j == 3)) || (i == 3 && (j == 3 || j == 2 || j == 1)) || (i == 4 && (j == 1 || j == 4 || j == 5 || j == 6)) || (i == 5 && (j == 1 || j == 2 || j == 3 || j == 4 || j == 6)))
                        {
                            Mapa3[i, j] = ' ';
                        }
                    }
                }
                for (int i = 0; i < Mapa3.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa3.GetLength(1); j++)
                    {
                        Grava.Write(Mapa3[i, j] + " ");
                    }
                    Grava.WriteLine();
                }
            }
            using (StreamWriter Grava = new StreamWriter($"mapa4.txt"))
            {
                char[,] Mapa4 = new char[7, 6];
                for (int i = 0; i < Mapa4.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa4.GetLength(1); j++)
                    {
                        Mapa4[i, j] = 'X';
                    }
                }
                for (int i = 0; i < Mapa4.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa4.GetLength(1); j++)
                    {
                        if (i == 0 && j == 2)
                        {
                            Mapa4[i, j] = 'S';
                        }
                        if (i == 6 && j == 4)
                        {
                            Mapa4[i, j] = 'E';
                        }
                        if ((i == 1 && (j == 2 || j == 3 || j == 4)) || (i == 2 && (j == 1 || j == 4)) || (i == 3 && (j == 1 || j == 2 || j == 3 || j == 4)) || (i == 4 && j == 1) || (i == 5 && (j == 1 || j == 2 || j == 3 || j == 4)))
                        {
                            Mapa4[i, j] = ' ';
                        }
                    }
                }
                for (int i = 0; i < Mapa4.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa4.GetLength(1); j++)
                    {
                        Grava.Write(Mapa4[i, j] + " ");
                    }
                    Grava.WriteLine();
                }
            }
            using (StreamWriter Grava = new StreamWriter($"mapa5.txt"))
            {
                char[,] Mapa5 = new char[7, 9];
                for (int i = 0; i < Mapa5.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa5.GetLength(1); j++)
                    {
                        Mapa5[i, j] = 'X';
                    }
                }
                for (int i = 0; i < Mapa5.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa5.GetLength(1); j++)
                    {
                        if (i == 0 && j == 2)
                        {
                            Mapa5[i, j] = 'S';
                        }
                        if (i == 6 && j == 3)
                        {
                            Mapa5[i, j] = 'E';
                        }
                        if ((i == 1 && (j >= 1 && j <= 7)) || (i == 2 && (j == 3 || j == 7)) || (i == 3 && (j == 1 || j == 2 || j == 3 || j == 5 || j == 7)) || (i == 4 && (j == 1 || j == 5 || j == 7)) || (i == 5 && (j >= 1 && j <= 3 || j == 5 || j == 6 || j == 7)))
                        {
                            Mapa5[i, j] = ' ';
                        }
                    }
                }
                for (int i = 0; i < Mapa5.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa5.GetLength(1); j++)
                    {
                        Grava.Write(Mapa5[i, j] + " ");
                    }
                    Grava.WriteLine();
                }
            }
            using (StreamWriter Grava = new StreamWriter($"mapa6.txt"))
            {
                char[,] Mapa6 = new char[7, 9];
                for (int i = 0; i < Mapa6.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa6.GetLength(1); j++)
                    {
                        Mapa6[i, j] = 'X';
                    }
                }
                for (int i = 0; i < Mapa6.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa6.GetLength(1); j++)
                    {
                        if (i == 1 && j == 8)
                        {
                            Mapa6[i, j] = 'S';
                        }
                        if (i == 6 && j == 3)
                        {
                            Mapa6[i, j] = 'E';
                        }
                        if ((i == 1 && (j >= 1 && j <= 7)) || (i == 2 && j == 7) || (i == 3 && (j == 1 || j == 2 || j == 3 || j == 4 || j == 5 || j == 7)) || (i == 4 && (j == 1 || j == 5 || j == 7)) || (i == 5 && (j == 1 || j == 2 || j == 3 || j == 5 || j == 6 || j == 7)))
                        {
                            Mapa6[i, j] = ' ';
                        }
                    }
                }
                for (int i = 0; i < Mapa6.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa6.GetLength(1); j++)
                    {
                        Grava.Write(Mapa6[i, j] + " ");
                    }
                    Grava.WriteLine();
                }
            }
            using (StreamWriter Grava = new StreamWriter($"mapa7.txt"))
            {
                char[,] Mapa7 = new char[6, 6];
                for (int i = 0; i < Mapa7.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa7.GetLength(1); j++)
                    {
                        Mapa7[i, j] = 'X';
                    }
                }
                for (int i = 0; i < Mapa7.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa7.GetLength(1); j++)
                    {
                        if (i == 4 && j == 0)
                        {
                            Mapa7[i, j] = 'S';
                        }
                        if (i == 1 && j == 0)
                        {
                            Mapa7[i, j] = 'E';
                        }
                        if ((i == 1 && j == 1) || (i == 2 && (j >= 1 && j <= 4)) || (i == 3 && j == 4) || (i == 4 && (j >= 1 && j <= 4)))
                        {
                            Mapa7[i, j] = ' ';
                        }
                    }
                }
                for (int i = 0; i < Mapa7.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa7.GetLength(1); j++)
                    {
                        Grava.Write(Mapa7[i, j] + " ");
                    }
                    Grava.WriteLine();
                }
            }
            using (StreamWriter Grava = new StreamWriter($"mapa8.txt"))
            {
                char[,] Mapa8 = new char[8, 9];
                for (int i = 0; i < Mapa8.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa8.GetLength(1); j++)
                    {
                        Mapa8[i, j] = 'X';
                    }
                }
                for (int i = 0; i < Mapa8.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa8.GetLength(1); j++)
                    {
                        if (i == 5 && j == 0)
                        {
                            Mapa8[i, j] = 'S';
                        }
                        if (i == 1 && j == 8)
                        {
                            Mapa8[i, j] = 'E';
                        }
                        if ((i == 1 && (j >= 1 && j <= 7)) || (i == 2 && (j == 1 || j == 6)) || (i == 3 && (j == 1 || j == 2 || j == 3 || j == 4 || j == 5 || j == 7)) || (i == 4 && (j == 2 || j == 4 || j == 7)) || (i == 5 && (j == 1 || j == 3 || j == 4 || j == 5 || j == 7)) || (i == 6 && (j == 1 || j == 2 || j == 3 || j == 5 || j == 6 || j == 7)))
                        {
                            Mapa8[i, j] = ' ';
                        }
                    }
                }
                for (int i = 0; i < Mapa8.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa8.GetLength(1); j++)
                    {
                        Grava.Write(Mapa8[i, j] + " ");
                    }
                    Grava.WriteLine();
                }
            }
            using (StreamWriter Grava = new StreamWriter($"mapa9.txt"))
            {
                char[,] Mapa9 = new char[6, 9];
                for (int i = 0; i < Mapa9.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa9.GetLength(1); j++)
                    {
                        Mapa9[i, j] = 'X';
                    }
                }
                for (int i = 0; i < Mapa9.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa9.GetLength(1); j++)
                    {
                        if (i == 0 && j == 2)
                        {
                            Mapa9[i, j] = 'S';
                        }
                        if (i == 0 && j == 4)
                        {
                            Mapa9[i, j] = 'E';
                        }
                        if ((i == 1 && (j >= 2 && j <= 7)) || (i == 2 && (j == 1 || j == 2 || j == 6)) || (i == 3 && (j == 1 || j == 4 || j == 6)) || (i == 4 && (j >= 1 && j <= 7)))
                        {
                            Mapa9[i, j] = ' ';
                        }
                    }
                }
                for (int i = 0; i < Mapa9.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa9.GetLength(1); j++)
                    {
                        Grava.Write(Mapa9[i, j] + " ");
                    }
                    Grava.WriteLine();
                }
            }
            using (StreamWriter Grava = new StreamWriter($"mapa10.txt"))
            {
                char[,] Mapa10 = new char[10, 11];
                for (int i = 0; i < Mapa10.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa10.GetLength(1); j++)
                    {
                        Mapa10[i, j] = 'X';
                    }
                }
                for (int i = 0; i < Mapa10.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa10.GetLength(1); j++)
                    {
                        if (i == 0 && j == 5)
                        {
                            Mapa10[i, j] = 'S';
                        }
                        if (i == 9 && j == 5)
                        {
                            Mapa10[i, j] = 'E';
                        }
                        if ((i == 1 && (j == 1 || j == 2 || j == 3 || j == 5 || j == 7 || j == 8 || j == 9)) || (i == 2 && (j == 1 || j == 5 || j == 9)) || (i == 3 && (j == 1 || j == 2 || j == 3 || j == 4 || j == 5 || j == 6 || j == 7 || j == 8 || j == 9)) || (i == 4 && (j == 1 || j == 5 || j == 9)) || (i == 5 && (j == 1 || j == 3 || j == 5 || j == 7 || j == 9)) || (i == 6 && (j == 1 || j == 3 || j == 5 || j == 6 || j == 7 || j == 9)) || (i == 7 && (j == 1 || j == 3 || j == 9)) || (i == 8 && (j == 1 || j == 2 || j == 3 || j == 5 || j == 6 || j == 7 || j == 8 || j == 9)))
                        {
                            Mapa10[i, j] = ' ';
                        }
                    }
                }
                for (int i = 0; i < Mapa10.GetLength(0); i++)
                {
                    for (int j = 0; j < Mapa10.GetLength(1); j++)
                    {
                        Grava.Write(Mapa10[i, j] + " ");
                    }
                    Grava.WriteLine();
                }
            }
        }
        public static void SelecionaMapa(int op)
        {
            switch (op)
            {
                case 1:
                    char opçao;
                    bool jogo = true;
                    char[] MovFinal = new char[] { 'B', 'D', 'D', 'D', 'B', 'B', 'E', 'E', 'B' };
                    char[] MovNPC = new char[MovFinal.Length];
                    Console.Write("Legenda : \n");
                    Console.Write("E – esquerda \nD – direita \nC - cima \nB – baixo\n");
                    Console.WriteLine();
                    while (jogo)
                    {
                        try
                        {
                            string lerMapa = File.ReadAllText($"mapa{op}.txt");
                            Console.WriteLine(lerMapa);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
                        }
                        Console.WriteLine("\nVoce começara no campo S, e precisa chegar no E.");
                        for (int i = 0; i < MovNPC.Length; i++)
                        {
                            Console.Write($"digite o {i + 1}° Movimento: ");
                            opçao = char.Parse(Console.ReadLine());
                            if (opçao != MovFinal[i])
                            {
                                Console.WriteLine("Movimento errado, digite novamente");
                                i--;
                            }
                            else
                            {
                                MovNPC[i] = opçao;
                            }

                        }
                        for (int i = 0; i < MovNPC.Length; i++)
                        {
                            if (MovNPC[i] == MovFinal[i])
                            {
                                jogo = false;
                            }
                            else
                            {
                                Console.WriteLine("Tente Novamente  :( ");
                                jogo = true;
                                break;
                            }
                        }
                    }
                    Console.WriteLine($"Parabens! Voce passou o mapa {op}.");
                    for (int i = 0; i < MovNPC.Length; i++)
                    {
                        Console.Write(MovNPC[i] + " ");
                    }
                    break;

                case 2:
                    char opçao2;
                    bool jogo2 = true;
                    char[] MovFinal2 = new char[] { 'B', 'D', 'B', 'B', 'E', 'E' };
                    char[] MovNPC2 = new char[MovFinal2.Length];
                    Console.Write("Legenda : \n");
                    Console.Write("E – esquerda \nD – direita \nC - cima \nB – baixo\n");
                    Console.WriteLine();

                    while (jogo2)
                    {
                        try
                        {
                            string lerMapa = File.ReadAllText($"mapa{op}.txt");
                            Console.WriteLine(lerMapa);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
                        }
                        Console.WriteLine("\nVoce começara no campo S, e precisa chegar no E.");
                        for (int i = 0; i < MovNPC2.Length; i++)
                        {
                            Console.Write($"digite o {i + 1}° Movimento: ");
                            opçao2 = char.Parse(Console.ReadLine());
                            if (opçao2 != MovFinal2[i])
                            {
                                Console.WriteLine("Movimento errado, digite novamente");
                                i--;
                            }
                            else
                            {
                                MovNPC2[i] = opçao2;
                            }

                        }
                        for (int i = 0; i < MovNPC2.Length; i++)
                        {
                            if (MovNPC2[i] == MovFinal2[i])
                            {
                                jogo2 = false;
                            }
                            else
                            {
                                Console.WriteLine("Tente Novamente  :( ");
                                jogo2 = true;
                                break;
                            }
                        }
                    }
                    Console.WriteLine($"Parabens! Voce passou o mapa {op}.");
                    for (int i = 0; i < MovNPC2.Length; i++)
                    {
                        Console.Write(MovNPC2[i] + " ");
                    }
                    break;
                case 3:
                    char opçao3;
                    bool jogo3 = true;
                    char[] MovFinal3 = new char[] { 'E', 'E', 'B', 'E', 'E', 'B', 'E', 'E', 'B', 'B', 'D', 'D', 'D', 'C', 'D', 'D', 'B', 'B' };
                    char[] MovNPC3 = new char[MovFinal3.Length];
                    Console.Write("Legenda : \n");
                    Console.Write("E – esquerda \nD – direita \nC - cima \nB – baixo\n");
                    Console.WriteLine();

                    while (jogo3)
                    {
                        try
                        {
                            string lerMapa = File.ReadAllText($"mapa{op}.txt");
                            Console.WriteLine(lerMapa);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
                        }
                        Console.WriteLine("\nVoce começara no campo S, e precisa chegar no E.");
                        for (int i = 0; i < MovNPC3.Length; i++)
                        {
                            Console.Write($"digite o {i + 1}° Movimento: ");
                            opçao3 = char.Parse(Console.ReadLine());
                            if (opçao3 != MovFinal3[i])
                            {
                                Console.WriteLine("Movimento errado, digite novamente");
                                i--;
                            }
                            else
                            {
                                MovNPC3[i] = opçao3;
                            }

                        }
                        for (int i = 0; i < MovNPC3.Length; i++)
                        {
                            if (MovNPC3[i] == MovFinal3[i])
                            {
                                jogo3 = false;
                            }
                            else
                            {
                                Console.WriteLine("Tente Novamente  :( ");
                                jogo3 = true;
                                break;
                            }
                        }
                    }
                    Console.WriteLine($"Parabens! Voce passou o mapa {op}.");
                    for (int i = 0; i < MovNPC3.Length; i++)
                    {
                        Console.Write(MovNPC3[i] + " ");
                    }
                    break;
                case 4:
                    char opçao4;
                    bool jogo4 = true;
                    char[] MovFinal4 = new char[] { 'B', 'D', 'D', 'B', 'B', 'E', 'E', 'E', 'B', 'B', 'E', 'E', 'E', 'B' };
                    char[] MovNPC4 = new char[MovFinal4.Length];
                    Console.Write("Legenda : \n");
                    Console.Write("E – esquerda \nD – direita \nC - cima \nB – baixo\n");
                    Console.WriteLine();

                    while (jogo4)
                    {
                        try
                        {
                            string lerMapa = File.ReadAllText($"mapa{op}.txt");
                            Console.WriteLine(lerMapa);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
                        }
                        Console.WriteLine("\nVoce começara no campo S, e precisa chegar no E.");
                        for (int i = 0; i < MovNPC4.Length; i++)
                        {
                            Console.Write($"digite o {i + 1}° Movimento: ");
                            opçao4 = char.Parse(Console.ReadLine());
                            if (opçao4 != MovFinal4[i])
                            {
                                Console.WriteLine("Movimento errado, digite novamente");
                                i--;
                            }
                            else
                            {
                                MovNPC4[i] = opçao4;
                            }
                        }
                        for (int i = 0; i < MovNPC4.Length; i++)
                        {
                            if (MovNPC4[i] == MovFinal4[i])
                            {
                                jogo4 = false;
                            }
                            else
                            {
                                Console.WriteLine("Tente Novamente  :( ");
                                jogo4 = true;
                                break;
                            }
                        }
                    }
                    Console.WriteLine($"Parabens! Voce passou o mapa {op}.");
                    for (int i = 0; i < MovNPC4.Length; i++)
                    {
                        Console.Write(MovNPC4[i] + " ");
                    }
                    break;
                case 5:
                    char opçao5;
                    bool jogo5 = true;
                    char[] MovFinal5 = new char[] { 'B', 'D', 'B', 'B', 'E', 'E', 'B', 'B', 'D', 'D', 'B' };
                    char[] MovNPC5 = new char[MovFinal5.Length];
                    Console.Write("Legenda : \n");
                    Console.Write("E – esquerda \nD – direita \nC - cima \nB – baixo\n");
                    Console.WriteLine();

                    while (jogo5)
                    {
                        try
                        {
                            string lerMapa = File.ReadAllText($"mapa{op}.txt");
                            Console.WriteLine(lerMapa);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
                        }
                        Console.WriteLine("\nVoce começara no campo S, e precisa chegar no E.");
                        for (int i = 0; i < MovNPC5.Length; i++)
                        {
                            Console.Write($"digite o {i + 1}° Movimento: ");
                            opçao5 = char.Parse(Console.ReadLine());
                            if (opçao5 != MovFinal5[i])
                            {
                                Console.WriteLine("Movimento errado, digite novamente");
                                i--;
                            }
                            else
                            {
                                MovNPC5[i] = opçao5;
                            }
                        }
                        for (int i = 0; i < MovNPC5.Length; i++)
                        {
                            if (MovNPC5[i] == MovFinal5[i])
                            {
                                jogo5 = false;
                            }
                            else
                            {
                                Console.WriteLine("Tente Novamente  :( ");
                                jogo5 = true;
                                break;
                            }
                        }
                    }
                    Console.WriteLine($"Parabens! Voce passou o mapa {op}.");
                    for (int i = 0; i < MovNPC5.Length; i++)
                    {
                        Console.Write(MovNPC5[i] + " ");
                    }
                    break;
                case 6:
                    char opçao6;
                    bool jogo6 = true;
                    char[] MovFinal6 = new char[] { 'E', 'B', 'B', 'B', 'B', 'E', 'E', 'C', 'C', 'E', 'E', 'E', 'E', 'B', 'B', 'D', 'D', 'B' };
                    char[] MovNPC6 = new char[MovFinal6.Length];
                    Console.Write("Legenda : \n");
                    Console.Write("E – esquerda \nD – direita \nC - cima \nB – baixo\n");
                    Console.WriteLine();

                    while (jogo6)
                    {
                        try
                        {
                            string lerMapa = File.ReadAllText($"mapa{op}.txt");
                            Console.WriteLine(lerMapa);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
                        }
                        Console.WriteLine("\nVoce começara no campo S, e precisa chegar no E.");
                        for (int i = 0; i < MovNPC6.Length; i++)
                        {
                            Console.Write($"digite o {i + 1}° Movimento: ");
                            opçao6 = char.Parse(Console.ReadLine());
                            if (opçao6 != MovFinal6[i])
                            {
                                Console.WriteLine("Movimento errado, digite novamente");
                                i--;
                            }
                            else
                            {
                                MovNPC6[i] = opçao6;
                            }
                        }
                        for (int i = 0; i < MovNPC6.Length; i++)
                        {
                            if (MovNPC6[i] == MovFinal6[i])
                            {
                                jogo6 = false;
                            }
                            else
                            {
                                Console.WriteLine("Tente Novamente  :( ");
                                jogo6 = true;
                                break;
                            }
                        }
                    }
                    Console.WriteLine($"Parabens! Voce passou o mapa {op}.");
                    for (int i = 0; i < MovNPC6.Length; i++)
                    {
                        Console.Write(MovNPC6[i] + " ");
                    }
                    break;
                case 7:
                    char opçao7;
                    bool jogo7 = true;
                    char[] MovFinal7 = new char[] { 'D', 'B', 'D', 'D', 'D', 'B', 'B', 'E', 'E', 'E', 'E' };
                    char[] MovNPC7 = new char[MovFinal7.Length];
                    Console.Write("Legenda : \n");
                    Console.Write("E – esquerda \nD – direita \nC - cima \nB – baixo\n");
                    Console.WriteLine();

                    while (jogo7)
                    {
                        try
                        {
                            string lerMapa = File.ReadAllText($"mapa{op}.txt");
                            Console.WriteLine(lerMapa);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
                        }
                        Console.WriteLine("\nVoce começara no campo S, e precisa chegar no E.");
                        for (int i = 0; i < MovNPC7.Length; i++)
                        {
                            Console.Write($"digite o {i + 1}° Movimento: ");
                            opçao7 = char.Parse(Console.ReadLine());
                            if (opçao7 != MovFinal7[i])
                            {
                                Console.WriteLine("Movimento errado, digite novamente");
                                i--;
                            }
                            else
                            {
                                MovNPC7[i] = opçao7;
                            }
                        }
                        for (int i = 0; i < MovNPC7.Length; i++)
                        {
                            if (MovNPC7[i] == MovFinal7[i])
                            {
                                jogo7 = false;
                            }
                            else
                            {
                                Console.WriteLine("Tente Novamente  :( ");
                                jogo7 = true;
                                break;
                            }
                        }
                    }
                    Console.WriteLine($"Parabens! Voce passou o mapa {op}.");
                    for (int i = 0; i < MovNPC7.Length; i++)
                    {
                        Console.Write(MovNPC7[i] + " ");
                    }
                    break;
                case 8:
                    char opçao8;
                    bool jogo8 = true;
                    char[] MovFinal8 = new char[] { 'D', 'B', 'D', 'D', 'C', 'D', 'C', 'C', 'E', 'E', 'E', 'C', 'C', 'D', 'D', 'D', 'D', 'D', 'D', 'D' };
                    char[] MovNPC8 = new char[MovFinal8.Length];
                    Console.Write("Legenda : \n");
                    Console.Write("E – esquerda \nD – direita \nC - cima \nB – baixo\n");
                    Console.WriteLine();

                    while (jogo8)
                    {
                        try
                        {
                            string lerMapa = File.ReadAllText($"mapa{op}.txt");
                            Console.WriteLine(lerMapa);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
                        }
                        Console.WriteLine("\nVoce começara no campo S, e precisa chegar no E.");
                        for (int i = 0; i < MovNPC8.Length; i++)
                        {
                            Console.Write($"digite o {i + 1}° Movimento: ");
                            opçao8 = char.Parse(Console.ReadLine());
                            if (opçao8 != MovFinal8[i])
                            {
                                Console.WriteLine("Movimento errado, digite novamente");
                                i--;
                            }
                            else
                            {
                                MovNPC8[i] = opçao8;
                            }
                        }
                        for (int i = 0; i < MovNPC8.Length; i++)
                        {
                            if (MovNPC8[i] == MovFinal8[i])
                            {
                                jogo8 = false;
                            }
                            else
                            {
                                Console.WriteLine("Tente Novamente  :( ");
                                jogo8 = true;
                                break;
                            }
                        }
                    }
                    Console.WriteLine($"Parabens! Voce passou o mapa {op}.");
                    for (int i = 0; i < MovNPC8.Length; i++)
                    {
                        Console.Write(MovNPC8[i] + " ");
                    }
                    break;
                case 9:
                    char opçao9;
                    bool jogo9 = true;
                    char[] MovFinal9 = new char[] { 'B', 'B', 'E', 'B', 'B', 'D', 'D', 'D', 'D', 'D', 'C', 'C', 'C', 'E', 'E', 'C' };
                    char[] MovNPC9 = new char[MovFinal9.Length];
                    Console.Write("Legenda : \n");
                    Console.Write("E – esquerda \nD – direita \nC - cima \nB – baixo\n");
                    Console.WriteLine();

                    while (jogo9)
                    {
                        try
                        {
                            string lerMapa = File.ReadAllText($"mapa{op}.txt");
                            Console.WriteLine(lerMapa);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
                        }
                        Console.WriteLine("\nVoce começara no campo S, e precisa chegar no E.");
                        for (int i = 0; i < MovNPC9.Length; i++)
                        {
                            Console.Write($"digite o {i + 1}° Movimento: ");
                            opçao9 = char.Parse(Console.ReadLine());
                            if (opçao9 != MovFinal9[i])
                            {
                                Console.WriteLine("Movimento errado, digite novamente");
                                i--;
                            }
                            else
                            {
                                MovNPC9[i] = opçao9;
                            }
                        }
                        for (int i = 0; i < MovNPC9.Length; i++)
                        {
                            if (MovNPC9[i] == MovFinal9[i])
                            {
                                jogo9 = false;
                            }
                            else
                            {
                                Console.WriteLine("Tente Novamente  :( ");
                                jogo9 = true;
                                break;
                            }
                        }
                    }
                    Console.WriteLine($"Parabens! Voce passou o mapa {op}.");
                    for (int i = 0; i < MovNPC9.Length; i++)
                    {
                        Console.Write(MovNPC9[i] + " ");
                    }
                    break;
                case 10:
                    char opçao10;
                    bool jogo10 = true;
                    char[] MovFinal10 = new char[] { 'B', 'B', 'B', 'D', 'D', 'D', 'D', 'B', 'B', 'B', 'B', 'B', 'E', 'E', 'E', 'E', 'B' };
                    char[] MovNPC10 = new char[MovFinal10.Length];
                    Console.Write("Legenda : \n");
                    Console.Write("E – esquerda \nD – direita \nC - cima \nB – baixo\n");
                    Console.WriteLine();

                    while (jogo10)
                    {
                        try
                        {
                            string lerMapa = File.ReadAllText($"mapa{op}.txt");
                            Console.WriteLine(lerMapa);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
                        }
                        Console.WriteLine("\nVoce começara no campo S, e precisa chegar no E.");
                        for (int i = 0; i < MovNPC10.Length; i++)
                        {
                            Console.Write($"digite o {i + 1}° Movimento: ");
                            opçao10 = char.Parse(Console.ReadLine());
                            if (opçao10 != MovFinal10[i])
                            {
                                Console.WriteLine("Movimento errado, digite novamente");
                                i--;
                            }
                            else
                            {
                                MovNPC10[i] = opçao10;
                            }
                        }
                        for (int i = 0; i < MovNPC10.Length; i++)
                        {
                            if (MovNPC10[i] == MovFinal10[i])
                            {
                                jogo10 = false;
                            }
                            else
                            {
                                Console.WriteLine("Tente Novamente  :( ");
                                jogo10 = true;
                                break;
                            }
                        }
                    }
                    Console.WriteLine($"Parabens! Voce passou o mapa {op}.");
                    for (int i = 0; i < MovNPC10.Length; i++)
                    {
                        Console.Write(MovNPC10[i] + " ");
                    }
                    break;
                default:
                    Console.WriteLine("Mapa invalido, digite um mapa de 1 a 10");
                    break;
            }
        }
    }
}