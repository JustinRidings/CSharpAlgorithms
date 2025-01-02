public class TextMemento
{
    public string Text { get; private set; }

    public TextMemento(string text)
    {
        Text = text;
    }
}

public class TextEditor
{
    private string _text = default!;

    public void SetText(string text)
    {
        _text = text;
        Console.WriteLine($"Text set to: {_text}");
    }

    public string GetText()
    {
        return _text;
    }

    public TextMemento SaveTextToMemento()
    {
        Console.WriteLine($"Saving text to Memento: {_text}");
        return new TextMemento(_text);
    }

    public void RestoreTextFromMemento(TextMemento memento)
    {
        _text = memento.Text;
        Console.WriteLine($"Text restored from Memento: {_text}");
    }
}

public class TextHistory
{
    private Stack<TextMemento> _mementoStack = new Stack<TextMemento>();

    public void Save(TextMemento memento)
    {
        _mementoStack.Push(memento);
    }

    public TextMemento Undo()
    {
        return _mementoStack.Pop();
    }
}
