using KotorTool_2._0.Models.BIFF;
using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Ui.ImageViewer;
using KotorTool_2._0.ViewModels;

namespace KotorTool_2._0
{
    public static class Constants
    {
        public static FrmImageViewer GImageViewer;
        public static ChitinKeyProvider Gk1ChitinKey;
        public static ChitinKeyProvider Gk2ChitinKey;
        public static BiffArchive Gk1TemplatesBif;
        public static BiffArchive Gk2TemplatesBif;
        public static Options.ConfigOptions CurrentSettings;

        public static System.Drawing.Font StarWarsFont;

        public static void MAKE_STAR_WARS_FONT()
        {
            System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
            pfc.AddFontFile("C:\\Users\\Steve\\Documents\\Visual Studio 2017\\Projects\\KotorTool_2.0\\KotorTool_2.0\\Resources\\Starjedi.ttf");
            StarWarsFont = new System.Drawing.Font(pfc.Families[0], 20, System.Drawing.FontStyle.Regular);
        }
    }
}
