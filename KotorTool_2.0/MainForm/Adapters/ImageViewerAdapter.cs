using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorTool_2._0.MainForm.Adapters
{
    public class ImageViewerAdapter<T>
    {

        private IList<T> _resourceData { get; set; }


        public ImageViewerAdapter()
        {

        }


        //Implementations


        public ImageViewerAdapter LoadFrom(FileStream fileStream)
        {



            return this;
        }


        public ImageViewerAdapter 
    }
}
