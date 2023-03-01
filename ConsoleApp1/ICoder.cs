using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FileManagerTwo
{
    internal interface ICoder
    {

        string Encode(string encode);
        string Decode(string decode);
    }
}
