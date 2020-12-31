using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTrayNotification
{
    class stanza
    {
        string[][] matriz;
        string TextInput1;


        public stanza()
        {
            InicializarMatriz(out matriz,10,10);
            
        }

        private void InicializarMatriz(out string[][] matriz, int x , int y )
        {
            matriz = new string[x][];
            for (int i=0; i<x; i++)
            {
                matriz[i] = new string[y]; 
            }
        }

        public string[][] Matriz { get => matriz; set => matriz = value; }
        public string TextInput11 { get => TextInput1; set => TextInput1 = value; }

        public string recorrerArray(string input)
        {
            Stack newWord  = new Stack();
            string result = "";
            string output = "";
            int x = 0, y = 0, sl = 0, ch = 0;
            
            foreach (var element in input)
            {
                if (!element.Equals('\n'))
                {
                    if (!char.IsWhiteSpace(element))
                    {
                        output += element;
                    }
                    else
                    {
                        if (output.Length > 0)
                        {
                            newWord.Push(output);
                            y++;
                            output = "";
                            sl = 0;
                        }
                    }
                    ch++;
                }
                else {

                    sl++;
                    if (newWord.Count>0)
                    {
                        newWord.Push(ch.ToString());                        
                        InvertirCadena(newWord, x,ch);
                        x++;
                        y = 0;
                        newWord.Clear();
                        ch = 0;

                    }
                        
                    if (sl >= 2)
                    {
                        result +=   AddtoTextArea();
                        result += Environment.NewLine;
                        InicializarMatriz(out matriz, 10, 10);
                        sl = 0;
                        x = 0;
                    }
                    
                }
            }
            if (newWord.Count > 0)
            {
                newWord.Push(ch.ToString());
                InvertirCadena(newWord, x, ch);

            }
            else
            {
                result += AddtoTextArea();
            }
               
            return result;
        }

        private string AddtoTextArea()
        {
            int[] lista = new int[10];
           
            
            for (int i = 0; i < matriz.Length; i++)
            {
                if (!string.IsNullOrEmpty(matriz[i][0]))
                {
                    lista[i] = int.Parse( matriz[i][0]);
                }
                
            }
            
            int[] sortedCopy = lista.OrderBy(i => i).ToArray();

            return rellenarTextArea(sortedCopy);

        }

        private string rellenarTextArea(int[] vector)
        {
            string main = "";
          
            for (int m = vector.Length-1; m > 0;m--)
            {
                if (vector[m] > 0)
                {
                    for (int i = 0; i < matriz.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(matriz[i][0]))
                        {
                        
                            if (vector[m] == int.Parse(matriz[i][0]))
                            {
                                
                                for (int y = 1; y < matriz.Length; y++)
                                {
                                    if (!string.IsNullOrEmpty(matriz[i][y]))
                                    {
                                        main += matriz[i][y].ToString();
                                        main = main + " ";
                                        matriz[i][0] = "0";
                                    }

                                }
                                main = main + Environment.NewLine;
                            }
                        }
                        
                    }
                }
                
            }

            return main;
        }

        private void InvertirCadena(Stack inputText, int i, int ch)
        {

            int cont = inputText.Count;

            for (int y = 0; y < cont; y++)
            {
                matriz[i][y] = (string)inputText.Pop();
            }

        }

        private int arraycount(string[] inputText)
        {
            int x = 0;
            foreach (var i in inputText)
            {
                if (!string.IsNullOrEmpty(i))
                {
                    x++;
                }
            }
            return x;
        }
    }
}
