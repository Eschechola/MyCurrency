namespace MyCurrency.Data.Entities
{
    public class Currency
    {
        public string Name { get; set; }
        public decimal QuoteInReais { get; set; }
        public decimal AmountOfReais { get; set; }

        public Currency(decimal quoteInReais)
        {
            Name = string.Empty;
            QuoteInReais = quoteInReais;
            AmountOfReais = 1;
        }

        public Currency(string name, decimal quoteInReais)
        {
            Name = name;
            QuoteInReais = quoteInReais;
            AmountOfReais = 1;
        }
    }
}
