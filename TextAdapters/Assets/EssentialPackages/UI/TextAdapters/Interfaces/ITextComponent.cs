namespace EssentialPackages.UI.TextAdapters.Interfaces
{
    public interface ITextComponent
    {
        string Id { get; }
        void SetText(string text);
    }
}
