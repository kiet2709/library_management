using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LibraryManagement.Utils
{
    public class AppConstant
    {
        public static string getDirectory(int id, string folderName)
        {
           return "/uploads/" +folderName+"/"+id+".png";
        }

        public static string getFullDirectory(string imagePath)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            return projectDirectory + imagePath;
        }
    }
}
