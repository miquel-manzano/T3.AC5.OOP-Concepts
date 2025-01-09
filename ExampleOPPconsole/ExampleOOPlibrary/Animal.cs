namespace ExampleOOPlibrary
{
    public class Animal : Plush
    {
        public string Race { get; set; }
        public string Fur {  get; set; }


        public Animal (string race, string fur, int idPlush, float size, string date, string name) : base(idPlush, size, date, name)
        {
            this.Race = race;
            this.Fur = fur;
        }
    }
}
