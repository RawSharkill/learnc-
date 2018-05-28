# learncsharp
* namespace<br> 
类的仓库，.NET中所有的功能都有类提供，这些类愤懑别类的存放在特定的命名空间中。<br> 
命名空间可以多层嵌套<br> 
```
namesapce Mynamespace{
class myname{

}
namespace innnerspace{
class innername{
}
}
}

```

* 程序集<br> 
  `Assembly`程序集是.NET程序的基本构造块<br> 
  扩展名为 .dll<br> 
  `创建程序集`<br> 
  `类库`模板，创建一个dll程序集<br> 
  `使用程序集`<br> 
  在新项目中添加对于特定程序集的引用，即可使用程序集中的类<br> 
  ```
  //创建一个解决方案，然后创建一个类库
  //在同一个解决方案下，创建一个控制台应用，然后引用刚刚创建的类库
  ```
 
 `线程堆栈` <br>
 程序代码由线程负责，每个线程有保存临时数据的特定区域，为线程堆栈，关联的程序结束时，将全部销毁。
 `托管堆`<br>
 在整个程序结束时被全部销毁。<br>
 
 方法中定义的对象变量保存在线程堆栈里，对象生存于托管堆。<br>
 “类”类型的变量，属于“引用类型”的变量，内存位于“托管堆”中<br>
 int 之类的简单类型属于“值类型”的变量，方法内部定义的变量，内存位于“线程堆栈”中<br>
 `对象变量相互复制`引用相同的对象<br>
 
 `只读对象`<br>
 DateTime,string,等等<br>
 在多线程的环境下，使用制度对象提高程序性能。<br>
 `设计只读类`<br>
 
 `数组`<br>
 ```
 int[] arr=new int[3]{1,2,3};
 ```
 `重载，重写`<br>
 ```
 //重载
 public void overloadF(){}//父
 public void overloadF(int i）{}//子
 //重写覆盖
 public virtual void oveerrideF(){}//父
 public override void overrideF(){}//子
 
 ```
