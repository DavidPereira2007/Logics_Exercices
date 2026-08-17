namespace Operator;

using System;

public static class Squareroot
{
    /*
    PseudoCodigo
    a raiz quadrada de um número é aquele numero que multiplicado 2 vezes da esse numero exemplo a raiz de 9 é 3 porque 3 x 3 é 9
    1. número que quero saber
    2. Listar todos os numero menores que esse número
    3. Multiplique o número da lista por ele mesmo e verifique se é igual ao número principal
    4. Se for achou a raiz quadrada, se não continue a lista
    */

    public static double FindSquareRoot(double Number)
    {
        double Step = 0.0001;
        double Tolerance = 0.001;

        for (double PossibleRoot = 1; PossibleRoot < Number; PossibleRoot += Step)
        {
            if (Math.Abs(PossibleRoot * PossibleRoot - Number) < Tolerance)
            {
                return PossibleRoot;
            }
        }

        return 0;
    }
}