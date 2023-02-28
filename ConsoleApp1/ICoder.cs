using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FileManagerTwo
{
    internal interface ICoder
    {

        void Encode(string encode);
        void Decode(string decode);
    }
}
