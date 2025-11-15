using Avalonia.Controls;
using System.Runtime.InteropServices;

namespace AutoClicker;

public partial class MainWindow : Window
{
    // Imports
    [DllImport("user32.dll")]
    static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo); // mouse click

    [DllImport("user32.dll")]
    static extern short GetAsyncKeyState(int vKey); // hotkey

    // class variables
    public const int MOUSEEVENTF_LEFTDOWN = 0x02;
    public const int MOUSEEVENTF_LEFTUP = 0x04;

    public const int HOTKEY = 0x74; // F5 key

    public bool enableClicker = false; // enable/disable auto clicker
    public int clickInterval = 5; // interval between clicks in milliseconds

    void MouseClick() // performs a mouse click
    {
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
    }

    private void StartAutoClicker()
    {
        System.Threading.Tasks.Task.Run(() =>
        {
            while (true)
            {
                if (GetAsyncKeyState(HOTKEY) < 0) // check if hotkey is pressed
                {
                    enableClicker = !enableClicker; // toggle auto clicker
                    System.Threading.Thread.Sleep(300); // debounce delay
                }

                if (enableClicker) // if auto clicker is enabled
                {
                    MouseClick(); // perform mouse click
                }

                System.Threading.Thread.Sleep(clickInterval); // wait for interval
            }
        });
    }

    private void InitializeAutoClicker() // initialisation des boutons Start et Stop
    {
        // Lancer le clic automatique
        StartAutoClicker();

        // Update interval when text changes
        if (IntervalBox != null)
        {
            IntervalBox.TextChanged += (_, __) =>
            {
                if (int.TryParse(IntervalBox.Text, out int interval))
                {
                    clickInterval = interval;
                }
            };
        }

        // Vérifie que StartButton est non null
        if (StartButton != null)
        {
            StartButton.Click += (_, __) =>
            {
                enableClicker = true;
            };
        }

        if (StopButton != null)
        {
            StopButton.Click += (_, __) =>
            {
                enableClicker = false;
            };
        }
    }

    public MainWindow()
    {
        InitializeComponent();
        InitializeAutoClicker();
    }
}


