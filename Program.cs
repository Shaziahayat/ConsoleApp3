using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Initialize HTML to PDF converter.
           // HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter();


            HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.Blink);
            BlinkConverterSettings blinkConverterSettings = new BlinkConverterSettings();
            //Set the BlinkBinaries folder path
            blinkConverterSettings.BlinkPath = @"C:\Users\vismun\source\repos\ConsoleApp3\bin\Debug\net6.0\runtimes\win-x64\native";
            //Assign Blink converter settings to HTML converter
            htmlConverter.ConverterSettings = blinkConverterSettings;
            //Convert URL to PDF
            //    //Convert URL to PDF.
            //    var document = htmlConverter.Convert("https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/program-building-blocks");
            //    FileStream fileStream = new FileStream("Sample5.pdf", FileMode.CreateNew, FileAccess.ReadWrite);
            //    //Save and close the PDF document.
            //    document.Save(fileStream);
            //    document.Close(true);


            //HTML string and Base URL 
            //Initialize HTML to PDF converter. 


            //Convert URL to PDF document. 
            var document = htmlConverter.Convert("<h1>Hello world</h1>", "");

            //Create the filestream to save the PDF document. 
            FileStream fileStream = new FileStream("HTML-to-PDF", FileMode.CreateNew, FileAccess.ReadWrite);

            //Save and closes the PDF document.
            document.Save(fileStream);
            document.Close(true);

        }
    }
}