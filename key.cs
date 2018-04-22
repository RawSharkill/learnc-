using System;
using System.Threading;

namespace key
{
    class Program
    {
		private static void Console_CancelKeyPress(object sender,ConsoleCancelEventArgs e)
		{
			var isCtrlC = e.SpecialKey == ConsoleSpecialKey.ControlC;
			var isCtrlBreak = e.SpecialKey == ConsoleSpecialKey.ControlBreak;
			if(isCtrlC || isCtrlBreak)
			{
				e.Cancel = true;//屏蔽掉
				Console.WriteLine(isCtrlC ? "ctrl+c 已经被屏蔽" : "ctrl+break 已经被屏蔽掉");
			}
		}
        static void Main(string[] args)
        {
			UseCancelKeypress();

		}
		static void testkey()
		{
			Console.WriteLine("随意敲任意键查看其键值，按esc退出");
			ConsoleKeyInfo key;
			do
			{
				while (!Console.KeyAvailable) { }
				key = Console.ReadKey(true);
				Console.WriteLine();
				Console.WriteLine("modifiers值={0}", key.Modifiers);
				Console.WriteLine("keychar值={0}", (int)key.KeyChar);
				Console.WriteLine("key值={0}", key.Key);
				if (Console.CapsLock)
				{
					Console.WriteLine("处于大写状态");
				}
				if (Console.NumberLock)//numlock是不可以被捕获的
				{
					Console.WriteLine("小键盘上的numlock键被按下");
				}
				if (key.Modifiers != 0)
				{
					if ((key.Modifiers & ConsoleModifiers.Alt) != 0)
						Console.WriteLine("alt 被按下");
					if ((key.Modifiers & ConsoleModifiers.Shift) != 0)
						Console.WriteLine("shift被按下");
					if ((key.Modifiers & ConsoleModifiers.Control) != 0)
						Console.WriteLine("control被按下");
				}
			} while (key.Key != ConsoleKey.Escape);
			Console.WriteLine("检测到esc并退出");
		}
		static void quit()
		{
			Console.WriteLine("死循环，按ctrl+c 或者 ctrl+break 退出程序");
			//Console.TreatControlCAslnput=true;
			while (true)
			{
				Console.WriteLine("当前时间：" + DateTime.Now.ToLocalTime());
				Thread.Sleep(2000);
			}
		}
		static void UseCancelKeypress()
		{
			Console.WriteLine("本程序只能通过esc退出");
			//当ctrl+c 或者 strl+break 被按下时，响应
			Console.CancelKeyPress += Console_CancelKeyPress;
			do
			{
				var key = Console.ReadKey(true);
				if (key.Key == ConsoleKey.Escape)
					break;
				if (key.KeyChar != '\0')
				{
					if (key.Key== ConsoleKey.Enter)
						Console.WriteLine();
					else
						Console.WriteLine(key.KeyChar);
				}
			} while (true);
		}
    }
}
