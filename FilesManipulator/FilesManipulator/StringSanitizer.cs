using System;
using System.Collections.Generic;
using System.Text;

namespace FilesManipulator
{
    public class StringSanitizer
    {
        public string GetFirstAlphabetIndex(string str, int len)
        {
            int j, index = 0;


            for (j = 0; j < len; j++)
            {
                if ((str[j] >= '0' && str[j] <= '9') || str[j] == '.')
                {
                    index = j;
                }
                else
                {
                    index++;
                    break;
                }
            }

            return str.Remove(0, index);
        }
    }
}
