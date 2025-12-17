namespace ProniaTask1.Models
{
    public class Blog
    {
        public int Id { get; internal set; }
        public string Title { get; internal set; }
        public int DateTime { get; internal set; }
        public string Description { get; internal set; }
        public int Order { get; internal set; }
        public string Image { get; internal set; }
    }
}