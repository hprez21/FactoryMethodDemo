using FactoryMethodDemo.Business.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo.Business.Models
{
    public class Forex
    {
        private Exchange _exchange;
        public Forex(Exchange exchange)
        {
            _exchange = exchange;
        }

        public List<double> GetForecastData()
        {
            IProcessor processor = null;
            if(_exchange.Name == "BTC")
            {
                processor =
                new BitcoinProcessor(Risk.High,
                    _exchange.Volume_1day_usd);
            }
            
            else if(_exchange.Name == "ETH")
            {
                processor =
                new EthereumProcessor(Risk.Medium,
                    _exchange.Volume_1day_usd);
            }
            
            else
            {
                throw new NotImplementedException("Exchange unknown");
            }
                        
            return processor.Predict();
        }
    }
}
