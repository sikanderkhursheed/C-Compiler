using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace c_comp
{
    class Program
    {
        static void Main(string[] args)
        {
            var defs = new TokenDefinition[]
            {
                new TokenDefinition(@"\(", "Left Bracket"),
                new TokenDefinition(@"\)", "Right Bracket"),
                new TokenDefinition(@"\{", "Left Curly Bracket"),
                new TokenDefinition(@"\}", "Right Curly Bracket"),
                new TokenDefinition(@"\;", "Colon"),
                new TokenDefinition(@"\s", "Space"),
                new TokenDefinition(@"\.", "DOT"),
                new TokenDefinition(@"\,", "Comma"),
                new TokenDefinition(@"\<|\>|\<=|\>=|\!=|\++|\==|\--", "Relational Operator"),
                new TokenDefinition(@"\/|\+|\%|\*|\-","Operator"),
                new TokenDefinition(@"\=","equal"),
                new TokenDefinition(@"[0-9]+", "Int"),
                new TokenDefinition("for|while","loop"),                                
                new TokenDefinition("if|else","Conditional Statement"),
                new TokenDefinition("printf|scanf","Keyword"),
                new TokenDefinition("void","type"),
                new TokenDefinition("main","main"),
                new TokenDefinition("int","datatipeInt"),
                new TokenDefinition("string","datatipeString"),
                new TokenDefinition(@"[a-zA-Z]+","Identifier"),
                //new TokenDefinition(@"([""'])(?:\\\1|.)*?\1", "String in Quotation"),
                new TokenDefinition("\"(?:[^\"\\\\]|\\\\.)*\"", "String in Quotation"),
            };

            string file = System.IO.File.ReadAllText(@"..\..\..\..\compiler.txt");
            
            TextReader rdr = new StringReader(file);
            lexicalAnalyzer l = new lexicalAnalyzer(rdr, defs);

            List<string> NoteList = new List<string>();
            List<string> OnlyToken = new List<string>();
            List<string> CodeGeneration = new List<string>();

            while (l.Next())
            {
                if(l.Token != "Space")
                {
                   //Console.WriteLine("<{1}>  {0}",l.TokenContents, l.Token);
                    NoteList.Add(l.Token.ToString() + "\t" + l.TokenContents.ToString());
                    OnlyToken.Add(l.Token.ToString());
                    CodeGeneration.Add(l.TokenContents);
                }
            }

            Console.WriteLine("Token Generated");

            foreach (var s in NoteList)
            {
                TextWriter wr = new StreamWriter("C:/Users/HP/Desktop/compilerAnswer.txt", true);
                wr.WriteLine(s);
                wr.Flush();
                wr.Close();
            }

            foreach (var c in CodeGeneration)
            {
                TextWriter wr = new StreamWriter("C:/Users/HP/Desktop/codegeneration.txt", true);
                wr.WriteLine(c);
                wr.Flush();
                wr.Close();
            }

            Process.Start(@"C:/Users/HP/Desktop/compilerAnswer.txt");

            Parser p = new Parser();
            p.parser(OnlyToken,CodeGeneration);
   
            Console.ReadLine();
        }
    }
}
