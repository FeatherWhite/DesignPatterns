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
        /// <summary>
        /// 主人
        /// </summary>
        private string owner;
        /// <summary>
        /// 编号
        /// </summary>
        private int numbered;
        public IDCard(string owner,int numbered)
        {
            Console.WriteLine("制作" + owner + "的ID卡。");
            this.owner = owner;
            this.numbered = numbered;
        }
        public override void Use()
        {
            Console.WriteLine("使用" + owner + "的ID卡。");
        }
        /// <summary>
        /// 主人
        /// </summary>
        public string Owner
        {
            get
            {
                return owner;
            }
        }

        /// <summary>
        /// 编号
        /// </summary>
        public int Numbered
        {
            get 
            { 
                return numbered; 
            }
        }

    }
}
