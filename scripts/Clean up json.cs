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

            string jsonString = ExtractJson(input);

            if (jsonString != null)
            {
                // Console.WriteLine(jsonString);  
            }
            else
            {
                // Console.WriteLine("No JSON object found."); 
                // jsonString = "No JSON object found.";
                // Return the original input:
                jsonString = input;
            }

            sp.OutputVariables["TEXT"] = jsonString;
        }


        static string ExtractJson(string input)
        {
            // Define the regex pattern to capture HTML object  
            //string pattern = @"\<.*\>";  
            // Define the regex pattern to capture JSON object  
            string pattern = @"\{.*\}";

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