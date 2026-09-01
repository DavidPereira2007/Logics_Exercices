////////////////////////////////////////
/// by: David de Sousa Pereira 01/09/2026
/// Code: Find MMC system
////////////////////////////////////////

namespace Operator;

using System;

public static class MMC
{
    private static int[] Tabuada(int Number)
    {
        int[] Tabuada = new int[10];

        for (int i = 1; i <= 10; i++)
        {
            Tabuada[i - 1] = Number * i;
        }

        return Tabuada;
    }

    public static int FindMMC(int Number1, int Number2)
    {
        // Pegar a tabuada dos dois números
        int[] Tabuada1 = Tabuada(Number1);
        int[] Tabuada2 = Tabuada(Number2);

        int[] RepeatedNumbers = new int[10];

        // Achar os números que se repetem na tabuada dos dois números
        foreach (int number in Tabuada1)
        {
            if (Array.Exists(Tabuada2, element => element == number))
            {
                RepeatedNumbers[Array.IndexOf(Tabuada1, number)] = number;
            }
        }

        // Pegar o menor número que se repete na tabuada dos dois números
        int mmc = int.MaxValue;
        foreach (int number in RepeatedNumbers)
        {
            if (number != 0 && number < mmc)
            {
                mmc = number;
            }
        }

        return mmc;
    }

    public static double FindComplexMMC(int[] numbers) // Refatorar código para aceitar mais de 2 números e encontrar o MMC entre eles
    {
        // Preciso usar um método mais otimizado para resolver o problema, pois o método atual é muito ineficiente para encontrar o MMC de mais de 2 números.


        int[][] tabuadas = new int[numbers.Length][];
        int[] repeatedNumbers = new int[numbers.Length];

        // Pegar a tabuada de todos os números
        for (int i = 0; i < numbers.Length; i++)
        {
            tabuadas[i] = Tabuada(numbers[i]);
        }

        // Achar os números que se repetem na tabuada de todos os números
        foreach (int number in tabuadas[0])
        {
            bool isRepeated = true;

            for (int i = 1; i < tabuadas.Length; i++)
            {
                if (!Array.Exists(tabuadas[i], element => element == number))
                {
                    isRepeated = false;
                    break;
                }
            }

            if (isRepeated)
            {
                repeatedNumbers[Array.IndexOf(tabuadas[0], number)] = number;
            }
        }

        // Pegar o menor número que se repete na tabuada dos dois números
        int mmc = int.MaxValue;
        foreach (int number in repeatedNumbers)
        {
            if (number != 0 && number < mmc)
            {
                mmc = number;
            }
        }



        return (double)mmc;
    }
}