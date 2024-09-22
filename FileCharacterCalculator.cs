using System.Text;

namespace CustomCcwc
{
    internal class FileCharacterCalculator : ICcwcCalculator
    {
        public string Calculate(string filePath)
        {
            return File.ReadAllText(filePath).Length.ToString();
        }
    }
}