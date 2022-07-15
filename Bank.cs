using System;
using System.Collections.Generic;

namespace TDD_Money
{
    public class Bank
    {
        private Dictionary<CurrencyPair,int> rates;
        

        public Bank()
        {
            rates = new Dictionary<CurrencyPair, int> ();
        }

        public void AddRate(string from, string to, int rate)
        {
            rates.Add(new CurrencyPair(from,to),rate);
        }
        public int Rate(string fromCurrency, string toCurrency)
        {
            if(rates.TryGetValue(new CurrencyPair(fromCurrency, toCurrency), out int rate)) 
                return rate;

            return 1;
        }
        
        public Money Reduce(Expression source, String toCurrency)
        {
            return source.Reduce(this, toCurrency);
        }

        private class CurrencyPair
        {
            private bool Equals(CurrencyPair other)
            {
                return _from == other._from && _to == other._to;
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != this.GetType()) return false;
                return Equals((CurrencyPair)obj);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    return ((_from != null ? _from.GetHashCode() : 0) * 397) ^ (_to != null ? _to.GetHashCode() : 0);
                }
            }

            private readonly string _from;
            private readonly string _to;

            public CurrencyPair(string from, string to)
            {
                _from = from;
                _to = to;
            }
        
        
        }
    }
}