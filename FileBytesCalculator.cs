using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCcwc
{
    internal class FileBytesCountCalculator : ICcwcCalculator
    {
        public string Calculate(string filePath)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            return fileBytes.Length.ToString();
        }
    }
}
