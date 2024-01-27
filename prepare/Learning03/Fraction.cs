using System.Globalization;

public class Fraction
{
    private int _numerator;
    private int _denominator;
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
        
    }

    public Fraction(int numerator, int denominator)
    {
         _numerator = numerator;
         _denominator = denominator;
    }

    public int GetNum()
    {
        int num = _numerator;
        return num;
    }

    public void SetNum(int num)
    {
        _numerator = num;
    }

    public int GetDeno()
    {
        int deno = _denominator;
        return deno;
    }

    public void SetDeno(int deno)
    {
        _denominator = deno;
    }
    public string GetFractionString()
    {
        string num = GetNum().ToString();
        string deno = GetDeno().ToString();
        string fractionString = $"{num}/{deno}";
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double num = GetNum();
        double deno = GetDeno();
        double decimalValue = num / deno;
        return decimalValue;
    }
}
