using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Caesar
{
    class Program
    {
        [DllImport("kernel32.dll")]
        static extern bool SetConsoleOutputCP(uint wCodePageID);  // support 
        static char[] SpecialChar = 
        { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
        '`', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '+', '=',
        '{', '[', '}', ']', '\\', '|', ':', ';', '"', '\'',
        '<', '>', '?', ',', '.', '/',
        'á', 'à', 'ả', 'ã', 'ạ',
        'Á', 'À', 'Ả', 'Ã', 'Ạ',
            'í', 'ì', 'ỉ', 'ĩ', 'ị', 
            'Í', 'Ì', 'Ỉ', 'Ĩ', 'Ị', 
        'ó', 'ò', 'ỏ', 'õ', 'ọ', 
        'Ó', 'Ò', 'Ỏ', 'Õ', 'Ọ',
           'ú', 'ù', 'ủ', 'ũ', 'ụ', 
           'Ú', 'Ù', 'Ủ', 'Ũ', 'Ụ',
        'é', 'è', 'ẻ', 'ẽ', 'ẹ', 
        'É', 'È', 'Ẻ', 'Ẽ', 'Ẹ',
            'ă','ắ', 'ặ', 'ẳ', 'ẵ', 'ằ', 
            'Ă','Ắ', 'Ặ', 'Ẳ', 'Ẵ', 'Ằ',
        'â', 'ấ', 'ậ', 
        'Â', 'Ấ', 'Ậ',
            'ế', 'ề', 'ê', 'ể', 'ễ', 'ệ',
            'Ế', 'Ề', 'Ê', 'Ể', 'Ễ', 'Ệ',
        'ơ', 'ớ', 'ờ', 'ở', 'ỡ','ợ', 
        'Ơ', 'Ớ', 'Ờ', 'Ở', 'Ỡ', 'Ợ',
           'ô', 'ố', 'ồ', 'ổ', 'ỗ', 'ộ', 
           'Ô', 'Ố', 'Ồ', 'Ổ', 'Ỗ', 'Ộ',
        'ư', 'ứ', 'ừ', 'ử', 'ữ', 'ự', 
        'Ư', 'Ứ', 'Ừ', 'Ử', 'Ữ', 'Ự', 'đ', 'Đ'};
        public static string Encrypt(string text, int s)
        {
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (SpecialChar.Contains(text[i]))
                {
                    char ch = SpecialChar[(Array.IndexOf(SpecialChar, text[i]) + s) % SpecialChar.Length];
                    result += ch;
                }
                else if (char.IsUpper(text[i]))
                {
                    char ch = (char)((int)(text[i] + s - 65) % 26 + 65);
                    result += ch;
                }
                else if (char.IsLower(text[i]))
                {
                    char ch = (char)((int)(text[i] + s - 97) % 26 + 97);
                    result += ch;
                }
                else
                {
                    char ch = text[i];
                    result += ch;
                }
            }
            return result;
        }
        public static string Decrypt(string text, int s)
        {
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (SpecialChar.Contains(text[i]))
                {
                    char ch = SpecialChar[(Array.IndexOf(SpecialChar, text[i]) - s + SpecialChar.Length) % SpecialChar.Length];
                    result += ch;
                }
                else if (char.IsUpper(text[i]))
                {
                    char ch = (char)(((int)(text[i] - s - 65) % 26 + 26) % 26 + 65);
                    result += ch;
                }
                else if (char.IsLower(text[i]))
                {
                    char ch = (char)( ((int)(text[i] - s - 97) % 26 + 26) % 26 + 97);
                    result += ch;
                }
                else
                {
                    char ch = text[i];
                    result += ch;
                }
            }
            return result;
        }
        static private void KiemTra()
        {
            IPAddress ip;
            String Ip4 = "127.0.0.1";
            String Ip5 = "999.0.0.1";
            Console.WriteLine(Ip4.ToString() + ": " +
            IPAddress.TryParse(Ip4, out ip).ToString());
            Console.WriteLine(Ip5.ToString() + ": " +
            IPAddress.TryParse(Ip5, out ip).ToString() + "/" + ip.ToString());
        }
        static private void Func (int n)
        {
            Console.WriteLine(n.ToString() + 1);
            Console.WriteLine(n.ToString("n"));
            Console.WriteLine(Convert.ToString(n, 2));
        }
        static void Main(string[] args)
        {
            Func(10);
            SetConsoleOutputCP(65001);
            string text = "iloveuit";
            int s = 4;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Text : " + text);
            Console.WriteLine("Shift : " + s);
            Console.WriteLine("Cipher: " + Encrypt(text, s));
            Console.WriteLine("Decrypt text: " + Decrypt(Encrypt(text, s), s));
            Console.ReadLine();
        }
    }
}
