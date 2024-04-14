using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie2
{
    public enum Operation
    {
        Brak,
        Dodawanie,
        Odejmowanie,
        Dzielenie,
        Mnozenie,
    }
    public partial class Form1 : Form
    {
        private string _firstValue;
        private string _secondValue;
        private Operation _currentOperation = Operation.Brak;
        private bool _isTheResultOnTheScreen;
        public Form1()
        {
            var stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            InitializeComponent();
            stopwatch.Stop();
            var initializationTime = stopwatch.ElapsedMilliseconds;

            var threshold = 100; // próg czasowy ustawiony na 100ms

            if (initializationTime > threshold)
            {
                LogEvent($"Czas inicjalizacji przekroczył próg: {initializationTime} ms");
            }
            resultBox.Text = "0";
        }
        private void LogEvent(string message)
        {
            string eventLogName = "Application";
            using (EventLog eventLog = new EventLog(eventLogName))
            {
                eventLog.Source = "Zadanie2";
                eventLog.WriteEntry(message, EventLogEntryType.Information);
            }
        }
        private void inputButtonClick(object sender, EventArgs e)
        {
            var clickedValue = (sender as Button).Text;

            if (resultBox.Text == "0" && clickedValue != ",")
            {
                resultBox.Text = string.Empty;
            }

            if (_isTheResultOnTheScreen)
            {
                _isTheResultOnTheScreen = false;
                resultBox.Text = string.Empty;
                if (clickedValue == ",")
                {
                    clickedValue = "0";
                }
            }

            resultBox.Text += clickedValue;
            SetResultButtonState(true);

            if (_currentOperation != Operation.Brak)
            {
                _secondValue += clickedValue;            
            }
            else
            {
                SetOperationButtonState(true);
            }
        }

        private void operationButtonClick(object sender, EventArgs e)
        {
            _firstValue = resultBox.Text;

            var operation = (sender as Button).Text;
            switch (operation)
            {
                case "+":
                    _currentOperation = Operation.Dodawanie;
                    break;
                case "-":
                    _currentOperation = Operation.Odejmowanie;
                    break;
                case "x":
                    _currentOperation = Operation.Mnozenie;
                    break;
                case "/":
                    _currentOperation = Operation.Dzielenie;
                    break;
                default:
                    _currentOperation = Operation.Brak;
                    break;
            }
            
            resultBox.Text += $" {operation} ";
            if (_isTheResultOnTheScreen)
            {
                _isTheResultOnTheScreen = false;        
            }

            if (_currentOperation != Operation.Brak)
            {
                _secondValue = string.Empty;
            }

            SetOperationButtonState(false);
            SetResultButtonState(false);
        }

        private void clearButtonClick(object sender, EventArgs e)
        {
            resultBox.Text = "0";
            _firstValue = string.Empty;
            _secondValue = string.Empty;
            _currentOperation = Operation.Brak;
        }

        private void resultButtonClick(object sender, EventArgs e)
        {
            if (_currentOperation == Operation.Brak) 
            { 
                return;
            }
            var firstNumber = double.Parse(_firstValue);
            var secondNumber = string.IsNullOrEmpty(_secondValue) ? double.Parse(resultBox.Text) : double.Parse(_secondValue);
            var result = Calculate(firstNumber, secondNumber);
            resultBox.Text = result.ToString();
            _secondValue = string.Empty;
            _currentOperation = Operation.Brak;
            _isTheResultOnTheScreen = true;
            SetOperationButtonState(true);
            SetResultButtonState(true);
        }
        private double Calculate(double firstNumber, double secondNumber)
        {
            switch (_currentOperation)
            {
                case Operation.Brak:
                    return firstNumber;
                    
                case Operation.Dodawanie:
                    return firstNumber + secondNumber;
                    
                case Operation.Odejmowanie:
                    return firstNumber - secondNumber;
                    
                case Operation.Mnozenie:
                    return firstNumber * secondNumber;
                    
                case Operation.Dzielenie:
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Nie można podzielić przez 0.");
                        return 0;
                    }
                    return firstNumber / secondNumber;                   
            }
            return 0;
        }
        private void SetOperationButtonState(bool value)
        {
            buttonPlus.Enabled = value;
            buttonMinus.Enabled = value;
            buttonMnozenie.Enabled = value;
            buttonDzielenie.Enabled = value;
            
        }
        private void SetResultButtonState(bool value)
        {
            buttonRowna.Enabled = value;         
        }
    }
}
