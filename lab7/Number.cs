using System;
using System.Text.RegularExpressions;

namespace Fraction
{
    public class Number : ICloneable, IComparable<Number>, IFormattable, IConvertible
    {
        private long num, den;

        public long Num { get => num; set => SetNum(value); }
        public long Den { get => den; set => SetDen(value); }

        public Number()
        {
        }

        public Number(long num)
        {
            Num = num;
            Den = 1;
        }

        public Number(long num, long den)
        {
            Num = num;
            Den = den;
        }

        public Number(double x)
        {
            Number number = GetFraction(x.ToString());
            Num = number.num;
            Den = number.den;
            Simplify();
        }

        public void SetNum(long NewNum)
        {
            num = NewNum;
            if (num != 0 && den != 0)
            {
                Simplify();
            }
        }

        public void SetDen(long NewDen)
        {
            if (NewDen == 0)
            {
                throw new ArgumentException("Denominator can't be equal to zero.");
            }
            else if (NewDen < 0)
            {
                throw new ArgumentException("Denominator must be a natural number.");
            }
            den = NewDen;
            if (num != 0)
            {
                Simplify();
            }
        }

        private double GetDouble() => (double)num / den;

        private static long Gcd(long a, long b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            return a + b;
        }
        private void Simplify()
        {
            long gcd = Gcd(Math.Abs(num), den);
            num /= gcd;
            den /= gcd;
        }

        public static Number GetFraction(string s)
        {
            if (TryParse(s, out Number fraction))
            {
                return fraction;
            }
            else
            {
                throw new FormatException("Unsupported input string format.");
            }
        }
        public static bool TryParse(string s, out Number number)
        {
            number = null;

            Regex firstPattern = new Regex(@"^(-?\d+)/(\d+)$");
            Regex secondPattern = new Regex(@"^(-?\d+)\((\d+)/(\d+)\)$");
            Regex thirdPattern = new Regex(@"^(-?\d+)[,\.](\d+)$");
            Regex fourthPattern = new Regex(@"^(-?\d+)$");

            if (firstPattern.IsMatch(s))
            {
                Match match = firstPattern.Match(s);
                long num = long.Parse(match.Groups[1].Value);
                long den = long.Parse(match.Groups[2].Value);
                number = new Number(num, den);
                return true;
            }
            else if (secondPattern.IsMatch(s))
            {
                Match match = secondPattern.Match(s);
                long integer = long.Parse(match.Groups[1].Value);
                long num = long.Parse(match.Groups[2].Value);
                long den = long.Parse(match.Groups[3].Value);
                int sign = integer >= 0 ? 1 : -1;
                number = new Number(sign * (Math.Abs(integer) * den + num), den);
                return true;
            }
            else if (thirdPattern.IsMatch(s))
            {
                Match match = thirdPattern.Match(s);
                long integer = long.Parse(match.Groups[1].Value);
                int sign = integer >= 0 ? 1 : -1;
                string dec = match.Groups[2].Value;
                long den = (long)Math.Pow(10, dec.Length);
                long num = (Math.Abs(integer) * den + long.Parse(dec)) * sign;
                number = new Number(num, den);
                return true;
            }
            else if (fourthPattern.IsMatch(s))
            {
                Match match = fourthPattern.Match(s);
                number = new Number(long.Parse(match.Groups[1].Value));
                return true;
            }
            return false;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
            {
                return false;
            }
            return CompareTo((Number)obj) == 0;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(num, den);
        }
        public override string ToString() => ToString("S");
        public object Clone()
        {
            return new Number(num, den);
        }

        public int CompareTo(Number number)
        {
            long lcm = den * number.den / Gcd(Math.Abs(den), number.den);
            long num1 = num * (lcm / den);
            long num2 = number.num * (lcm / number.den);
            return num1.CompareTo(num2);
        }

