using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace VisualCoddingLAB6.Views
{
    public partial class NoteWindow : Window
    {
        public delegate void OkHandler(string Name, string Text);
        public event OkHandler? OkNotification;

        public NoteWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            this.FindControl<Button>("OK").Click += async delegate
            {
                OkNotification(this.Find<TextBox>("NoteName").Text, this.Find<TextBox>("NoteText").Text);
                Close();
            };
            this.FindControl<Button>("Cancel").Click += delegate
            {
                Close();
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}