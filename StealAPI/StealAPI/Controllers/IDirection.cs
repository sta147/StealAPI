namespace StealAPI.Controllers
{
    public interface IDirection
    {
        int Bearing { get; set; }
        string Name { get; set; }
        int Count { get; set; }
    }
}