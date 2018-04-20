using System;

namespace sayhello
{
    class Program
    {
        static void Main(string[] args)
      {
			//Testconsoleproperty();
			//Console.WriteLine("Hello World!");
			//testinput();
			//Console.WriteLine("1");
			//Console.ReadKey();
			//Console.WriteLine("2");
			//Console.ReadKey(true);//不想用户输入的按键显示在屏幕
			Console.Beep();
			Console.WriteLine("PLEASE INPUT");
			Console.ReadKey();
		}
		static void Testconsoleproperty()
		{
			Console.Title = "current time:"+DateTime.Now;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.BackgroundColor = ConsoleColor.DarkBlue;
		}
		static void testinput()
		{
			Console.Write("please input a string");
			string userinput = Console.ReadLine();
			Console.WriteLine(userinput);
			Console.WriteLine("userinput{0}   length:{1}", userinput,userinput.Length);
			Console.WriteLine("userinput{0}  \n  length:{1}",userinput,userinput.Length);
			Console.WriteLine("userinput\t{0}  \n  length:{1}", userinput, userinput.Length);//插入tab
		}
    }
}
