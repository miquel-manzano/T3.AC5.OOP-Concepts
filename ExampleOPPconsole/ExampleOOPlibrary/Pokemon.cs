namespace ExampleOOPlibrary
{
    public class Pokemon : Plush
    {
        public string type { get; set; }
        public bool shiny { get; set; }


        public Pokemon (string type, bool shiny, int idPlush, float size, string date, string name) : base(idPlush, size, date, name)
        {
            this.type = type;
            this.shiny = shiny;
        }
    }
}
