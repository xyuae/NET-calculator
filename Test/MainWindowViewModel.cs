using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;

namespace Test
{
    public class MainWindowViewModel : BindableBase
    {
        protected IBasicMath _mathLib;
        private float _valueA;
        public float ValueA
        {
            get { return _valueA; }
            set { SetProperty(ref _valueA, value); }
        }

        private float _valueB;
        public float ValueB
        {
            get { return _valueB; }
            set { SetProperty(ref _valueB, value); }
        }

        private float _result;
        public float Result
        {
            get { return _result; }
            set { SetProperty(ref _result, value); }
        }

        private string _expr;
        public string Expression
        {
            get { return _expr; }
            set { SetProperty(ref _expr, value); }
        }

        private float _exprRes;
        public float ExpressionResult
        {
            get { return _exprRes; }
            set { SetProperty(ref _exprRes, value); }
        }

        public DelegateCommand<string> Calculate { get; set; }
        public DelegateCommand CalculateExpression { get; set; }

        public MainWindowViewModel(IBasicMath mathLib)
        {
            if (mathLib is null)
                throw new NullReferenceException("The mathLib instance was null, please inject your implementation!");

            Calculate = new DelegateCommand<string>(calculateResult);
            CalculateExpression = new DelegateCommand(calculateExpressionResult);
            _mathLib = mathLib;
        }

        private void calculateExpressionResult()
        {
            
        }

        private void calculateResult(string op)
        {
            try
            {
                switch (op)
                {
                    case "+": Result = _mathLib.Add(ValueA, ValueB); break;
                    case "-": Result = _mathLib.Subtract(ValueA, ValueB); break;
                    case "*": Result = _mathLib.Multiply(ValueA, ValueB); break;
                    case "/": Result = _mathLib.Divide(ValueA, ValueB); break;
                    default: Result = float.NaN;break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Result = float.NaN;
            }
        }
    }
}
