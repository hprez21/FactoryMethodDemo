using FactoryMethodDemo.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo.Business.Processors
{
    public class BitcoinProcessor : IProcessor
    {
        private float volume_1day_usd;

        public BitcoinProcessor(Risk risk, float volume_1day_usd)
        {
            this.volume_1day_usd = volume_1day_usd;
        }

        public Risk Risk { get; set; }

        public List<double> Predict()
        {
            if (Risk == Risk.High)
            {
                return new List<double>()
                {
                    287.3,
                    7782.1,
                    872.83,
                    8.2,
                    109.2,
                    76.3,
                    772.5,
                    8272.15,
                    872.33,
                    25.8
                };
            }

            else if (Risk == Risk.Medium)
            {
                return new List<double>()
                {
                    2873.2,
                    372.23,
                    892.54,
                    331.2,
                    8375.2,
                    4928.98,
                    9972.0,
                    132.6,
                    28.1,
                    923.2
                };
            }

            else
            {
                return new List<double>()
                {
                    992.2,
                    2937.3,
                    624.5,
                    55283.2,
                    7721.9,
                    193.4,
                    326.8,
                    628.1,
                    293.9,
                    618.2
                };
            }
        }
    }
}

