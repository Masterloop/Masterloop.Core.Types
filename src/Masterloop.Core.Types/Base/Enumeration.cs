namespace Masterloop.Core.Types.Base
{
    public class EnumerationItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class EnumerationGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EnumerationItem[] Items { get; set; }
    }
}