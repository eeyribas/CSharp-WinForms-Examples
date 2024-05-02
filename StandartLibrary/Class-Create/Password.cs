using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Create
{
    public class Password
    {
        public Password()
        {
            password = "123";
            text = "Text";
        }

        public Password(string tmpPassword, string tmpText)
        {
            password = tmpPassword;
            text = tmpText;
        }

        private string password;
        public string Passwd
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        private string text;
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }

        public string Encrypt()
        {
            return (SolvedEncrypt());
        }

        public string Solve()
        {
            return (SolvedEncrypt());
        }

        private string SolvedEncrypt()
        {
            string result = text;

            for (int j = 0; j <= password.Length - 1; j++)
            {
                string findResult = "";
                for (int i = 0; i <= result.Length - 1; i++)
                {
                    char ch = (char)(result[i] ^ password[j]);
                    if (ch == '0')
                        ch = password[j];
                    findResult += (char)ch;
                }
                result = findResult;
            }

            return result;
        }
    }
}
