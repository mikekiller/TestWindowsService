using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTrayNotification
{
    public class Controller
    {
        public String readData(string data)
        {

            LineWord lineWord = new LineWord();
            Data table = new Data();
            string newWord ="";
            String textArea = "";

            int indication = 0;

            foreach (var element in data)
            {
                if (char.IsLetterOrDigit(element) || char.IsPunctuation(element))
                {
                    newWord += element;
                    indication = 0;
                }
                else
                {
                    if (char.IsSeparator(element))
                    {

                        lineWord.Length += newWord.Length + 1;
                        lineWord.Words.Push(newWord);
                        newWord = "";
                        
                    }
                    else
                    {
                        if (element.Equals('\r'))
                        {
                            if (newWord.Length > 0)
                            {
                                lineWord.Length += newWord.Length;
                                lineWord.Words.Push(newWord);
                                table.AddRow(lineWord);
                                newWord = "";
                                lineWord.ResetValues();
                            }

                        }
                        else
                        {
                            if (element.Equals('\n'))
                            {
                                indication++;
                                if (indication > 1)
                                {
                                    
                                    textArea += table.GetStringToTextArea() + Environment.NewLine;
                                    table.ResetValues();

                                }
                            }
                        }

                    }
                }

            }

            return textArea;
        }


    }
}
