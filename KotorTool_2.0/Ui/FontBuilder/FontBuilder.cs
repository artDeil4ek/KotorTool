using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KotorTool_2._0.Ui.FontBuilder
{
    public class FontBuilder
    {


        private String _filePathToFont;
        private Font _font;


        public FontBuilder()
        {

        }


        /// <summary>
        /// Static call for making the font here
        /// </summary>
        /// <returns></returns>
        public static FontBuilder Build()
        {
            return new FontBuilder();
        }


        /// <summary>
        /// ---File Path should contain a TTF File
        /// ---- I.E. "C:\Users\Resources\Starjedi.ttf"
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public FontBuilder SetFilePath(String path)
        {
            _filePathToFont = path;
            return this;
        }


        /// <summary>
        /// ---File Path should contain a TTF File
        /// ---- I.E. "C:\Users\Resources\Starjedi.ttf"
        /// </summary>
        /// <param name="pathFunc"></param>
        /// <returns></returns>
        public FontBuilder SetFilePath(Func<String> pathFunc)
        {
            _filePathToFont = pathFunc.Invoke();
            return this;
        }

        /// <summary>
        /// build and return the font here
        /// </summary>
        /// <returns></returns>
        public Font BuildAndPresentFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(_filePathToFont);
            _font = new Font(pfc.Families[0], 20, FontStyle.Regular);

            return _font;
        }

     

    }
}
