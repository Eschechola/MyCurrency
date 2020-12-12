using MyCurrency.Data.Enum;

namespace MyCurrency.Data.Entities
{
    public class Quotation
    {
        public Currency Dollar { get; private set; }
        public Currency Euro { get; private set; }
        public Currency PoundSterling { get; private set; }
        public Currency Yen { get; private set; }
        public Currency SwissFranc { get; private set; }
        public Currency ArgentinianPeso { get; private set; }
        public Currency Bitcoin { get; private set; }

        public Quotation()
        {}

        public void SetQuotation(CurrencyType currencyType, decimal quoteInReais)
        {
            switch (currencyType)
            {
                case CurrencyType.Dollar:
                    Dollar = new Currency("Dólar", quoteInReais);
                    break;

                case CurrencyType.Euro:
                    Euro = new Currency("Euro", quoteInReais);
                    break;

                case CurrencyType.PoundSterling:
                    PoundSterling = new Currency("Libra Esterlina", quoteInReais);
                    break;

                case CurrencyType.Yen:
                    Yen = new Currency("Iene", quoteInReais);
                    break;

                case CurrencyType.SwissFranc:
                    SwissFranc = new Currency("Franco Suiço", quoteInReais);
                    break;

                case CurrencyType.ArgentinianPeso:
                    ArgentinianPeso = new Currency("Peso Argentino", quoteInReais);
                    break;

                case CurrencyType.Bitcoin:
                    Bitcoin = new Currency("Bitcoin", quoteInReais);
                    break;
            }
        }
    }
}
