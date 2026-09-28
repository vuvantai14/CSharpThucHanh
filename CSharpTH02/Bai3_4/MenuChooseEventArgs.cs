namespace Bai3_4;

public class MenuChooseEventArgs : EventArgs
{
    public int Item { get; private set; }

    public string ItemText { get; private set; }

    public bool IsExit { get; set; }

    public MenuChooseEventArgs(int item, string text)
    {
        Item = item;
        ItemText = text;
        IsExit = false;
    }
}
