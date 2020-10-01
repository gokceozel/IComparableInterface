using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Customer : IComparable
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int OrderCount { get; set; }
       



        public override string ToString()
        {
            return string.Format("{0}-{1}-Order Count {2}", this.CustomerId.ToString(), this.Name, this.OrderCount.ToString());
        }

        public int CompareTo(object obj)
        {
            Customer customerToCompare = (Customer)obj;

            #region Artan sıralama

            if (this.OrderCount > customerToCompare.OrderCount)
                return 1;
            else
                return -1;
            #endregion

            #region Azalan sıralama
            //if (this.OrderCount > customerToCompare.OrderCount)
            //    return  -1;
            //else
            //    return  1;
            #endregion
        }
    }
}
