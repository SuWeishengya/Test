using System;
using System.IO;

namespace SAMFiles
{
    class SAMFiles
    {
        static void Main(string[] args)
        {
            //执行分类和拷贝
            SortAndCopy();
        }

        /// <summary>
        /// 分类和拷贝
        /// </summary>
        private static void SortAndCopy()
        {
            // 指定源文件夹路径
            string sourceFolderPath = @"E:\Study\SAMFilesTest";

            // 指定目标文件夹路径
            string targetFolderPath = @"E:\Study\SAMFilesTest\Sort";

            // 源文件夹为当前运行目录
            //string sourceFolderPath = Directory.GetCurrentDirectory();
            //string targetFolderPath = sourceFolderPath + "\\Sort";

            // 若目标文件夹存在，删除目标文件夹
            if (Directory.Exists(targetFolderPath)) Directory.Delete(targetFolderPath, true);

            // 指定源文件夹中总文件数
            int allCount = Directory.GetFiles(sourceFolderPath, "*", SearchOption.AllDirectories).Length;
            // 当前移动了多少文件 计数
            int curCount = 0;

            // 遍历所有文件和子文件夹中的文件
            foreach (string filePath in Directory.GetFiles(sourceFolderPath, "*", SearchOption.AllDirectories))
            {

                // 判断是否为文件夹
                if (Directory.Exists(filePath))
                {
                    continue; // 如果是文件夹，则跳过
                }

                //判断是否是目标文件夹
                if (filePath.IndexOf(targetFolderPath) > -1)
                {
                    continue;//如果是目标文件夹，则跳过
                }

                // 获取文件后缀
                string fileExtension = Path.GetExtension(filePath);

                // 根据后缀名创建文件夹
                string destinationFolder = Path.Combine(targetFolderPath, fileExtension.TrimStart('.'));
                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                }

                // 拷贝文件到目标文件夹
                string fileName = Path.GetFileName(filePath);
                string destinationPath = Path.Combine(destinationFolder, fileName);

                if (File.Exists(destinationPath)) File.Delete(destinationPath);
                File.Copy(filePath, destinationPath, true);

                curCount++;
                Console.WriteLine($"Moved file {fileName} to {destinationFolder}({curCount}/{allCount}).");
            }

            Console.WriteLine("All files are sorted.");
        }
    }
}
