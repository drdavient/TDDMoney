namespace TDD_Money
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency) : base(amount, currency)
        {
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
    // done common times
    // done common times
    // done compare francs with dollars
    // done currency?
    // todo Delete TestFrancMultiplication?
}