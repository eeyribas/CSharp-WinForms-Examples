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

            for (int i = 0; i <= password.Length - 1; i++)
            {
                string findResult = "";
                for (int j = 0; j <= result.Length - 1; j++)
                {
                    char ch = (char)(result[j] ^ password[i]);
                    if (ch == '0')
                        ch = password[i];
                    findResult += (char)ch;
                }
                result = findResult;
            }

            return result;
        }
    }
}
