using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class TextBuilder:Builder
    {
        private StringBuilder buffer = new StringBuilder();

        public override void Close()
        {
            buffer.Append("====================================\n");
        }

        public override void MakeItems(string[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                buffer.Append("    ·" + items[i] + "\n");
            }
            buffer.Append("\n");
        }

        public override void MakeString(string str)
        {
            buffer.Append('■' + str + "\n");
            buffer.Append("\n");
        }

        public override void MakeTitle(string title)
        {
            buffer.Append("================================\n");
            buffer.Append("(" + title + ")");
            buffer.Append("\n");
        }
        public string GetResult()
        {
            return buffer.ToString();
        }
    }
}
