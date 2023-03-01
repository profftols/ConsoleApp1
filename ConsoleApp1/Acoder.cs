using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FileManagerTwo
{
    class Acoder : ICoder
    {
        private string coderUP = "АБВГДЕЖЗИКЛМНОПРСТУФХЦЧШЩЬЪЭЮЯ";
        private string coderDo = "абвгдежзиклмнопрстуфхцчшщьъэюя";

        public string Encode(string encode)
        {
            char[] ch = new char[encode.Length];
            int length = coderUP.Length;


            for (int i = 0; i < ch.Length; i++)
            {

                for (int j = 0; j < coderUP.Length; j++)
                {

                    if (encode[i] == coderUP[j])
                        if (length - 1 == j)
                            ch[i] = 'А';
                        else
                            ch[i] = coderUP[j + 1];

                    else if (encode[i] == coderDo[j])
                        if (length - 1 == j)
                            ch[i] = 'а';
                        else
                            ch[i] = coderDo[j + 1];

                    else if (encode[i] == ' ')
                        ch[i] = ' ';

                }
            }

            string result = new string(ch);

            return result;

        }

        public string Decode(string decode)
        {
            char[] ch = new char[decode.Length];

            for (int i = 0; i < ch.Length; i++)
            {
                for (int j = 0; j < coderUP.Length; j++)
                {

                    if (decode[i] == coderUP[j])
                        if (0 == j)
                            ch[i] = 'Я';
                        else
                            ch[i] = coderUP[j - 1];

                    else if (decode[i] == coderDo[j])
                        if (0 == j)
                            ch[i] = 'я';
                        else
                            ch[i] = coderDo[j - 1];

                    else if (decode[i] == ' ')
                        ch[i] = ' ';
                }
            }

            string result = new string(ch);

            return result;
        }
    }
}
