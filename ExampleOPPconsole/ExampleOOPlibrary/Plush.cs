namespace ExampleOOPlibrary
{
    public class Plush
    {
        // First way to do getters and setters
        public int IdPlush { get; set; }
        public float Size { get; set; }

        // Second way to do getters and setters
        private string date;
        private string name;

        public string GetDate() { return date; }
        public void SetDate(string date) { this.date = date; }

        public string GetName() { return name; }
        public void SetName(string name) { this.name = name; }


        // Constructor
        public Plush (int idPlush, float size, string date, string name)
        {
            this.IdPlush = idPlush;
            this.Size = size;

            this.SetDate(date);
            this.SetName(name);
        }
    }
}
