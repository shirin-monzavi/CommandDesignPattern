using CommandDesignPattern.Commands;
using CommandDesignPattern.Receivers;

namespace CommandDesignPattern.ConcretCommands;

public class PasteCommand : ICommand
{
    #region Field
    private readonly Document _document;
    #endregion

    public PasteCommand(Document document)
    {
        _document = document;
    }

    public void Execute()
    {
        _document.Paste();
    }
}
