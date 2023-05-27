# Test

Learn to use Github Deskktop

##### 2023.3.14 日志

1. 配置好了 vscode C#的开发环境
2. 注册了新的代码仓库 并在 vscode 中配置好
3. 练习了如何用 vscode 来新建一个解决方案
   新建一个解决方案
   新建一个类库 一个控制台应用 并为控制台应用添加类的引用
4. 熟悉了一些 dotnet 指令
   dotnet new sln 新建一个解决方案
   dotnet new console --use-program-main 以旧的结构生成
   dotnet sln add 为项目添加 remove 为项目删除
   -o 会生成子文件夹 -n 在当前目录下
   cd.. 直接回上一级目录
   ctrl +c kill 进程
5. 将修改提交到代码仓库
6. 新增.gitignore 文件，忽略不重要的文件修改

##### 2023.3.15 日志

撤销“已经提交到本地仓库的文件”的追踪 git rm --cached -r 表示递归所有子文件夹

**2023.5.27 日志**

新增 SAMFiles 解决方案 SAMFiles
（SortAndMoveFiles）文件分类移动程序（根据文件后缀名将文件进行分类并且将文件移动到对应的文件夹下）

目标：

- 带图形界面，源文件夹和目标文件夹可以通过下拉框选择
- 源文件夹下的子文件目录可以遍历访问
- 可以选择是复制到目标文件夹后是否删除源文件夹目录

初版利用 ChatGPT 直接生成代码（源文件夹、目标文件夹直接指定，源文件夹没有遍历访问）
