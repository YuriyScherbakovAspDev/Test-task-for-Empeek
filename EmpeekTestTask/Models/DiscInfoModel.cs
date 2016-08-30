using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpeekTestTask.Models
    {
  public  class DiscInfoModel
        {
        public string Path
            {
            get; set;
            }
       
        public List<FileInfo> ListOfFiles
            {
            get
                {
                return listOfFiles;
                }

            set
                {
                this.listOfFiles = value;
                }
            }

        List<string> listOfDirectoriesString = new List<string> ();


        public List<string> ListOfDirectoriesString
            {
            get
                {
                return listOfDirectoriesString;
                }

            set
                {
                this.listOfDirectoriesString = value;
                }
            }


        public List<DirectoryInfo> ListOfDirectories
            {
            get
                {
                return listOfDirectories;
                }

            set
                {
                this.listOfDirectories = value;
                }
            }

        public List<DriveInfo> ListOfDrives
            {
            get
                {
                return listOfDrives;
                }

            set
                {
                this.listOfDrives = value;
                }
            }

        public uint LessThan10Mb
            {
            get
                {
                return lessThan10Mb;
                }

            set
                {
                this.lessThan10Mb = value;
                }
            }

        public uint Between10MbAnd50Mb
            {
            get
                {
                return between10MbAnd50Mb;
                }

            set
                {
                this.between10MbAnd50Mb = value;
                }
            }

        public uint MoreThan100Mb
            {
            get
                {
                return moreThan100Mb;
                }

            set
                {
                this.moreThan100Mb = value;
                }
            }

        uint lessThan10Mb;
        uint between10MbAnd50Mb;
        uint moreThan100Mb;

        List<FileInfo> listOfFiles = new List<FileInfo> ();
        List<DirectoryInfo> listOfDirectories = new List<DirectoryInfo> ();
        List<DriveInfo> listOfDrives = new List<DriveInfo> ();
        }
    }
