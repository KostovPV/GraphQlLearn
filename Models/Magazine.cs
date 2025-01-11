public class Magazine : IReadingMaterials, IThings 
{
    public string Name { get; set; }
    public BookGenre Genre { get; set; }
    public int IssieNo { get; set; }
}