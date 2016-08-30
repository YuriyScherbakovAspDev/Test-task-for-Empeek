using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

using System.Web.Http;
using System.Web.Script.Serialization;

namespace EmpeekTestTask.Controllers
{
    public class DiscController : ApiController
    {
        public Models.DiscInfoModel GetDiscInfo()
            {
            DiscCrawlerManager discCrawlerManager = new DiscCrawlerManager ("");

            Models.DiscInfoModel discInfoModel = new Models.DiscInfoModel ();

            discInfoModel.Path = discCrawlerManager.Dc.Path;
            discInfoModel.LessThan10Mb = discCrawlerManager.Dc.LessThan10Mb;
            discInfoModel.Between10MbAnd50Mb = discCrawlerManager.Dc.Between10MbAnd50Mb;
            discInfoModel.MoreThan100Mb = discCrawlerManager.Dc.MoreThan100Mb;
            discInfoModel.ListOfDrives = discCrawlerManager.Dc.ListOfDrives ;
            discInfoModel.ListOfDirectories = discCrawlerManager.Dc.ListOfDirectories;
            discInfoModel.ListOfFiles = discCrawlerManager.Dc.ListOfFiles;
            return discInfoModel;
            }
        public Models.DiscInfoModel GetDiscInfo(string path)
            {
            DiscCrawlerManager discCrawlerManager = new DiscCrawlerManager (path);

            Models.DiscInfoModel discInfoModel = new Models.DiscInfoModel ();

            discInfoModel.Path = discCrawlerManager.Dc.Path;
            discInfoModel.LessThan10Mb = discCrawlerManager.Dc.LessThan10Mb;
            discInfoModel.Between10MbAnd50Mb = discCrawlerManager.Dc.Between10MbAnd50Mb;
            discInfoModel.MoreThan100Mb = discCrawlerManager.Dc.MoreThan100Mb;
            discInfoModel.ListOfDrives = discCrawlerManager.Dc.ListOfDrives;
            foreach ( var item in discInfoModel.ListOfDrives )
                {
                discInfoModel.ListOfDirectoriesString.Add (item.Name);
                }


            discInfoModel.ListOfDirectories = discCrawlerManager.Dc.ListOfDirectories;
            discInfoModel.ListOfFiles = discCrawlerManager.Dc.ListOfFiles;
            return discInfoModel;
            }
        [HttpPost]
        public Models.DiscInfoModel GetDiscInfoUP (string path)
            {
            DiscCrawlerManager discCrawlerManager = new DiscCrawlerManager (path, "UP");

            Models.DiscInfoModel discInfoModel = new Models.DiscInfoModel ();

            discInfoModel.Path = discCrawlerManager.Dc.Path;
            discInfoModel.LessThan10Mb = discCrawlerManager.Dc.LessThan10Mb;
            discInfoModel.Between10MbAnd50Mb = discCrawlerManager.Dc.Between10MbAnd50Mb;
            discInfoModel.MoreThan100Mb = discCrawlerManager.Dc.MoreThan100Mb;
            discInfoModel.ListOfDrives = discCrawlerManager.Dc.ListOfDrives;
            discInfoModel.ListOfDirectories = discCrawlerManager.Dc.ListOfDirectories;
            discInfoModel.ListOfFiles = discCrawlerManager.Dc.ListOfFiles;
            foreach ( var item in discInfoModel.ListOfDrives )
                {
                discInfoModel.ListOfDirectoriesString.Add (item.Name);
                }
            return discInfoModel;
            }
        }
    }
