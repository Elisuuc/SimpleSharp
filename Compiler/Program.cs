using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Compiler
{
    class Program
    {
        private static StreamReader reader;

        static void Main(string[] args)
        {
            reader = new StreamReader(args[1]);

            string line;

            while ((line = reader.ReadLine()) != null)
            {
                analizeLine(line);
            }
        }


        //Analize the code if begins an if, loop or var (variable)
        public static void analizeLine(string pline)
        {
            string[] chunks = pline.Split(':');

            switch (chunks[0].ToUpper())
            {
                case "IF":
                    beginIf(chunks[1]);
                    break;
                case "VAR":
                    break;
                case "LOOP":
                    break;
            }
        }

        //start IF block
        public static void beginIf(string condition)
        {

        }

        //end IF block
        public static void endIf()
        {

        }

    }
}
