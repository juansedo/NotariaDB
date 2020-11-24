using System;
using System.Collections.Generic;
using System.Text;

namespace NotariaDB.Views.Components
{
    class ValidatorBoxFactory
    {
        private static List<ValidatorBoxFlyweight> _validators;

        public static ValidatorBoxFlyweight getValidator(string name)
        {
            ValidatorBoxFlyweight value = null;

            foreach(var v in _validators)
            {
                if (v.GetName() == name)
                {
                    value = v;
                    break;
                }
            }

            if (value == null) {
                value = new ValidatorBoxFlyweight(name);
                _validators.Add(value);
            }

            return value;
        }
    }
}
