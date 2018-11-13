using KotorTool_2._0.Options;
using KotorTool_2._0.ViewModels;

namespace KotorTool_2._0.MainForm
{
    public class KotorNodeRepo
    {
        public KotorTreeNode RootKotorNode { get; set; }
        public KotorTreeNode KotorBifNode { get; set; }
        public KotorTreeNode KotorRimNode { get; set; }
        public KotorTreeNode KotorErfNode { get; set; }
        public KotorTreeNode KotorSavesNode { get; set; }
        
        public KotorTreeNode RootKotorTslNode { get; set; }
        public KotorTreeNode KotorTslBifNode { get; set; }
        public KotorTreeNode KotorTslRimNode { get; set; }
        public KotorTreeNode KotorTslErfNode { get; set; }
        public KotorTreeNode KotorTslSavesNode { get; set; }
        
        public KotorNodeRepo()
        {
            RootKotorNode = new KotorTreeNode("Kotor I");
            RootKotorNode.Tag = "Kotor1";
            RootKotorNode.FilePath = ConfigOptions.Paths.DefaultKotorLocation;
            
            RootKotorTslNode = new KotorTreeNode("Kotor II");
            RootKotorTslNode.Tag = "Kotor2";
            RootKotorTslNode.FilePath = ConfigOptions.Paths.DefaultKotorTslLocation;
            
            //InitKotorChildrenNodes();
            //InitKotorTslChildrenNodes();
        }

         
        public void InitKotorChildrenNodes()
        {
            KotorBifNode = new KotorTreeNode("BIFs") {Tag = "BIFF_Root", FilePath = ConfigOptions.Paths.DefaultKotorLocation + "\\data"};
            KotorTreeNode kotorTreeNode2 = new KotorTreeNode("") {Tag = "dummy"};
            KotorBifNode.Nodes.Add(kotorTreeNode2);
            RootKotorNode.Nodes.Add(KotorBifNode);

           
            KotorRimNode  = new KotorTreeNode("RIMs") {Tag = "RIM_Root", FilePath = ConfigOptions.Paths.DefaultKotorLocation + "\\Modules"};
            KotorTreeNode kotorTreeNode4 = new KotorTreeNode("Modules") {Tag = "RIM_Modules"};
            KotorTreeNode kotorTreeNode5 = new KotorTreeNode("") {Tag = "dummy"};
            kotorTreeNode4.Nodes.Add(kotorTreeNode4);
            KotorRimNode.Nodes.Add(kotorTreeNode5);

            
            KotorTreeNode kotorTreeNode6 = new KotorTreeNode("Rims") {Tag = "RIM_Rims"};
            KotorTreeNode kotorTreeNode7 = new KotorTreeNode("") {Tag = "dummy"};
            kotorTreeNode6.Nodes.Add(kotorTreeNode7);
            KotorRimNode.Nodes.Add(kotorTreeNode6);
            RootKotorNode.Nodes.Add(KotorRimNode);

            
            KotorErfNode = new KotorTreeNode("ERFs") {Tag = "ERF_Root", FilePath = ConfigOptions.Paths.DefaultKotorLocation + "\\texturePacks"};
            KotorTreeNode kotorTreeNode9 = new KotorTreeNode("TexturePacks") {Tag = "ERF_TexturePacks"};
            KotorTreeNode kotorTreeNode10 = new KotorTreeNode("") {Tag = "dummy"};
            kotorTreeNode9.Nodes.Add(kotorTreeNode10);
            KotorErfNode.Nodes.Add(kotorTreeNode9);
            RootKotorNode.Nodes.Add(KotorErfNode);

            KotorTreeNode kotorTreeNode11 = new KotorTreeNode("Modules") {Tag = "ERF_Modules"};
            KotorTreeNode kotorTreeNode12 = new KotorTreeNode("") {Tag = "dummy"};
            kotorTreeNode11.Nodes.Add(kotorTreeNode12);
            KotorErfNode.Nodes.Add(kotorTreeNode11);
           

            
            KotorSavesNode = new KotorTreeNode("Saves") {Tag = "Saves_Root", FilePath = ConfigOptions.Paths.DefaultKotorLocation + "\\Saves"};
            KotorTreeNode kotorTreeNode14 = new KotorTreeNode("") {Tag = "dummy"};
            KotorSavesNode.Nodes.Add(kotorTreeNode14);
            RootKotorNode.Nodes.Add(KotorSavesNode);
        }
        
        
         public void InitKotorTslChildrenNodes()
        {
            KotorTslBifNode = new KotorTreeNode("BIFs") {Tag = "BIFF_Root", FilePath = ConfigOptions.Paths.DefaultKotorTslLocation + "\\data"};
            KotorTreeNode kotorTreeNode2 = new KotorTreeNode("") {Tag = "dummy"};
            KotorTslBifNode.Nodes.Add(kotorTreeNode2);
            RootKotorTslNode.Nodes.Add(KotorTslBifNode);

           
            KotorTslRimNode  = new KotorTreeNode("RIMs") {Tag = "RIM_Root", FilePath = ConfigOptions.Paths.DefaultKotorTslLocation + "\\Modules"};
            KotorTreeNode kotorTreeNode4 = new KotorTreeNode("Modules") {Tag = "RIM_Modules"};
            KotorTreeNode kotorTreeNode5 = new KotorTreeNode("") {Tag = "dummy"};
            kotorTreeNode4.Nodes.Add(kotorTreeNode5);
            KotorTslRimNode.Nodes.Add(KotorTslRimNode);

            
            KotorTreeNode kotorTreeNode6 = new KotorTreeNode("Rims") {Tag = "RIM_Rims"};
            KotorTreeNode kotorTreeNode7 = new KotorTreeNode("") {Tag = "dummy"};
            kotorTreeNode6.Nodes.Add(kotorTreeNode7);
            KotorRimNode.Nodes.Add(kotorTreeNode6);
            RootKotorNode.Nodes.Add(KotorTslRimNode);

            
            KotorTslErfNode = new KotorTreeNode("ERFs") {Tag = "ERF_Root", FilePath = ConfigOptions.Paths.DefaultKotorTslLocation + "\\texturePacks"};
            KotorTreeNode kotorTreeNode9 = new KotorTreeNode("TexturePacks") {Tag = "ERF_TexturePacks"};
            KotorTreeNode kotorTreeNode10 = new KotorTreeNode("") {Tag = "dummy"};
            kotorTreeNode9.Nodes.Add(kotorTreeNode10);
            KotorTslErfNode.Nodes.Add(kotorTreeNode9);
            RootKotorTslNode.Nodes.Add(KotorTslErfNode);

            
            KotorTreeNode kotorTreeNode11 = new KotorTreeNode("Modules") {Tag = "ERF_Modules"};
            KotorTreeNode kotorTreeNode12 = new KotorTreeNode("") {Tag = "dummy"};
            kotorTreeNode11.Nodes.Add(kotorTreeNode12);
            KotorTslErfNode.Nodes.Add(kotorTreeNode11);

            
            KotorTslSavesNode = new KotorTreeNode("Saves") {Tag = "Saves_Root", FilePath = ConfigOptions.Paths.DefaultKotorTslLocation + "\\Saves"};
            KotorTreeNode kotorTreeNode14 = new KotorTreeNode("") {Tag = "dummy"};
            KotorTslSavesNode.Nodes.Add(kotorTreeNode14);
            RootKotorTslNode.Nodes.Add(KotorTslSavesNode);
        }
    }
}