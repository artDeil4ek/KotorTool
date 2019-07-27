namespace KotorTool_2._0.MainForm
{
    public class Aabb
    {
        private int Left;
        private int Right;
        private int Face;
        private int index;

        private void SetAabbNode(ref Aabb node, Aabb[] aabbArray)
        {
            if (index > aabbArray.Length) return;
            if (node.Face == -1)
            {
                index = index + 1;
                node.Left = index;
                SetAabbNode(ref aabbArray[index], aabbArray);
                index = index + 1;
                node.Right = index;
                SetAabbNode(ref aabbArray[index], aabbArray);
            }
            else
            {
                node.Left = -1;
                node.Right = -1;
            }
        }

    }
}