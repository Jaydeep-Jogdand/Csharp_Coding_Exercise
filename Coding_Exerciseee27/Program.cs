namespace Coding_Exerciseee27
{
    public delegate void StockPriceChangedHandler(string message);

    public class Stock
    {

        public event StockPriceChangedHandler OnStockPriceChanged;

        private decimal _price;
        private decimal _threshold;


        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;
                if (_price < Threshold)
                {
                    RaiseStockPriceChangedEvent("Stock price is below threshold!");
                }
            }
        }


        public decimal Threshold
        {
            get { return _threshold; }
            set { _threshold = value; }
        }


        protected virtual void RaiseStockPriceChangedEvent(string message)
        {

            OnStockPriceChanged?.Invoke(message);
        }
    }
    public class StockAlert
    {

        public void OnStockPriceChanged(string message)
        {
            Console.WriteLine("Stock Alert: " + message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            StockAlert alert = new StockAlert();


            stock.OnStockPriceChanged += alert.OnStockPriceChanged;


            stock.Threshold = 120m;


            stock.Price = 130m;
            stock.Price = 110m;


            Console.ReadKey();
        }
    }
}
