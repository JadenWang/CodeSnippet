using System;
using System.Text.RegularExpressions;

class Example
{
    static void Main()
    {
        string text = "One car red car blue car";
        string pat = @"(\w+)\s+(car)";

        Regex r = new Regex(pat, RegexOptions.IgnoreCase);
        Match m = r.Match(text);

        while (m.Success)
        {
            for (int i = 1; i <= 2; i++)
            {
                Group g = m.Groups[i];
                CaptureCollection cc = g.Captures;
                Capture c = cc[0];
                Console.Write("Capture=" + g.ToString());
                Console.WriteLine(" position=" + c.Index);
            }
            m = m.NextMatch();
        }
    }
}
// This example displays the following output: 
//       Match1 
//       Group1='One' 
//       Capture0='One', Position=0 
//       Group2='car' 
//       Capture0='car', Position=4 
//       Match2 
//       Group1='red' 
//       Capture0='red', Position=8 
//       Group2='car' 
//       Capture0='car', Position=12 
//       Match3 
//       Group1='blue' 
//       Capture0='blue', Position=16 
//       Group2='car' 
//       Capture0='car', Position=21