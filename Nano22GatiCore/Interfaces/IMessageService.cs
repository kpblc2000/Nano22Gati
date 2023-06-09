using System.Runtime.CompilerServices;

namespace Nano22GatiCore.Interfaces
{
    public  interface IMessageService
    {
        /// <summary>
        /// Показ информационного сообщения
        /// </summary>
        /// <param name="Message"></param>
        void ShowInfoMessage(string Message, [CallerMemberName] string CallMethodName = null);
        /// <summary>
        /// Показ предупреждения
        /// </summary>
        /// <param name="Message"></param>
        void ShowWarningMessage(string Message, [CallerMemberName] string CallMethodName = null);
        /// <summary>
        /// Показ ошибки
        /// </summary>
        /// <param name="Message"></param>
        void ShowErrorMessage(string Message, [CallerMemberName] string CallMethodName = null);
        /// <summary>
        /// Вывод сообщения в консоль
        /// </summary>
        /// <param name="Message"></param>
        void ShowConsoleMessage(string Message, [CallerMemberName] string CallMethodName = null);
    }
}
