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
            EventCommand = "List";
        }
        public string EventCommand { get; set; }
        public List<TrainingProduct> Products { get; set; }
        public void HandleRequest()
        {
            switch(EventCommand.ToLower())
            {
                case "list":
                    Get();
                    break;

                default:
                    break;
            }
        }
        private void Get()
        {
            TrainingProductManager mgr = new TrainingProductManager();
            Products = mgr.Get();
        }
    }
}
