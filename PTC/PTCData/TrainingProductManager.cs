using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCData
{
    public class TrainingProductManager
    {
        public List<TrainingProduct> Get(TrainingProduct entity)
        {
            List<TrainingProduct> ret = new List<TrainingProduct>();
            ret = CreateMockData();
            if (!string.IsNullOrEmpty(entity.ProductName))
            {
                ret = ret.FindAll(p => p.ProductName.ToLower().StartsWith(entity.ProductName, StringComparison.CurrentCultureIgnoreCase));
            }
            return ret;
        }
        private List<TrainingProduct> CreateMockData()
        {
            List<TrainingProduct> ret = new List<TrainingProduct>();

            ret.Add(new TrainingProduct()
            {
                ProductId = 1,
                ProductName = "Extending Bootstrap with CSS, JavaScript and JQuery",
                IntroductionDate = Convert.ToDateTime("6/11/15"),
                Url = "http://bitly/lSNzc0i",
                Price = Convert.ToDecimal(29.00)
            });
            ret.Add(new TrainingProduct()
            {
                ProductId = 2,
                ProductName = "The Wonders of Ruby on Rails",
                IntroductionDate = Convert.ToDateTime("6/02/14"),
                Url = "http://bitly/lSNzc0i",
                Price = Convert.ToDecimal(19.00)
            });
            ret.Add(new TrainingProduct()
            {
                ProductId = 3,
                ProductName = ".NET isn't just for your mama ",
                IntroductionDate = Convert.ToDateTime("6/11/17"),
                Url = "http://bitly/lSNzc0i",
                Price = Convert.ToDecimal(129.00)
            });
            ret.Add(new TrainingProduct()
            {
                ProductId = 4,
                ProductName = "React and Redux is how you get a job",
                IntroductionDate = Convert.ToDateTime("2/11/18"),
                Url = "http://bitly/lSNzc0i",
                Price = Convert.ToDecimal(229.00)
            });
            ret.Add(new TrainingProduct()
            {
                ProductId = 5,
                ProductName = "CS 101",
                IntroductionDate = Convert.ToDateTime("6/10/11"),
                Url = "http://bitly/lSNzc0i",
                Price = Convert.ToDecimal(9.00)
            });

            return ret;
        }
    }
}
