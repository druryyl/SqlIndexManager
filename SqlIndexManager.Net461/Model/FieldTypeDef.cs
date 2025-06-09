namespace SqlIndexManager.Net461.Model
{
    public class FieldTypeDef
    {
        public FieldTypeDef(string fieldType, int length, int scale)
        {
            if (fieldType == "varchar" && length == -1)
                fieldType = "text";
            
            if (fieldType == "decimal" && length == 9)
                length = 18;
            FieldType = fieldType;
            Length = length;
            Scale = scale;
        }
        public string FieldType { get; private set; }
        public int Length { get; private set; }
        public int Scale { get; private set; }
        public override string ToString()
        {
            return $"{FieldType}({Length}, {Scale})";
        }
        public static bool IsEqual(FieldTypeDef a, FieldTypeDef b)
        {
            if (a == null && b == null) return true;
            if (a == null || b == null) return false;
            return a.FieldType == b.FieldType && a.Length == b.Length && a.Scale == b.Scale;
        }
    }
}
