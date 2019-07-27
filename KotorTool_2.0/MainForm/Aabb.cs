using System.Diagnostics;

namespace KotorTool_2._0.MainForm
{

    [DebuggerDisplay("AAbb Left = {_left}")]
    [DebuggerDisplay("AAbb Right = {_right}")]
    [DebuggerDisplay("AAbb Face = {_face}")]
    [DebuggerDisplay("AAbb Index = {_index}")]
    public class Aabb
    {

        private int _left;
        private int _right;
        private int _face;
        private int _index;


       
        /// <summary>
        /// -------  This method needs to be checked out, not sure what this is I believe its flags for mdl files ------
        /// </summary>
        /// <param name="node"></param>
        /// <param name="aabbArray"></param>
        private void SetAabbNode(ref Aabb node, Aabb[] aabbArray)
        {


            if (_index > aabbArray.Length) return;


            if (node._face == -1)
            {
                _index = _index + 1;
                node._left = _index;
                SetAabbNode(ref aabbArray[_index], aabbArray);
                _index = _index + 1;
                node._right = _index;
                SetAabbNode(ref aabbArray[_index], aabbArray);
            }
            else
            {
                node._left = -1;
                node._right = -1;
            }
        }

    }
}