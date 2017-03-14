using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FrequencyDictionary
{
   static class Logic
    {
        private static MyList Words = new MyList();
        private static string[] fileWords;
        
        public static MyList getWords
        {
            get { return Words; }
        }
        public static string[] getFileWords
        {
            get { return fileWords; }
        }

        public static void LoadFile(string wayToFile)
        {
            Encoding enc = Encoding.GetEncoding(1251);
            StreamReader sr = new StreamReader(wayToFile, enc);
            string fileString2 = sr.ReadToEnd();
            fileWords = fileString2.Split(new char[] { ' ', ',', '.', ':', ';', '}', '{', '=', '(', ')', '\t' });
        }

        public static void stringToList()
        {
            for (int i = 0; i < fileWords.Length; i++)
            {
                Words.Add(fileWords[i], 1);
            }
        }

        public static void listSortic()
        {
            MyList Words2 = new MyList();
            int count = 0;
            for (int i = 1; i <= Words.count; i++)
            {
                for(int j = 1; j <= Words.count; j++)
                {
                    if(Words.FindByNumber(i).word == Words.FindByNumber(j).word)
                    {
                        count++;
                    }
                }
                if(!Words2.FindNode(Words.FindByNumber(i).word))
                    Words2.Add(Words.FindByNumber(i).word, count);
                count = 0;
            }
            Words = Words2;
        }
    }
}
