using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication110
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String:");
            string file = Console.ReadLine();
            string[] extension = new string[]{"AIFF","AIF","AU","AVI","BAT","BMP","CLASS","JAVA","JPEG","JPG","CSV","CVS","DBF","DIF",
                                            "DIF","DOC","DOCX","EPS","EXE","FM3","GIF","HQX","HTM","HTML","JPG","JPEG",
                                            "MAC","MAP","MDB","MID","MIDI","MOV","QT","MTB","MTW","PDF","P65","T65","PNG","PPT",
                                            "PPTX","PSD","PSP","QXD","RA","RTF","SIT","TAR","TIF","TXT","WAV","WK3","WKS","WPD",
                                            "WP5","XLS","XLSX","ZIP"};
            int i,j,L1, count=0, L;
            char[] f = file.ToCharArray();
            L = f.Length;
            string ext = string.Empty;
            for (i = 0; i < L; i++)
            {
                if (f[i] == '.')
                {
                    count++;
                    continue;
                }
                else if (count == 1)
                {
                    ext = ext + f[i];
                }
            }
            L1 = extension.Length;
            Console.WriteLine("The extension is:");
            for (j = 0; j < L1; j++)
            {
                if (ext == extension[j])
                {
                    Console.WriteLine(ext);
                    break;
                }
                else
                {
                    continue;
                }
            }

            Console.ReadLine();
        }
    }
}
