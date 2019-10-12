﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_comp
{
    public sealed class lexicalAnalyzer : IDisposable
    {
            private readonly TextReader reader;
            private readonly TokenDefinition[] tokenDefinitions;

            private string lineRemaining;

            public lexicalAnalyzer(TextReader reader, TokenDefinition[] tokenDefinitions)
            {
                this.reader = reader;
                this.tokenDefinitions = tokenDefinitions;
                nextLine();
            }

            private void nextLine()
            {
                do
                {
                    lineRemaining = reader.ReadLine();
                    ++LineNumber;
                    Position = 0;
                } while (lineRemaining != null && lineRemaining.Length == 0);
            }

            public bool Next()
            {
                if (lineRemaining == null)
                    return false;
                foreach (var def in tokenDefinitions)
                {
                    var matched = def.Matcher.Match(lineRemaining);
                    if (matched > 0)
                    {

                        Position += matched;
                        Token = def.Token;
                        TokenContents = lineRemaining.Substring(0, matched);
                        lineRemaining = lineRemaining.Substring(matched);
                        if (lineRemaining.Length == 0)
                            nextLine();

                        return true;
                    }
                }
                throw new Exception(string.Format("Unable to match against any tokens at line {0} position {1} \"{2}\"",
                                                  LineNumber, Position, lineRemaining));
            }

            public string TokenContents { get; private set; }

            public object Token { get; private set; }

            public int LineNumber { get; private set; }

            public int Position { get; private set; }

            public void Dispose()
            {
                reader.Dispose();
            }
        }
    }
