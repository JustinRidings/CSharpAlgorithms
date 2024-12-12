public abstract class DocumentProcessor
{
    // Template method
    public void ProcessDocument()
    {
        OpenDocument();
        ExtractContent();
        FormatDocument();
        SaveDocument();
    }

    protected abstract void OpenDocument();
    protected abstract void ExtractContent();
    protected abstract void FormatDocument();
    protected abstract void SaveDocument();
}

public class WordDocumentProcessor : DocumentProcessor
{
    protected override void OpenDocument()
    {
        Console.WriteLine("Opening Word document...");
    }

    protected override void ExtractContent()
    {
        Console.WriteLine("Extracting content from Word document...");
    }

    protected override void FormatDocument()
    {
        Console.WriteLine("Formatting Word document...");
    }

    protected override void SaveDocument()
    {
        Console.WriteLine("Saving Word document...");
    }
}

public class PdfDocumentProcessor : DocumentProcessor
{
    protected override void OpenDocument()
    {
        Console.WriteLine("Opening PDF document...");
    }

    protected override void ExtractContent()
    {
        Console.WriteLine("Extracting content from PDF document...");
    }

    protected override void FormatDocument()
    {
        Console.WriteLine("Formatting PDF document...");
    }

    protected override void SaveDocument()
    {
        Console.WriteLine("Saving PDF document...");
    }
}
