namespace TestItemNS
{
    public class TestItem
    {
        public int Id { get; set; }
        
        public string Name { get; set; } = string.Empty;
        
        public List<string> Tags { get; set; } = new();
        
        public bool IsActive { get; set; }
       
        public double Rating { get; set; }
    }

}