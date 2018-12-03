using System;

namespace KotorTool_2._0.Utils
{
    public class FlowUtils
    {
        public static void BasicIterator(int index, int endPoint, Action<int> action)
        {
            while (index <= endPoint)
            {
                action.Invoke(index);
                index++;
            }
        }
    }
}