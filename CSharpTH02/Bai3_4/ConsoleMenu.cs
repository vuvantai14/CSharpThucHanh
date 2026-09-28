namespace Bai3_4;

public delegate void MenuChooseEventHandler(
    object sender,
    MenuChooseEventArgs args
);

public class ConsoleMenu
{
    private string title;
    private string footer;
    private List<string> dsItems;

    private IMenuChooseListener? menuChooseListener;

    public event MenuChooseEventHandler? MenuChoose;

    public ConsoleMenu(
        string title,
        string footer,
        params string[] items)
    {
        this.title = title;
        this.footer = footer;

        dsItems = new List<string>();

        for (int i = 0; i < items.Length; i++)
        {
            dsItems.Add(items[i]);
        }
    }

    public int ShowMenu()
    {
        Console.Clear();

        Console.WriteLine(title);
        Console.WriteLine(
            "========================================"
        );

        for (int i = 0; i < dsItems.Count; i++)
        {
            Console.WriteLine(
                $"{i + 1}. {dsItems[i]}"
            );
        }

        Console.WriteLine("0. Thoat");

        Console.WriteLine(
            "========================================"
        );

        Console.Write(footer);

        return int.Parse(
            Console.ReadLine() ?? "0"
        );
    }

    public void AddMenuChooseListener(
        IMenuChooseListener listener)
    {
        menuChooseListener = listener;
    }

    public virtual void OnMenuChoose(
        MenuChooseEventArgs args)
    {
        Console.WriteLine(
            $"Ban chon chuc nang {args.Item}: " +
            $"{args.ItemText}"
        );
    }

    public void Process()
    {
        while (true)
        {
            int chon = ShowMenu();

            MenuChooseEventArgs args;

            if (chon == 0)
            {
                args = new MenuChooseEventArgs(
                    0,
                    "Thoat"
                );

                args.IsExit = true;
            }
            else if (
                chon >= 1 &&
                chon <= dsItems.Count)
            {
                args = new MenuChooseEventArgs(
                    chon,
                    dsItems[chon - 1]
                );
            }
            else
            {
                args = new MenuChooseEventArgs(
                    chon,
                    "Khong hop le"
                );
            }

            // Fire / Raise Event
            if (MenuChoose != null)
            {
                MenuChoose(this, args);
            }
            else if (menuChooseListener != null)
            {
                menuChooseListener.MenuChoose(
                    this,
                    args
                );
            }
            else
            {
                OnMenuChoose(args);
            }

            if (args.IsExit)
            {
                break;
            }

            Console.WriteLine(
                "\nNhan Enter de tiep tuc..."
            );

            Console.ReadLine();
        }
    }
}