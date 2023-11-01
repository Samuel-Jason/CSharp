using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class Strings
    {
        private char title;
        private char firstName;
        private char midName;
        private char lastName;

        public string StringPlus()
        {
            return title + '' + firstName + '' + midName + '' + lastName;
        }

        public string StringJoin()
            => string.Join(' ', title, firstName, midName, lastName);

    }
}
