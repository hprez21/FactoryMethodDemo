using FactoryMethodDemo.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo.Business.Processors
{
    public interface IProcessor
    {
        List<double> Predict();
        Risk Risk { get; set; }
    }
}
