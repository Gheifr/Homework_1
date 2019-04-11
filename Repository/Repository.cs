using System;
using System.Collections.Generic;
using System.Text;

namespace DBCOnnection_IFC
{
    public class Repository
    {
        string Name;
        string RepositaryPath;

        public Repository()
        {
        }

        public void SaveFile(string FilePath, bool SaveToDisk, bool SaveFileInfoToDB, string DBPath = null)
        {
            if (FilePath == null)
            {
                Console.WriteLine("No file chosen!");
                Console.ReadKey();
                return;
            }
            
            if (SaveToDisk == true)
            {
                //saving to disk
            }

            if (SaveFileInfoToDB == true)
            {
                //saving file info to DBPath
            }
        }
        public void GetFile()
        {

        }
    }
}
