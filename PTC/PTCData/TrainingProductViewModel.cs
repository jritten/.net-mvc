using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCData
{
    public class TrainingProductViewModel
    {
        public TrainingProductViewModel()
        {
            Products = new List<TrainingProduct>();
        }
        public List<TrainingProduct> Products { get; set; }
        public void Get()
        {
            TrainingProductManager mgr = new TrainingProductManager();
            Products = mgr.Get();
        }
    }
}
