using System;
using System.IO;

namespace SAMFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // 设置源文件夹路径和目标文件夹路径
            string sourceFolderPath = @"E:\Study\SAMFilesTest";
            string targetFolderPath = @"E:\Study\SAMFilesTest\Sort";

            // 遍历所有文件
            DirectoryInfo di = new DirectoryInfo(sourceFolderPath);
            foreach (FileInfo file in di.GetFiles())
            {
                // 获取文件后缀名
                string extension = file.Extension.ToLowerInvariant();

                // 创建目标文件夹
                string targetFolder = Path.Combine(targetFolderPath, extension.Substring(1), file.Name);
                Directory.CreateDirectory(Path.GetDirectoryName(targetFolder));

                // 移动文件
                file.MoveTo(targetFolder);
            }
        }
    }
}