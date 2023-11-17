namespace JusProcessos.Models
{
    public class Thor
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public Thor(int id, string name)
        {
            Id = id;
            Name = name;
        }   
    }
}
