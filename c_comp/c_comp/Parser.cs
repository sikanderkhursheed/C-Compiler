using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace c_comp
{
    class Parser
    {
        int i = 0;
        int cnt, cntInt1, cntInt2, cntInt3;
        int prnt, prnt1, prnt2;
        int forprint, forprint1;

        int xp, exp1, exp2, exp3, opr1, opr2;
        
        public void parser(List<string> OnlyToken, List<string> CodeGeneration)
        {
            if (OnlyToken[i] == "type")
            {
                i++;
                if (OnlyToken[i] == "main")
                {
                    i++;
                    if (OnlyToken[i] == "Left Bracket")
                    {
                        i++;
                        if (OnlyToken[i] == "Right Bracket")
                        {
                            i++;
                            if (OnlyToken[i] == "Left Curly Bracket")
                            {
                                i++;
                                if (OnlyToken[i] == "loop")
                                {
                                    loop(OnlyToken, CodeGeneration);
                                }
                                else if (OnlyToken[i] == "Keyword")
                                {
                                    printfor(OnlyToken, CodeGeneration);
                                }
                                else if (OnlyToken[i] == "datatipeInt")
                                {
                                    declareInt(OnlyToken, CodeGeneration);
                                }
                                else if (OnlyToken[i] == "datatipeString")
                                {
                                    declareString(OnlyToken, CodeGeneration);
                                }
                                else if (OnlyToken[i] == "Identifier")
                                {
                                    expression(OnlyToken, CodeGeneration);
                                }
                                else
                                {
                                    error();
                                }
                            }
                            else
                            {
                                error();
                            }
                        }
                        else
                        {
                            error();
                        }
                    }
                    else
                    {
                        error();
                    }
                }
                else
                {
                    error();
                }
            }
            else
            {
                error();
            }

            if (OnlyToken[i] == "Right Curly Bracket")
            {
                //i++;
                Console.WriteLine("parsing succed");
                if (OnlyToken[cnt] == "loop")
                {
                    forloop(OnlyToken, CodeGeneration);
                }
                else if(OnlyToken[prnt] == "Keyword")
                {
                    forloop(OnlyToken, CodeGeneration);
                    printing(OnlyToken, CodeGeneration); 
                }
                else if (OnlyToken[xp] == "Identifier")
                {
                    exp(OnlyToken,CodeGeneration);
                }
            }
            else
            {
                error();
            }
        }

        public void loop(List<string> OnlyToken, List<string> CodeGeneration)
        {
            if (OnlyToken[i] == "loop")
            {
                cnt = i;
                i++;
                if (OnlyToken[i] == "Left Bracket")
                {
                    i++;
                    if (OnlyToken[i] == "Identifier")
                    {
                        i++;
                        if (OnlyToken[i] == "equal")
                        {
                            i++;
                            if (OnlyToken[i] == "Int")
                            {
                                cntInt1 = i;
                                i++;
                                if (OnlyToken[i] == "Colon")
                                {
                                    i++;
                                    if (OnlyToken[i] == "Identifier")
                                    {
                                        i++;
                                        if (OnlyToken[i] == "Relational Operator")
                                        {
                                            cntInt3 = i;
                                            i++;
                                            if (OnlyToken[i] == "Int")
                                            {
                                                cntInt2 = i;
                                                i++;
                                                if (OnlyToken[i] == "Colon")
                                                {
                                                    i++;
                                                    if (OnlyToken[i] == "Identifier")
                                                    {
                                                        i++;
                                                        if (OnlyToken[i] == "Relational Operator")
                                                        {
                                                            i++;
                                                            if (OnlyToken[i] == "Right Bracket")
                                                            {
                                                                i++;
                                                                if (OnlyToken[i] == "Left Curly Bracket")
                                                                {
                                                                    i++;
                                                                    if (OnlyToken[i] == "Keyword")
                                                                    {
                                                                        print(OnlyToken,CodeGeneration);

                                                                        if (forprint != 123)
                                                                        {
                                                                            int a, b;
                                                                            string d;
                                                                            a = Convert.ToInt32(CodeGeneration[cntInt1]);
                                                                            b = Convert.ToInt32(CodeGeneration[cntInt2]);
                                                                            d = CodeGeneration[forprint];

                                                                            for (int c = a; c < b; c++)
                                                                            {
                                                                                Console.WriteLine(d);
                                                                            }
                                                                        }
                                                                        else
                                                                        { 
                                                                        
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        error();
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    error();
                                                                }
                                                            }
                                                            else
                                                            {
                                                                error();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            error();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        error();
                                                    }
                                                }
                                                else
                                                {
                                                    error();
                                                }
                                            }
                                            else
                                            {
                                                error();
                                            }
                                        }
                                        else
                                        {
                                            error();
                                        }
                                    }
                                    else
                                    {
                                        error();
                                    }
                                }
                                else
                                {
                                    error();
                                }
                            }
                            else
                            {
                                error();
                            }
                        }
                        else if (OnlyToken[i] == "Colon")
                        {
                            i++;
                            if (OnlyToken[i] == "Identifier")
                            {
                                i++;
                                if (OnlyToken[i] == "Relational Operator")
                                {
                                    i++;
                                    if (OnlyToken[i] == "Int")
                                    {
                                        i++;
                                        if (OnlyToken[i] == "Colon")
                                        {
                                            i++;
                                            if (OnlyToken[i] == "Identifier")
                                            {
                                                i++;
                                                if (OnlyToken[i] == "Relational Operator")
                                                {
                                                    i++;
                                                    if (OnlyToken[i] == "Right Bracket")
                                                    {
                                                        i++;
                                                        if (OnlyToken[i] == "Left Curly Bracket")
                                                        {
                                                            i++;
                                                            if (OnlyToken[i] == "Keyword")
                                                            {
                                                                print(OnlyToken,CodeGeneration);
                                                            }
                                                            else
                                                            {
                                                                error();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            error();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        error();
                                                    }
                                                }
                                                else
                                                {
                                                    error();
                                                }
                                            }
                                            else
                                            {
                                                error();
                                            }
                                        }
                                        else
                                        {
                                            error();
                                        }
                                    }
                                    else
                                    {
                                        error();
                                    }
                                }
                                else
                                {
                                    error();
                                }
                            }
                            else
                            {
                                error();
                            }    
                        }
                        else
                        {
                            error();
                        }
                    }
                    else
                    {
                        error();
                    }
                }
                else
                {
                    error();
                }
            }
            else
            {
                error();
            }

            if (OnlyToken[i] == "Right Curly Bracket")
            {
                i++;
                if (OnlyToken[i] == "loop")
                {
                    loop(OnlyToken,CodeGeneration);
                }
                else
                {
                    return;
                }
            }
            else
            {
                error();
            }
        }


        public void print(List<string> OnlyToken, List<string> CodeGeneration)
        {
            if (OnlyToken[i] == "Keyword")
            {
                prnt = i;
                i++;
                if (OnlyToken[i] == "Left Bracket")
                {
                    i++;
                    if (OnlyToken[i] == "String in Quotation")
                    {
                        forprint1 = 0;
                        forprint = i;
                        prnt1 = i;
                        i++;
                        if (OnlyToken[i] == "Right Bracket")
                        {
                            i++;
                            if (OnlyToken[i] == "Colon")
                            {
                                i++;
                                if (OnlyToken[i] == "Keyword")
                                {
                                    print(OnlyToken,CodeGeneration);
                                }
                                else if (OnlyToken[i] == "loop")
                                {
                                    loop(OnlyToken,CodeGeneration);
                                }
                                else
                                {
                                    return;
                                }
                            }
                            else
                            {
                                error();
                            }
                        }
                        else
                        {
                            error();
                        }
                    }
                    else if (OnlyToken[i] == "Identifier")
                    {
                        forprint1 = 1;

                        forprint = Convert.ToInt32("123");
                        prnt1 = i;
                        i++;
                        if (OnlyToken[i] == "Right Bracket")
                        {
                            i++;
                            if (OnlyToken[i] == "Colon")
                            {
                                i++;
                                if (OnlyToken[i] == "Keyword")
                                {
                                    print(OnlyToken, CodeGeneration);
                                }
                                else
                                {
                                    return;
                                }
                            }
                            else
                            {
                                error();
                            }
                        }
                        else
                        {
                            error();
                        }
                    }
                    else
                    {
                        forprint = Convert.ToInt32("123");
                        error();
                    }
                }
                else
                {
                    error();
                }
            }
            else

            {
                error();
            }
        }

        public void printfor(List<string> OnlyToken, List<string> CodeGeneration)
        {
            if (OnlyToken[i] == "Keyword")
            {
                prnt = i;
                i++;
                if (OnlyToken[i] == "Left Bracket")
                {
                    i++;
                    if (OnlyToken[i] == "String in Quotation")
                    {
                        prnt1 = i;
                        i++;
                        if (OnlyToken[i] == "Right Bracket")
                        {
                            i++;
                            if (OnlyToken[i] == "Colon")
                            {
                                i++;
                                if (OnlyToken[i] == "Keyword")
                                {
                                    printfor(OnlyToken,CodeGeneration);
                                }
                                else if(OnlyToken[i] == "loop")
                                {
                                    loop(OnlyToken,CodeGeneration);
                                }
                                else
                                {
                                    return;
                                }
                            }
                            else
                            {
                                error();
                            }
                        }
                        else
                        {
                            error();
                        }
                    }
                    else
                    {
                        error();
                    }
                }
                else
                {
                    error();
                }
            }
            else
            {
                error();
            }
        }

        public void declareInt(List<string> OnlyToken, List<string> CodeGeneration)
        {
            if (OnlyToken[i] == "datatipeInt")
            {
                i++;
                if (OnlyToken[i] == "Identifier")
                {
                    i++;
                    if (OnlyToken[i] == "equal")
                    {
                        i++;
                        if (OnlyToken[i] == "Int")
                        {
                            i++;
                            if (OnlyToken[i] == "Colon")
                            {
                                i++;
                                if (OnlyToken[i] == "datatipeInt")
                                {
                                    declareInt(OnlyToken,CodeGeneration);
                                }
                                else if (OnlyToken[i] == "Keyword")
                                {
                                    print(OnlyToken,CodeGeneration);
                                }
                                else if (OnlyToken[i] == "loop")
                                {
                                    loop(OnlyToken,CodeGeneration);
                                }
                                else if (OnlyToken[i] == "Identifier")
                                {
                                    //expression(OnlyToken);
                                }
                                else
                                {
                                    return;
                                }
                            }
                            else
                            { 
                                error();
                            }
                        }
                        else
                        {
                            error();
                        }
                    }
                    else if (OnlyToken[i] == "Colon")
                    {
                        i++;
                        if (OnlyToken[i] == "datatipeInt")
                        {
                            declareInt(OnlyToken,CodeGeneration);
                        }
                        else if (OnlyToken[i] == "Keyword")
                        {
                            print(OnlyToken,CodeGeneration);
                        }
                        else if (OnlyToken[i] == "loop")
                        {
                            loop(OnlyToken,CodeGeneration);
                        }
                        else if (OnlyToken[i] == "Identifier")
                        {
                            //expression(OnlyToken);
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        error();
                    }
                }
                else
                {
                    error();
                }
            }
            else
            {
                error();
            }
        }

        public void declareString(List<string> OnlyToken, List<string> CodeGeneration)
        {
            if (OnlyToken[i] == "datatipeString")
            {
                i++;
                if (OnlyToken[i] == "Identifier")
                {
                    i++;
                    if (OnlyToken[i] == "equal")
                    {
                        i++;
                        if (OnlyToken[i] == "Identifier")
                        {
                            i++;
                            if (OnlyToken[i] == "Colon")
                            {
                                i++;
                                if (OnlyToken[i] == "datatipeString")
                                {
                                    declareString(OnlyToken,CodeGeneration);
                                }
                                else if (OnlyToken[i] == "Keyword")
                                   {
                                    print(OnlyToken,CodeGeneration);
                                }
                                else
                                {
                                    return;
                                }
                            }
                            else
                            {
                                error();
                            }
                        }
                        else
                        {
                            error();
                        }
                    }
                    else if (OnlyToken[i] == "Colon")
                    {
                        i++;
                        if (OnlyToken[i] == "datatipeString")
                        {
                            declareString(OnlyToken,CodeGeneration);
                        }
                        else if (OnlyToken[i] == "Keyword")
                        {
                            print(OnlyToken,CodeGeneration);
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        error();
                    }
                }
                else
                {
                    error();
                }
            }
            else
            {
                error();
            }
        }

        public void expression(List<string> OnlyToken, List<string> CodeGeneration)
        {
            if (OnlyToken[i] == "Identifier")
            {
                xp = i;
                i++;
                if (OnlyToken[i] == "equal")
                {
                    i++;
                    if (OnlyToken[i] == "Identifier")
                    {
                        expressionIdenifier(OnlyToken, CodeGeneration);
                    }
                    else if (OnlyToken[i] == "Int")
                    {
                        expressionInt(OnlyToken, CodeGeneration);
                    }
                }
                else
                {
                    error();
                }
            }
            else
            {
                error();
            }
        }

        public void expressionIdenifier(List<string> OnlyToken, List<string> CodeGeneration)
        {
            if (OnlyToken[i] == "Identifier")
            {
                exp1 = i;
                i++;
                if (OnlyToken[i] == "Operator")
                {
                    opr1 = i;
                    i++;
                    if (OnlyToken[i] == "Identifier")
                    {
                        exp2 = i;
                        i++;
                        if (OnlyToken[i] == "Colon")
                        {
                            i++;
                            if (OnlyToken[i] == "Identifier")
                            {
                                expression(OnlyToken, CodeGeneration);
                            }
                            else if (OnlyToken[i] == "loop")
                            {
                                loop(OnlyToken, CodeGeneration);
                            }
                            else if (OnlyToken[i] == "Keyword")
                            {
                                print(OnlyToken, CodeGeneration);
                            }
                            else if (OnlyToken[i] == "datatipeString")
                            {
                                declareString(OnlyToken, CodeGeneration);
                            }
                            else if (OnlyToken[i] == "datatipeInt")
                            {
                                declareInt(OnlyToken, CodeGeneration);
                            }
                            else
                            {
                                return;
                            }
                        }
                        else if (OnlyToken[i] == "Operator")
                        {
                            opr2 = i;
                            i++;
                            if (OnlyToken[i] == "Identifier")
                            {
                                exp3 = i;
                                i++;
                                if (OnlyToken[i] == "Colon")
                                {
                                    i++;
                                    if (OnlyToken[i] == "Identifier")
                                    {
                                        expression(OnlyToken, CodeGeneration);
                                    }
                                    else if (OnlyToken[i] == "loop")
                                    {
                                        loop(OnlyToken, CodeGeneration);
                                    }
                                    else if (OnlyToken[i] == "Keyword")
                                    {
                                        print(OnlyToken, CodeGeneration);
                                    }
                                    else if (OnlyToken[i] == "datatipeString")
                                    {
                                        declareString(OnlyToken, CodeGeneration);
                                    }
                                    else if (OnlyToken[i] == "datatipeInt")
                                    {
                                        declareInt(OnlyToken, CodeGeneration);
                                    }
                                    else
                                    {
                                        return;
                                    }

                                }
                                else
                                {
                                    error();
                                }
                            }
                            else
                            {
                                error();
                            }
                        }
                        else
                        {
                            error();
                        }
                    }
                    else if (OnlyToken[i] == "Int")
                    {
                        i++;
                        if (OnlyToken[i] == "Colon")
                        {
                            i++;
                            if (OnlyToken[i] == "Identifier")
                            {
                                expression(OnlyToken, CodeGeneration);
                            }
                            else if (OnlyToken[i] == "loop")
                            {
                                loop(OnlyToken, CodeGeneration);
                            }
                            else if (OnlyToken[i] == "Keyword")
                            {
                                print(OnlyToken, CodeGeneration);
                            }
                            else if (OnlyToken[i] == "datatipeString")
                            {
                                declareString(OnlyToken, CodeGeneration);
                            }
                            else if (OnlyToken[i] == "datatipeInt")
                            {
                                declareInt(OnlyToken, CodeGeneration);
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            error();
                        }
                    }
                    else
                    {
                        error();
                    }
                }
                else
                {
                    error();
                }
            }
            else
            {
                error();
            }
        }

        public void expressionInt(List<string> OnlyToken, List<string> CodeGeneration)
        {
            if (OnlyToken[i] == "Int")
            {
                exp1 = i;
                i++;
                if (OnlyToken[i] == "Operator")
                {
                    opr1 = i;
                    i++;
                    if (OnlyToken[i] == "Int")
                    {
                        exp2 = i;
                        i++;
                        if (OnlyToken[i] == "Colon")
                        {
                            i++;
                            if (OnlyToken[i] == "Identifier")
                            {
                                expression(OnlyToken, CodeGeneration);
                            }
                            else if (OnlyToken[i] == "loop")
                            {
                                loop(OnlyToken, CodeGeneration);
                            }
                            else if (OnlyToken[i] == "Keyword")
                            {
                                print(OnlyToken, CodeGeneration);
                            }
                            else if (OnlyToken[i] == "datatipeString")
                            {
                                declareString(OnlyToken, CodeGeneration);
                            }
                            else if (OnlyToken[i] == "datatipeInt")
                            {
                                declareInt(OnlyToken, CodeGeneration);
                            }
                            else
                            {
                                return;
                            }
                        }
                        else if (OnlyToken[i] == "Operator")
                        {
                            opr2 = i;
                            i++;
                            if (OnlyToken[i] == "Int")
                            {
                                exp3 = i;
                                i++;
                                if (OnlyToken[i] == "Colon")
                                {
                                    i++;
                                    if (OnlyToken[i] == "Identifier")
                                    {
                                        expression(OnlyToken, CodeGeneration);
                                    }
                                    else if (OnlyToken[i] == "loop")
                                    {
                                        loop(OnlyToken, CodeGeneration);
                                    }
                                    else if (OnlyToken[i] == "Keyword")
                                    {
                                        print(OnlyToken, CodeGeneration);
                                    }
                                    else if (OnlyToken[i] == "datatipeString")
                                    {
                                        declareString(OnlyToken, CodeGeneration);
                                    }
                                    else if (OnlyToken[i] == "datatipeInt")
                                    {
                                        declareInt(OnlyToken, CodeGeneration);
                                    }
                                    else
                                    {
                                        return;
                                    }

                                }
                                else
                                {
                                    error();
                                }
                            }
                            else
                            {
                                error();
                            }
                        }
                        else
                        {
                            error();
                        }
                    }
                }
                else
                {
                    error();
                }
            }
            else
            {
                error();
            }
        }

        public void error()
        {
            Console.WriteLine("Error at line {0}", i);
        }



        //****************************************Intermediate Code***********************************************


        public void forloop(List<string> OnlyToken, List<string> CodeGeneration)
        {
            if (OnlyToken[cnt] == "loop" && forprint1 == 1)
            {
                int a, b;
                string opr;
                a = Convert.ToInt32(CodeGeneration[cntInt1]);
                b = Convert.ToInt32(CodeGeneration[cntInt2]);
                opr = CodeGeneration[cntInt3];

                if (opr == "<")
                {
                    //int cc = prnt2;
                    for (int c = a; c < b; c++)
                    {
                        Console.WriteLine(c);
                    }
                }
                else if (opr == ">")
                {
                    for (int c = a; c > b; c++)
                    {
                        Console.WriteLine(c);
                    }
                }
                else if (opr == "<=")
                {
                    for (int c = a; c <= b; c++)
                    {
                        Console.WriteLine(c);
                    }
                }
                else if (opr == ">=")
                {
                    for (int c = a; c >= b; c++)
                    {
                        Console.WriteLine(c);
                    }
                }
            }
            else
            {
                return;
            }
        }

        public void printing(List<string> OnlyToken, List<string> CodeGeneration)
        {
            if (OnlyToken[prnt] == "Keyword")
            {
                string a = CodeGeneration[prnt1];
                Console.WriteLine(a);
            }
        }

        public void exp(List<string> OnlyToken, List<string> CodeGeneration) 
        {
            string a, b, c ,d, e,f;
            string t1, t2, t3, t4;

            a = CodeGeneration[opr1];
            b = CodeGeneration[opr2];

            t1 = CodeGeneration[exp1];
            t2 = CodeGeneration[exp2];
            t3 = CodeGeneration[exp3];

            if ((a == "/") && (b == "-" || b == "/" || b == "*"))
            {
                c = CodeGeneration[opr1 - 1];
                d = CodeGeneration[opr1 + 1];

                e = CodeGeneration[opr2 - 1];
                f = CodeGeneration[opr2 + 1];

                Console.WriteLine("t4 = {0} {1} {2}", c, a, d);
                Console.WriteLine("t5 = t4 {0} {1}",b,f);
            }
            else if (((a == "*") && (b == "/" || b == "*")) || ((a == "-") && (b == "*")) || ((a == "-") && (b == "/")))
            { 
                c = CodeGeneration[opr2 - 1];
                d = CodeGeneration[opr2 + 1];

                e = CodeGeneration[opr1 - 1];
                f = CodeGeneration[opr1 + 1];

                Console.WriteLine("t4 = {0} {1} {2}", c, b, d);
                Console.WriteLine("t5 = {0} {1} t4 ", e, a);
            }
            else if ((a == "*") && (b == "-"))
            {
                c = CodeGeneration[opr1 - 1];
                d = CodeGeneration[opr1 + 1];

                e = CodeGeneration[opr2 - 1];
                f = CodeGeneration[opr2 + 1];

                Console.WriteLine("t4 = {0} {1} {2}", c, a, d);
                Console.WriteLine("t5 = t4 {0} {1}", b, f);
            }

        }


        //***********************************************************************************************************

    }
}
