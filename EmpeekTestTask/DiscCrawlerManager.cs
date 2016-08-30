using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpeekTestTask
    {
    class DiscCrawlerManager
        {

        public DiscCrawlerManager (string path,params string [] toDo)
            {
            if ( toDo.Length > 0 )
                {
                if ( path.Length == 3 )
                    {
                    path = "SERVERDRIVESINFO";
                    }
                int LastIndexOfSlash = path.LastIndexOf ('\\');

                if ( ( LastIndexOfSlash == path.Length - 1 ) & ( !( ( path.Length == 3 ) & ( path.EndsWith (":\\") ) ) ) )
                    {
                    path = path.Remove (LastIndexOfSlash);
                    }

                int a = path.LastIndexOf ('\\');
                if ( path.LastIndexOf ('\\') > 0 )
                    {
                    path = path.Remove (path.LastIndexOf ('\\'));
                    }
                }

            if ( ( path.Length == 2 ) & ( path.EndsWith (":") ) )
                {
                path += '\\';
                }
            this.dc = new DiscCrawler (path);
            }

        DiscCrawler dc;

        internal DiscCrawler Dc
            {
            get
                {
                return dc;
                }

            }
        }
    }
