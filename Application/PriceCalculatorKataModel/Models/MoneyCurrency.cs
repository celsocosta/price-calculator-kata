using System;
using System.Diagnostics.CodeAnalysis;

namespace PriceCalculatorKataModel.Models
{
    public class MoneyCurrency : IEquatable<MoneyCurrency>
    {
        public MoneyCurrency(decimal value)
        {
            this.Value = value;
            this.Currency = "$";
        }

        public decimal Value { get; }

        public string Currency { get; }


        public override bool Equals(object other)
        {
            return Equals(other as MoneyCurrency);
        }

        public bool Equals([AllowNull] MoneyCurrency other)
        {
            return other != null && Value == other.Value && Currency == other.Currency;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value, Currency);
        }

        public static MoneyCurrency operator +(MoneyCurrency a, MoneyCurrency b) => new MoneyCurrency(a.Value * b.Value);

        public static MoneyCurrency operator *(MoneyCurrency a, decimal b) => new MoneyCurrency(a.Value * b);
    }
}
