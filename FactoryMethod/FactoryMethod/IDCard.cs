using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;
using System.Threading.Tasks;

namespace IDCard
{
    public class IDCard : Product
    {
        private string owner;
        public IDCard(string owner)
        {
            Console.WriteLine("制作"+owner+"的ID卡。");
            this.owner = owner;
        }
        public override void Use()
        {
            Console.WriteLine("制作" + owner + "的ID卡。");
        }
        public string Owner
        {
            get
            {
                return owner;
            }
        }
    }
}
