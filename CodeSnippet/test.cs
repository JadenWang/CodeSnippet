
using System;

namespace Exmaple
{
    public class ExampleClass
    {
        public static void Main(string[] args)
        {
            FileManager fileManager = new FileManager("1", "12");
            fileManager.CountExceeded += Display.OnShowWarningInfo;
            fileManager.CountExceeded += Display.OnShowCurrentFileSize;
            fileManager.CountExceeded += (new Display()).OnShowBranchTagInfo;

            fileManager.ManageSize();

            Console.WriteLine("Please review the above info, thanks.");
        }
    }


    public class FileManager
    {
        public string branch;
        public string tag;
        private int fileSize;

        public delegate void CountExceededEventHandler(object sender, CountExceededEventArgs e);

        public event CountExceededEventHandler CountExceeded;


        public FileManager(string branch, string tag)
        {
            this.branch = branch;
            this.tag = tag;
        }

        public void ManageSize()
        {
            for (int i = 0; i <= 101; i++)
            {
                fileSize = i;
                if (fileSize == 101)
                {
                    CountExceededEventArgs e = new CountExceededEventArgs(fileSize);
                    OnCountExceeded(e);
                }
            }
        }

        public virtual void OnCountExceeded(CountExceededEventArgs e)
        {
            if (CountExceeded != null)
            {
                CountExceeded(this, e);
            }
        }
    }

    public class CountExceededEventArgs : EventArgs
    {
        public int fileSize;

        public CountExceededEventArgs(int fileSize)
        {
            this.fileSize = fileSize;
        }
    }

    public class Display
    {
        public Display() { }

        public static void OnShowWarningInfo(object sender, CountExceededEventArgs e)
        {
            Console.WriteLine("Warning: The current file size has exceeded 100 kb");
        }

        public static void OnShowCurrentFileSize(object sender, CountExceededEventArgs e)
        {
            Console.WriteLine("Info: The current file size is {0} kb", e.fileSize);
        }

        public void OnShowBranchTagInfo(object sender, CountExceededEventArgs e)
        {
            FileManager fm = sender as FileManager;
            if (fm != null)
            {
                Console.WriteLine("BranchTagInfo: The current file is in Branch {0} - Tag {1}", fm.branch, fm.tag);
            }
        }

    }

}





