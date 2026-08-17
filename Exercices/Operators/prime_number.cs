namespace Operator;

using System;

public static class PrimeNumber
{
    /*
    Pseudo Codigo
    1 Descubra a raiz quadrada aproximada do número que você quer testar.
    2 Liste todos os números primos menores ou iguais a essa raiz quadrada.
    3 Tente dividir o número original por cada um desses primos da lista.
    4 Se o resto de alguma conta for zero, o número é composto (não é primo). Se nenhum resto for zero, o número é primo
    */

    public static double FindPrimeNumber(double Number)
    {
        if (Number <= 1)
        {
            return 0; // Numbers less than or equal to 1 are not prime
        }

        double SquareRoot = Squareroot.FindSquareRoot(Number);

        for (double PossibleDivisor = 2; PossibleDivisor <= SquareRoot; PossibleDivisor++)
        {
            if (Number % PossibleDivisor == 0)
            {
                return 0; // Number is not prime
            }
        }

        return Number; // Number is prime
    }
}