using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo.Business.Models
{
    public enum Risk
    {
        High,
        Medium,
        Low
    }

    public class RiskModel
    {
        public Risk Risk { get; set; }
    }
}
