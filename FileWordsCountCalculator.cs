namespace CustomCcwc
{
    internal class FileWordsCountCalculator : ICcwcCalculator
    {
        public string Calculate(string filePath)
        {
            string[] fileText = File.ReadAllLines(filePath);

            int total = 0;
            foreach (string line in fileText)
            {
                if(string.IsNullOrWhiteSpace(line)) continue;
                total += TextCleaner.CleanText(line).Split(' ').Length;
            }

            return total.ToString();
        }
    }
}