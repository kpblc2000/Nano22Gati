using HostMgd.ApplicationServices;
using Nano22GatiCore.Interfaces;
using System.Runtime.CompilerServices;
using System.Windows;
using Application = HostMgd.ApplicationServices.Application;

namespace Nano22Gati.Infrastructure
{
    public class MessageService : IMessageService
    {
        public void ShowConsoleMessage(string Message, [CallerMemberName] string CallMethodName = null)
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            if (doc == null)
            {
                ShowErrorMessage("Нет активного документа", CallMethodName);
                ShowInfoMessage(Message, CallMethodName);
            }
        }

        public void ShowErrorMessage(string Message, [CallerMemberName] string CallMethodName = null)
        {
           MessageBox.Show(string.IsNullOrWhiteSpace(CallMethodName) ? "" : $"{CallMethodName} :" + Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public void ShowInfoMessage(string Message, [CallerMemberName] string CallMethodName = null)
        {
            MessageBox.Show(string.IsNullOrWhiteSpace(CallMethodName) ? "" : $"{CallMethodName} :" + Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void ShowWarningMessage(string Message, [CallerMemberName] string CallMethodName = null)
        {
            MessageBox.Show(string.IsNullOrWhiteSpace(CallMethodName) ? "" : $"{CallMethodName} :" + Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
