using Nano22GatiCore.Interfaces;
using System;
using System.Runtime.CompilerServices;

namespace ConsoleTest.Infrastructure
{
    internal class MessageService : IMessageService
    {
        public void ShowConsoleMessage(string Message, [CallerMemberName] string CallMethodName = null)
        {
            throw new NotImplementedException();
        }

        public void ShowErrorMessage(string Message, [CallerMemberName] string CallMethodName = null)
        {
            throw new NotImplementedException();
        }

        public void ShowInfoMessage(string Message, [CallerMemberName] string CallMethodName = null)
        {
            throw new NotImplementedException();
        }

        public void ShowWarningMessage(string Message, [CallerMemberName] string CallMethodName = null)
        {
            throw new NotImplementedException();
        }
    }
}
