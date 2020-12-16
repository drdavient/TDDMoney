namespace TDD_Money
{
    public class Franc
    {
        private int amount;
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(amount * multiplier);
            
        }

        public override bool Equals(object obj)
        {
            Franc Franc = (Franc) obj;
            return Franc.amount == this.amount;
        }
    }
    
    // todo $5 +10 CHF = $10 if rate is 2:1
    // done $5 * 2 = $10
    // done Make amount private
    // done Remove Franc side effects
    // todo Money rounding
    // done equals
    // todo hashcode
    // todo equal null
    // todo equal object
    // todo 5 CHF * 2 = 10 CHF 
}