        public string ToString(string format) => ToString(format, null);
        //S - standart, M - mixed fraction, D - double, I - integer
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format))
            {
                format = "S";
            }

            if (format == "S")
            {
                return $"{num}/{den}";
            }
            else if (format == "M")
            {
                if (Math.Abs(num) > den && den != 1)
                {
                    long integer = num / den;
                    return $"{integer}({Math.Abs(num) % den}/{den})";
                }
                else
                {
                    return ToString("I");
                }
            }
            else if (format == "D")
            {
                return GetDouble().ToString();
            }
            else if (format == "I")
            {
                if (Math.Abs(num) > den)
                {
                    long integer = num / den;
                    return integer.ToString();
                }
                else
                {
                    return ToString("S");
                }
            }
            else
            {
                throw new FormatException($"The \"{format}\" format is not supported.");
            }
        }

        public TypeCode GetTypeCode()
            => TypeCode.Object;

        public bool ToBoolean(IFormatProvider provider) => num != 0;
        public byte ToByte(IFormatProvider provider)
            => Convert.ToByte(GetDouble(), provider);
        public char ToChar(IFormatProvider provider)
            => Convert.ToChar(GetDouble(), provider);
        public DateTime ToDateTime(IFormatProvider provider)
            => Convert.ToDateTime(GetDouble(), provider);
        public decimal ToDecimal(IFormatProvider provider)
            => Convert.ToDecimal(GetDouble(), provider);
        public double ToDouble(IFormatProvider provider)
            => GetDouble();
        public short ToInt16(IFormatProvider provider)
            => Convert.ToInt16(GetDouble(), provider);
        public int ToInt32(IFormatProvider provider)
            => Convert.ToInt32(GetDouble(), provider);
        public long ToInt64(IFormatProvider provider)
            => Convert.ToInt64(GetDouble(), provider);
        public SByte ToSByte(IFormatProvider provider)
            => Convert.ToSByte(GetDouble(), provider);
        public float ToSingle(IFormatProvider provider)
            => Convert.ToSingle(GetDouble(), provider);
        public string ToString(IFormatProvider provider)
            => ToString("S", provider);
        public object ToType(Type conversionType, IFormatProvider provider)
            => Convert.ChangeType(GetDouble(), conversionType);
        public UInt16 ToUInt16(IFormatProvider provider)
            => Convert.ToUInt16(GetDouble(), provider);
        public UInt32 ToUInt32(IFormatProvider provider)
            => Convert.ToUInt32(GetDouble(), provider);
        public UInt64 ToUInt64(IFormatProvider provider)
            => Convert.ToUInt64(GetDouble(), provider);

        public static explicit operator sbyte(Number x)
            => x.ToSByte(null);
        public static explicit operator short(Number x)
            => x.ToInt16(null);
        public static explicit operator int(Number x)
            => x.ToInt32(null);
        public static explicit operator long(Number x)
            => x.ToInt64(null);
        public static explicit operator float(Number x)
            => x.ToSingle(null);
        public static explicit operator double(Number x)
            => x.ToDouble(null);
        public static explicit operator decimal(Number x)
            => x.ToDecimal(null);

        public static Number operator +(Number x) => x;
        public static Number operator -(Number x) => new Number(-x.num, x.den);
        public static Number operator +(Number a, Number b)
            => new Number(a.num * b.den + b.num * a.den, a.den * b.den);
        public static Number operator -(Number a, Number b)
            => a + (-b);
        public static Number operator *(Number a, Number b)
            => new Number(a.num * b.num, a.den * b.den);
        public static Number operator *(Number a, long b)
            => new Number(a.num * b, a.den);
        public static Number operator /(Number a, Number b)
        {
            if (b.num == 0)
            {
                throw new DivideByZeroException();
            }
            return new Number(a.num * b.den, a.den * b.num);
        }
        public static Number operator /(Number a, long b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return new Number(a.num, a.den * b);
        }

        public static bool operator ==(Number a, Number b) => a.CompareTo(b) == 0;
        public static bool operator !=(Number a, Number b) => a.CompareTo(b) != 0;
        public static bool operator >(Number a, Number b) => a.CompareTo(b) == 1;
        public static bool operator <(Number a, Number b) => a.CompareTo(b) == -1;
        public static bool operator >=(Number a, Number b) => a.CompareTo(b) != -1;
        public static bool operator <=(Number a, Number b) => a.CompareTo(b) != 1;
    }
}