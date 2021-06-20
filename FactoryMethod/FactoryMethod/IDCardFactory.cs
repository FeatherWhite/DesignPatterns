using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Threading.Tasks;
using System.Collections;

namespace IDCard
{
    public class IDCardFactory : Factory
    {
        private ArrayList owners = new ArrayList();
        /// <summary>
        /// 制造的产品个数
        /// </summary>
        private int count = 0;
        protected override Product CreateProduct(string owner)
        {
            //编号
            int numbered = count++;
            return new IDCard(owner,numbered);
            
        }

        protected override void RegisterProduct(Product product)
        {
            owners.Add(((IDCard)product).Owner);
        }
        public ArrayList Owners
        {
            get
            {
                return owners;
            }
        }
    }
}
