using System;
using System.Collections.Generic;
using System.Text;

namespace FileManagerTwo
{
    internal class Bcoder : ICoder
    {
        public string alf = "АБВГДЕЖЗИКЛМНОПРСТУФХЦЧШЩЬЪЭЮЯ";

        public string Encode(string encode)
        {
            return encode;
        }

        public string Decode(string decode)
        {
            return decode;
        }
    }
}
