using System;

namespace HT04_Task01
{
    internal sealed class DelegateCommand : Command
    {
        private static readonly Func<bool> defaultCanExecuteMethod = () => true;

        private readonly Func<bool> canExecuteMethod;
        private readonly Action executeMethod;

        public DelegateCommand(Action executeMethod, object isCanAddColor) :
            this(executeMethod, defaultCanExecuteMethod)
        {
        }

        public DelegateCommand(Action executeMethod, Func<bool> canExecuteMethod)
        {
            this.canExecuteMethod = canExecuteMethod;
            this.executeMethod = executeMethod;
        }

        protected override bool CanExecute()
        {
            return canExecuteMethod();
        }

        protected override void Execute()
        {
            executeMethod();
        }
    }
}