namespace DefaultNamespace;

public class FootballPlayer
{
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Position { get; set; }
        public string Nation { get; set; }
        public string Club { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Rating} Rating - {Position} - {Nation} - {Club}";
        }
    }
}