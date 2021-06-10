using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public interface Print
    {
        void PrintWeak();
        void PrintStrong();
    }
}
