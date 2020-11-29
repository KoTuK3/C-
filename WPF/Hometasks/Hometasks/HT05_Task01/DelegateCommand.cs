using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT05_Task01
{
    internal sealed class DelegateCommand : Command
    {
        private static readonly Func<bool> defaultCanExecuteMethod = () => true;

        private readonly Func<bool> canExecuteMethod;
        private readonly Action executeMethod;
        private readonly Action<object> executeMethodObj;

        public DelegateCommand(Action executeMethod, object isCanAddColor) :
            this(executeMethod, defaultCanExecuteMethod)
        {
        }

        public DelegateCommand(Action executeMethod, Func<bool> canExecuteMethod)
        {
            this.canExecuteMethod = canExecuteMethod;
            this.executeMethod = executeMethod;
        }

        public DelegateCommand(Action<object> executeMethod)
        {
            this.executeMethodObj = executeMethod;
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
