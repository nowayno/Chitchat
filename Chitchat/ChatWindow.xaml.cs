using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Chitchat
{
    /// <summary>
    /// ChatWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ChatWindow : Window
    {
        public ChatWindow()
        {
            InitializeComponent();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // 获取鼠标相对标题栏位置  
            Point position = e.GetPosition(dragGrid);

            // 如果鼠标位置在标题栏内，允许拖动  
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (position.X >= 0 && position.X < dragGrid.ActualWidth && position.Y >= 0 && position.Y < dragGrid.ActualHeight)
                {
                    this.DragMove();
                }
            }
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void closeButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

            //this.Hide();
        }
    }
}
