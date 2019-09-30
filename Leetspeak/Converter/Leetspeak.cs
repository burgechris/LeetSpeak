using System;

namespace Leetspeak
{
    public class Converter
    {
        public char[] Input {get; set;}

        public Converter(string input)
        {
            Input = input.ToCharArray();
            CharConverter();
        }

        public void CharConverter()
        {
            for(int i = 0; i < Input.Length; i++)
            {
                if (Input[i] == 'e')
                {
                    Input[i] = '3';
                }
                else if(Input[i] == 'o' || Input[i] == 'O')
                {
                    Input[i] = '0';
                } 
                else if (Input[i] == 'l')
                {
                    Input[i] = '1';
                }
                else if (Input[i] == 't')
                {
                    Input[i] = '7';
                }
                //The below if statement won't run if the first condition evaluates to false. This is called short-circuiting. 
                else if( i > 0 && Input[i] == 's' && Input[i-1] != ' ')
                {
                    Input[i] = 'z';
                }
            }

        }
    } 
}