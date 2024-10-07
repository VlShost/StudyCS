using calculator_hw.Enums;

namespace calculator_hw.Classes
{
    public class InputTokenizer
    {
        private readonly List<string> _tokens;
        private string _number;
        private bool _isPreviousCharOperator = true;
        private bool _hasDot = false;
        private int _minusCount = 0;

        public InputTokenizer()
        {
            _tokens = new List<string>();
            _number = "";
            _isPreviousCharOperator = true;
            _hasDot = false;
            _minusCount = 0;
        }

        public List<string> Tokenize(string input)
        {
            foreach (char c in input)
            {
                ProcessCharacter(c);
            }

            if (!string.IsNullOrEmpty(_number))
            {
                _tokens.Add(_number);
            }

            return _tokens;
        }

        public void ClearTokens()
        {
            _tokens.Clear();
        }

        private void ProcessCharacter(char c)
        {
            if (char.IsDigit(c))
            {
                HandleDigit(c);
            }
            else if (c == '.' || c == ',')
            {
                HandleDecimal();
            }
            else if (c == '-')
            {
                HandleMinus(c);
            }
            else
            {
                AddNumberToTokens();
                HandleOperator(c);
            }
        }

        private void HandleDigit(char c)
        {
            if (_minusCount > 0)
            {
                if (_isPreviousCharOperator)
                {
                    _number += '-';
                }
                _minusCount = 0;
            }

            _number += c;
            _isPreviousCharOperator = false;
        }

        private void HandleDecimal()
        {
            if (!_hasDot && _number.Length > 0)
            {
                _number += '.';
                _hasDot = true;
                _isPreviousCharOperator = false;
            }
        }

        private void HandleMinus(char c)
        {
            if (_isPreviousCharOperator)
            {
                _minusCount++;
            }
            else
            {
                AddNumberToTokens();

                _tokens.Add(c.ToString());
                _isPreviousCharOperator = true;
            }
        }

        private void AddNumberToTokens()
        {
            if (!string.IsNullOrEmpty(_number) && !(_hasDot && _number.EndsWith('.')))
            {
                _tokens.Add(_number);
                _number = "";
                _hasDot = false;
            }
        }

        private bool IsOperator(char c)
        {
            return Enum.IsDefined(typeof(Operators), (int)c);
        }

        private void HandleOperator(char c)
        {
            if (IsOperator(c))
            {
                if (!_isPreviousCharOperator)
                {
                    _tokens.Add(c.ToString());
                }
                _minusCount = 0;
                _isPreviousCharOperator = true;
            }
        }
    }
}