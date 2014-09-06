using DevDay.Mobile.WP8.Data.Agenda;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevDay.Mobile.WP8.Data
{
    public static class DataHelper
    {
        public static void CreateVote(Lecture lecture)
        {
            var local = IsolatedStorageFile.GetUserStoreForApplication();

            if (!local.DirectoryExists("DataFolder"))
            {
                local.CreateDirectory("DataFolder");
            }

            using (var isoFileStream = new IsolatedStorageFileStream("DataFolder\\" + lecture.IdLecture + ".txt", FileMode.OpenOrCreate, local))
            {
                using (var isoFileWriter = new StreamWriter(isoFileStream))
                {
                    isoFileWriter.WriteLine("Voted");
                }
            }

        }

        public static bool ReadVote(Lecture lecture)
        {
            var local = IsolatedStorageFile.GetUserStoreForApplication();

            if (!local.DirectoryExists("DataFolder"))
            {
                local.CreateDirectory("DataFolder");
            }
            if (local.FileExists("DataFolder\\" + lecture.IdLecture + ".txt"))
            {
                using (var isoFileStream = new IsolatedStorageFileStream("DataFolder\\" + lecture.IdLecture + ".txt", FileMode.Open, local))
                {
                    using (var isoFoleReader = new StreamReader(isoFileStream))
                    {
                        if (isoFoleReader.ReadLine().Contains("Voted"))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;

        }
    }
}
