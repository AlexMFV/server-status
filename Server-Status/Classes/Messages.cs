using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Server_Status
{
    public static class Messages
    {
        public static void Show(string content, string title)
        {
            MessageBox.Show(content, title);
        }

        public static void ShowInfo(string content, string title)
        {
            MessageBox.Show(content, title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void ShowWarning(string content, string title)
        {
            MessageBox.Show(content, title, MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public static void ShowError(string content, string title)
        {
            MessageBox.Show(content, title, MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static MessageBoxResult ShowQuestion(string content, string title)
        {
            return MessageBox.Show(content, title, MessageBoxButton.YesNo, MessageBoxImage.Question);
        }

        //-------------------------------------- EXCEPTIONS -----------------------------------------

        public static void Show(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.Source);
        }

        public static void ShowInfo(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void ShowWarning(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public static void ShowError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static MessageBoxResult ShowQuestion(Exception ex)
        {
            return MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.YesNo, MessageBoxImage.Question);
        }
    }
}
