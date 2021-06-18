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
        protected override Product CreateProduct(string owner)
        {
            return new IDCard(owner);
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
