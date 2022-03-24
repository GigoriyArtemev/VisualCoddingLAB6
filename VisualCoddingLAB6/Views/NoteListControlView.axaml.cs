using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using VisualCoddingLAB6.Models;
using System.Collections.Generic;

namespace VisualCoddingLAB6.Views
{
    public partial class NoteListControlView : UserControl
    {
        public NoteListControlView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}