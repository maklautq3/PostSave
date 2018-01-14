using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsFormsApplication2
{
    class Helper
    {

        public static string TaskSave(String ObjID,String FileSavePath,String WebKitFormBoundaryText)
        {
            ///DirPath + "/" + cbTasks.Text
            String FullSaveText = "";
            using (StreamReader sr = new StreamReader(FileSavePath))
            {
                String line = sr.ReadToEnd();
                FullSaveText = FullSaveText+WebKitFormBoundaryText;
                FullSaveText = FullSaveText+"\n\n"+line;
                FullSaveText = FullSaveText+"\n"+"------WebKitFormBoundaryqSVflN08a0RnZNAB--";
                FullSaveText = FullSaveText.Replace("ObjID", ObjID);
            }

            return FullSaveText;
        }
    }
}
