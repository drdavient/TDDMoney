namespace TDD_Money
{
    public struct Dollar
    {
        public int amount;
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
            
        }
    }
    
    // todo $5 +10 CHF = $10 if rate is 2:1
    // done $5 * 2 = $10
    // todo Make amount private
    // done Remove Dollar side effects
    // todo Money rounding
    // todo equals
    // todo hashcode
}