* vs编写GUI程序
--
* 两种桌面应用
 托管桌面应用 c#编写的，云星宇CLR
 非托管的  c/c++开发，直接运行于windows操作系统
 
*新建windows窗体应用程序

修改按键名字，选中公共空间，在右下角的资源管理器中
`Text`修改名称

* 折叠代码
#region"code region"
...
#endregion

* 修改程序图标
选中`properties`双击，找到图标选项，在浏览中选择图标。

*windows窗体控件
--

* `button`
`text`为按键显示的内容<br>
`(name)`一般取名字为btn+功能的名字,为控件类的对象<br>
`click事件`，选择右下角“闪电图标”进入事件面板，找到“click”点击进入响应代码运行；或者双击图标。<br>
`image`属性，制定显示的图标，本地资源导入； 或者双击`properties`，选择资源，添加现有文件，然后选中图标，在image中选择项目资源文件，<br>
`testimagerelation`属性，调整文本和图像的位置<br>
`flatstyle`属性<br>
`flatappearance`设置特性，边框，尺寸，鼠标移入颜色，按下颜色...<br>

* `label`<br>
`text`为显示的内容<br>
`click事件`，选择右下角“闪电图标”进入事件面板，找到“click”点击进入响应代码运行；或者双击图标。<br>
`font`属性，便签事件字体<br>
`forncolor`颜色<br>
`autosize`当标签文本内容改变时，标签伸缩<br>
`backcolor`背景色，透明背景色，选择web,transparent<br>
`backgroudimage`改变窗体背景<br>
`image`设置标签图标<br>
`imagealign`修改图标位置<br>
`testalign`修改文字位置<br>
用标签显示： `标签名字.Text=string.Format("",c);`<br>

* `testbox`<br>
`textchanged`当用户输入时被触发，用代码实现，将输入在标签中显示<br>
```
private void txtuserinput_textchanged(object sender,eventargs)
{
    lbinfo.Text=txtuserinout.Text;
}
```

* 特定的控件在不同场景，会触发不同的事件<br>
1.控件触发那些事件？<br>
2.顺序是怎么样的？<br>
3.我选择那些事件进行响应<br>

*`progressBar`<br>
`value`当前完成百分比<br>
`maximum``minimum`最大值最小值<br>

*`Timer`<br>
定时调用<br>
`interval`定时间隔（100=0.1秒） 激发tick事件<br>
`tick`事件<br>

