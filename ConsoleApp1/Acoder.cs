using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FileManagerTwo
{
    class Acoder : ICoder
    {
        string coderUP = "АБВГДЕЖЗИКЛМНОПРСТУФХЦЧШЩЬЪЭЮЯ";
        string coderDo = "абвгдежзиклмнопрстуфхцчшщьъэюя";

        public void Encode(string encode)
        {
            char[] ch = new char[encode.Length];
            int length = coderUP.Length;


            for (int i = 0; i < ch.Length; i++)
            {

                for (int j  = 0; j < coderUP.Length; j++)
                {

                    if (encode[i] == coderUP[j])
                        if (length - 1 == j)
                            ch[i] = 'A';
                        else
                            ch[i] = coderUP[j + 1];

                    else if (encode[i] == coderDo[j])
                        if (length - 1 == j)
                            ch[i] = 'a';
                        else
                            ch[i] = coderDo[j + 1];
                    else if (encode[i] == ' ')
                        ch[i] = ' ';

                }
            }

            string result = new string(ch);

            Console.WriteLine(result);
        }

        public void Decode(string decode)
        {
            
        }
    }
}
