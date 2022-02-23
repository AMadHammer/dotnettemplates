using System.Text.RegularExpressions;

namespace SwaggerhubClientGenerator
{
    public class ControllerTextTemplateHelper
    {
        public static string HelloWorld() { return "helloWorld"; }

        public static string GetControllerName(string path)
        {
            Regex word = new Regex(@"([^\/]+$)");
            Match m = word.Match(path);
            if (m.Value.Substring(0, 1) == "{")
                return "Get" + char.ToUpper(m.Value[1]) + m.Value.Substring(2, m.Value.Length - 3);
            else
                return char.ToUpper(m.Value[0]) + m.Value.Substring(1);
        }
    }
}