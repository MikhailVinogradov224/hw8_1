using System;
 
namespace hw8_1
{
    class Program
    {
        static void Main(String[] args)
        {
            var a = new Int32[4, 5];
 
            var random = new Random();
            for (var i = 0; i < a.GetLength(0); i++, Console.WriteLine())
            {
                for (var j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(100);
                    Console.Write("{0,4}", a[i, j]);
                }
            }
            
            Console.WriteLine(" ");
            
            for (var i = 0; i < a.GetLength(0); i++)
                
                for (var j = 0; j < a.GetLength(1); j++)
                    for (var k = 0; k < a.GetLength(1); k++)
                    {
                        if (a[i, j] <= a[i, k]) continue;
                        var temp = a[i, j];
                        a[i, j] = a[i, k];
                        a[i, k] = temp;
                    }
 
            for (var i = 0; i < a.GetLength(0); i++, Console.WriteLine())
                for (var j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0,4}", a[i, j]);
                }
 
            
            Console.Read();
        }}} 
                    
                
            
        
    
