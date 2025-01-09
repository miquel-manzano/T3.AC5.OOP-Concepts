namespace ExampleOOPlibrary
{
    public class Monster : Plush
    {
        public string Description { get; set; }
        public string Hat {  get; set; }

        public Monster (string description, string hat, int idPlush, float size, string date, string name) : base (idPlush, size, date, name)
        {
            this.Description = description;
            this.Hat = hat;
        }
    }
}
