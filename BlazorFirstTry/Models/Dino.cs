namespace BlazorFirstTry.Models
{
    public class Dino
    {
        public Dino(int dinoID, string spece, double weight, double size)
        {
            DinoID = dinoID;
            Spece = spece;
            Weight = weight;
            Size = size;
        }

        public int DinoID { get; set; }
        public string Spece { get; set; }
        public double Weight { get; set; }
        public double Size { get; set; }
    }
}
