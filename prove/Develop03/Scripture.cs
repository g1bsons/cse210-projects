class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string words)
    {
        _reference = reference;
        _words = words.Split(' ')
                      .Select(word => new Word(word))
                      .ToList();
    }
    public string Render()
    {
        string words = string.Join(" ", _words.Select(word => word.GetDisplayedText()));
        return $"{_reference.GetDisplayedText()} {words}";
    }
    public void HideRandomWord(int count)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        if (visibleWords.Count > 0)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
    public bool IsAllHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}