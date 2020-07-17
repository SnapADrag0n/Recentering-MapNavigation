namespace MapSample1.Models
{
    public enum MenuItemType
    {
        BrowseMaps,
        About
    }

    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }
        public string Title { get; set; }
    }
}
