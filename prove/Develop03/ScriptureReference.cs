class ScriptureReference
{
    public string Reference { get; private set; }

    public ScriptureReference(string reference)
    {
        Reference = reference;
    }
}

class ScriptureWord
{
    public string Text { get; private set; }
    public bool IsHidden { get; private set; }

    public ScriptureWord(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }
}