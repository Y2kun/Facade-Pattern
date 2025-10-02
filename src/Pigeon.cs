namespace Facade.src
{
    internal class Pigeon : Animal
    {
        public Pigeon() { }

        override
        public void move()
        {
            Console.WriteLine("Pidgeon walks");
        }

        override
        public void makeNoise()
        {
            Console.WriteLine("Coo Coo");
        }
    }
}
