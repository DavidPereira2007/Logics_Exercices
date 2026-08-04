////////////////////////////////////////
/// by: David de Sousa Pereira 04/08/2026
/// Code: Service Application
////////////////////////////////////////


namespace Universal_converter;
using System;

public static class ConverterService
{
    public static double CelsiusToFahrenheit(double celsius)
    {
        // Formule for conversion - (0 °C × 9/5) + 32 = 32 °F
        return (celsius * 9 / 5) + 32;
    }

    public static decimal KilometerToMile(decimal kilometers)
    {
        // Formule for conversion - kilometer * 0.621371
        return kilometers * 0.621371m;
    }

    public static int HoursToMinutes(int hours)
    {
        // Formule for conversion - hours * 60
        return hours * 60;
    }

    public static double RealToDollar(double reais, double exchangeRate)
    {
        // Formule for conversion - reais / exchangeRate, exchangeRate actual is 5.09
        return reais / exchangeRate;
    }
}