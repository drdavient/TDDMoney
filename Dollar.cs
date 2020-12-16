﻿namespace TDD_Money
{
    public class Dollar
    {
        private int amount;
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
            
        }

        public override bool Equals(object obj)
        {
            Dollar dollar = (Dollar) obj;
            return dollar.amount == this.amount;
        }
    }
    
    // todo $5 +10 CHF = $10 if rate is 2:1
    // done $5 * 2 = $10
    // done Make amount private
    // done Remove Dollar side effects
    // todo Money rounding
    // done equals
    // todo hashcode
    // todo equal null
    // todo equal object
    // done 5 CHF * 2 = 10 CHF 
    // todo dollar/franc duplication
    // todo common times
}