using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    internal class Player
    {
        public string _name;
        public string _number;

        public Player(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new PlayerException("Enter a valid name.");
                }
                _name = value;
            }
        }

        public string Number
        {
            get { return _number; }
            set
            {
                if (!int.TryParse(value, out var number) || number < 1 || number > 999)
                {
                    throw new PlayerException("Enter a valid number.");
                }
                _number = value;
            }
        }
    }
}
