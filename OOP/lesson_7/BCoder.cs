using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.lesson_7
{
    public class BCoder : ICoder
    {
        private readonly Dictionary<char, Tuple<int, int>> _tuples = new Dictionary<char, Tuple<int, int>>();
        private char[] _charCaracter;
        private const int _alfabetLengt = 26;

        public BCoder(string text)
        {
            _charCaracter = text.ToCharArray();
            for (int i = 0; i < _alfabetLengt; i++)
            {
                _tuples.Add((char)(97 + i), new Tuple<int, int>(97, 97 + _alfabetLengt - 1));
                _tuples.Add((char)(65 + i), new Tuple<int, int>(65, 65 + _alfabetLengt - 1));
            }

        }

        public string Encode()
        {
            for (int i = 0; i < _charCaracter.Length; i++)
            {
                if (_tuples.ContainsKey(_charCaracter[i]))
                {
                    var el = _tuples[_charCaracter[i]];
                    _charCaracter[i] = (char)(el.Item2 - (_charCaracter[i] - el.Item1));
                }
                else
                {
                    _charCaracter[i] = _charCaracter[i];
                }
            }

            return string.Concat(_charCaracter);
        }

        public string Decode()
        {

            for (int i = 0; i < _charCaracter.Length; i++)
            {
                if (_tuples.ContainsKey(_charCaracter[i]))
                {
                    var el = _tuples[_charCaracter[i]];
                    _charCaracter[i] = (char)(el.Item2 - (_charCaracter[i] - el.Item1));
                }
                else
                {
                    _charCaracter[i] = _charCaracter[i];
                }

            }
            return string.Concat(_charCaracter);
        }
    }
}
