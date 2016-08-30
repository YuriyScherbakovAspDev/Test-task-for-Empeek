using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpeekTestTask
    {
    class DiscCrawler
        {

        string path;

        public DiscCrawler (string path)
            {
            try
                {
                if ( string.IsNullOrEmpty (path) || ( ( path.Length == 2 ) & ( path.EndsWith (":") ) ) )
                    {
                    this.path += Directory.GetCurrentDirectory ();
                    }
                else
                    {
                    this.path = path;
                    }
                DirectoryInfo dirInfo = new DirectoryInfo (this.path);

                this.listOfFiles = dirInfo.GetFiles ().ToList ();
                this.listOfDirectories = dirInfo.GetDirectories ().ToList ();

                CrawThroughAllDirectories (dirInfo);


                }
            catch ( Exception ex )
                {
                this.path = "Remote SERVER";
                this.listOfDrives = DriveInfo.GetDrives ().ToList ();
                foreach ( var drive in this.ListOfDrives )
                    {
                    //if ( drive.Name == "D:\\" ) Для ускорения тестирования отключаем большие диски 
                    //    {
                    //    continue;
                    //    }
                    CrawThroughAllDirectories (drive.RootDirectory);

                    }
                }

            }


        uint lessThan10Mb;
        uint between10MbAnd50Mb;
        uint moreThan100Mb;



        public uint LessThan10Mb
            {
            get
                {
                return lessThan10Mb;
                }
            }
        public uint Between10MbAnd50Mb
            {
            get
                {
                return between10MbAnd50Mb;
                }
            }
        public uint MoreThan100Mb
            {
            get
                {
                return moreThan100Mb;
                }
            }

        List<FileInfo> listOfFiles = new List<FileInfo> ();
        List<DirectoryInfo> listOfDirectories = new List<DirectoryInfo> ();
        List<DriveInfo> listOfDrives = new List<DriveInfo> ();


        public List<DirectoryInfo> ListOfDirectories
            {
            get
                {
                return listOfDirectories;
                }
            }

        public List<FileInfo> ListOfFiles
            {
            get
                {
                return listOfFiles;
                }
            }

        public string Path
            {
            get
                {
                return this.path;
                }
            }

        public List<DriveInfo> ListOfDrives
            {
            get
                {
                return listOfDrives;
                }

            }

        void CrawThroughAllDirectories (DirectoryInfo dirInfo)
            {

            DirectoryInfo [] dirInfoArr;
            try
                {
                dirInfoArr = dirInfo.GetDirectories ();
                }
            catch
                {
                return;
                }

            foreach ( var dir in dirInfoArr )
                {
                CrawThroughAllDirectories (dir);
                }

            foreach ( var file in dirInfo.GetFiles () )
                {
                try
                    {
                    uint fileSize = (uint)( file.Length / 1024f / 1024f );
                    if ( fileSize < 10 )
                        {
                        ++lessThan10Mb;
                        }
                    else if ( fileSize > 10 && fileSize < 50 )
                        {
                        ++between10MbAnd50Mb;
                        }
                    else if ( fileSize > 100 )
                        {
                        ++moreThan100Mb;
                        }

                    }
                catch ( PathTooLongException pathTooLong )
                    {

                    }
                }
            }
        }
    }
