////////////////////////////////////////
/// by: David de Sousa Pereira 18/08/2026
/// Code: Roman Numeral converter system
////////////////////////////////////////

namespace Operator;

using System;

/*
Regras de funcionamento 

Soma (Direita): Quando uma letra de valor menor ou igual vem à direita de outra maior, 
os valores são somados (exemplo: VI = 5 + 1 = 6).


Subtração (Esquerda): Quando uma letra de valor menor vem à esquerda de uma maior, 
o valor menor é subtraído da maior (exemplo: IV = 5 - 1 = 4; IX = 10 - 1 = 9).

Limite de Repetição: Os símbolos I, X, C e M podem repetir no máximo três vezes seguidas (exemplo: III = 3, XXX = 30). 
Os símbolos V, L e D nunca se repetem

*/


public static class RomanNumeral
{

    static int Repeatingsymbols = 0;
    static int SymbolsOrder = 0;
    static char LastSymbol = 'A';

    static Dictionary<char, int> Symbols = new Dictionary<char, int>()
    {
      {'I', 1},
      {'V', 5},
      {'X', 10},
      {'L', 50},
      {'C', 100},
      {'D', 500},
      {'M', 1000}  
    };

    static List<char> RepeatingsymbolsList = ['I', 'X', 'C', 'M'];

    private static string ValidateRomanNumeral(char c, char LastSymbol, ref int Repeatingsymbols, int SymbolsOrder)
    {
        // Verifica se o simbolo é um numeral romano valido
        if (!Symbols.ContainsKey(c))
            {
                return "Numeral roman is invalid!";
            }

            // verificar limite de repetição
            if (c == LastSymbol)
            {
                // Verificar se esse simbolo pode ser repetido
                if (RepeatingsymbolsList.Contains(c))
                {
                    Repeatingsymbols += 1;
                }
                else
                {
                    return "Numeral Roman is invalid: Symbols that cannot be repeated were repeated.";
                }
                
            }
            else
            {
                // Verifica se é um simbolo que pode ser repetido e se está no primeiro simbolo
                if (RepeatingsymbolsList.Contains(c) && SymbolsOrder == 1)
                {
                    Repeatingsymbols += 1;
                }

                if (SymbolsOrder > 1)
                {
                    Repeatingsymbols = 0;
                }

            }

            // Bloquear se repetição passar do limite
            if (Repeatingsymbols > 3)
            {
                return "Numeral Roman is invalid: Exceeded the limit of repeatable symbols.";
            }

            // Verifica Subtração
            if (SymbolsOrder > 1)
            {
                
                switch (LastSymbol)
                {
                    case 'I': // Validação para casos de I
                        if (c != 'V' & c != 'X' & c != 'I')
                        {
                            // Considero numero inválido
                            return $"Numeral Roman is invalid: I can only be subtracted from X and V. | DEBUG: Ultimo simbolo: {LastSymbol} , simbolo atual: {c}";
                        }
                        break;
                    case 'X': // Validação para casos de X
                        if (c != 'L' & c != 'C' & c != 'X')
                        {
                            // Considero numero inválido
                            return $"Numeral Roman is invalid: X can only be subtracted from L and C | DEBUG: Ultimo simbolo: {LastSymbol} , simbolo atual: {c}";
                        }
                        break;
                    case 'C': // Validação para casos de C
                        if (c != 'D' & c != 'M' & c != 'C')
                        {
                            // Considero numero inválido
                            return $"Numeral Roman is invalid: C can only be subtracted from D and M | DEBUG: Ultimo simbolo: {LastSymbol} , simbolo atual: {c}";
                        }
                        break;
                    default: // Validação para casos de V, L  e D
                        return $"Numeral Roman is invalid: V, L and D They cannot be used for subtraction. | DEBUG: Ultimo simbolo: {LastSymbol} , simbolo atual: {c}";
                }
            }

            return "Right";
    }

    public static string ConvertoNumeralRoman(string RomanNumber)
    {
       
        // Vou validar se todos os caracteres são algarismos romanos
        foreach (char c in RomanNumber)
        {
            SymbolsOrder += 1;
            string action = ValidateRomanNumeral(c, LastSymbol, ref Repeatingsymbols, SymbolsOrder);

            LastSymbol = c; // Update do ultimo com o atraso correto para funcionar na função
            if (action == "Right")
            {
                // Verificar se realizo soma ou subtração e fazer o mesmo
                
            }
            else
            {
                return action;
            }
        }

        
        return RomanNumber;

        
    }
}