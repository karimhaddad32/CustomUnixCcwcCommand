namespace CustomCcwc
{
    internal class FileLineCountCalculator : ICcwcCalculator
    {
        public string Calculate(string filePath)
        {
            string[] fileLines = File.ReadAllLines(filePath);
            return fileLines.Length.ToString();
        }
    }
}
