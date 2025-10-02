namespace Facade.src
{
    internal class Salmon : Animal
    {
        public Salmon() { }

        override
        public void move()
        {
            Console.WriteLine("Salmon swims");
        }

        override
        public void makeNoise()
        {
            Console.WriteLine("Blub Blub");
        }
    }
}
