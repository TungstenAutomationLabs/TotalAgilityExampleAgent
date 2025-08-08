using System;
using Agility.Server.Scripting.ScriptAssembly;
using System.Text.RegularExpressions;

namespace MyNamespace
{

    public class Class1
    {
        public Class1()
        {
        }

        [StartMethodAttribute()]
        public void Method1(ScriptParameters sp)
        {

            string input = sp.InputVariables["TEXT"];
 
            string htmlString = ExtractHtml(input);

            if (htmlString != null)
            {
                // Console.WriteLine(htmlString);  
            }
            else
            {
                // Console.WriteLine("No HTML object found."); 
                // htmlString = "No HTML object found."; 
                // If the method returned null, return the original response:
                htmlString = input;
            }

            sp.OutputVariables["TEXT"] = htmlString;
        }


        static string ExtractHtml(string input)
        {
            // Define the regex pattern to capture JSON object  
            string pattern = @"\<.*\>";

            // Search for the JSON object in the string  
            Match match = Regex.Match(input, pattern, RegexOptions.Singleline);

            if (match.Success)
            {
                // Extract the JSON object  
                return match.Value;
            }
            else
            {
                return null;
            }
        }
    }
}