using System;

namespace Problems
{
    public class Program
    {
        public static string Prefix(string input){
            string length=Convert.ToString(input.Length);
            int wordCount=0;
            /*for(int i = 0;i<input.Length;i++){
                if(input[i]==' '){
                    wordCount++;
                }
            }*/
            string[] splits=input.Split(' ');
            wordCount=splits.Length;
            for(int i =0;i<splits.Length;i++){
                if(splits[i]==""){
                    wordCount--;
                }
            }
            string numWords= Convert.ToString(wordCount);

            return length+","+numWords+":"+input;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Prefix("what    ...  did you say?? "));
        }
    }
}
