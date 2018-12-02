namespace KotorTool_2._0.Models.GFF
{
    public class GffStruct
    {
        public int Type;
        public int FieldCount;
        public int DataOrDataOffset;
        public GffField[] Fields;

        public GffStruct()
        {
        }

        public GffStruct(int initialFieldCount)
        {
            FieldCount = initialFieldCount;
            Fields = new GffField[checked(initialFieldCount - 1 + 1)];
        }

        public GffStruct(int initialFieldCount, int structType) : this(initialFieldCount)
        {
            Type = structType;
        }
    }
}