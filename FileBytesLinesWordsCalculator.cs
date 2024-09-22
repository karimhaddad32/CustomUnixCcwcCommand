namespace CustomCcwc
{
    internal class FileBytesLinesWordsCalculator : ICcwcCalculator
    {
        public string Calculate(string filePath)
        {
            FileBytesCountCalculator bytesCalculator = new();
            FileLineCountCalculator lineCountCalculator = new();
            FileWordsCountCalculator wordsCountCalculator = new();

            return $"{lineCountCalculator.Calculate(filePath)}  {wordsCountCalculator.Calculate(filePath)}  {bytesCalculator.Calculate(filePath)}";
        }
    }
}