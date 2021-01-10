using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTrayNotification
{
    public class LineWord
    {
        int length;
        Stack<string> words;

        public LineWord()
        {
            length = 0;
            words = new Stack<string>();
            
        }

        public int Length { get => length; set => length = value; }
        public Stack<string> Words { get => words; set => words = value; }

        public void ResetValues()
        {
            this.length = 0;
            this.Words.Clear();

        }

    }
}
