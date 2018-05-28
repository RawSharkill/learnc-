using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			//Class1 c = new Class1();//声明类库里的对象，然后调用他的public 变量和方法
			//c.x = 10;
			//c.Show();
			//Console.WriteLine(c.x);
			//object1 o1 = new object1();
			//object1 o2 = new object1();
			//Console.WriteLine(o1 == o2);//是否引用相同对象
			//Console.WriteLine(o1.Equals(o2));//字段值是否一样

			////***string为引用类型
			//string str1 = "hello";
			//string str2 = "hello";
			//Console.WriteLine(str1 == str2);//经过了==的重写，与equals相同
			//Console.WriteLine(str1.Equals(str2));//判断字符串是否一样

			/*只读类测试*/
			//Myreadonly o1 = new Myreadonly();
			//Myreadonly o2 = o1.add(1);
			//Console.WriteLine(o1 == o2);
			//o1.print();
			//o2.print();

			Console.WriteLine(Staticclass.staticstring());//用类名调用
			
		}
	}
	class object1
	{
		public int value;
		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;
			else
			{
				if(obj is object1)
				{
					return this.value == (obj as object1).value;
				}
			}
			return false;
		}
		public override int GetHashCode()
		{
			return value;
		}
	}

	//只读类测试
class Myreadonly
{
	private int value = 100;
	public Myreadonly add(int s)
	{
		Myreadonly obj = new Myreadonly();
		obj.value = this.value;
		obj.value += s;
		return obj;
	}
	public void print()
	{
		Console.WriteLine(value);
	}
}

	//定义自己的静态类
	class Staticclass
	{
		public static int field = 100;
		public static string staticstring()
		{
			return "hello";
		}
		//静态私有成员，要在静态构造方法或直接赋初值
		private static int f = 10;
		//静态构造方法
		static Staticclass() {
			f = 100;
		}
		//实例字段
		public int d = 0;
		//静态方法
		public static void fd()
		{
			Staticclass s = new Staticclass();//静态方法访问实例变量要实例化对象
			s.d++;
			s.add();
		}
		//实例方法
		public void add()
		{
			f++;
			d++.
		}
	}
}




