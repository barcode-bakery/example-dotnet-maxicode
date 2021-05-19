using System.Threading.Tasks;

namespace BarcodeMaxiCode.Core.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // See each barcode file to see how you can save to a file or a MemoryStream.
            await ExampleMaxiCode.CreateAsync("barcode_maxicode.png");
        }
    }
}
