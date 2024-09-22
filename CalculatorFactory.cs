namespace CustomCcwc
{
    internal class CalculatorFactory
    {
        internal static ICcwcCalculator CreateCalculator(string option)
        {
            return option switch
            {
                "-c" => new FileBytesCountCalculator(),
                "-l" => new FileLineCountCalculator(),
                "-w" => new FileWordsCountCalculator(),
                "-m" => new FileCharacterCalculator(),
                _ => new FileBytesLinesWordsCalculator()
            };          
        }
    }
}
