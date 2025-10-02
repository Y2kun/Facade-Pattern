namespace Facade.src
{
    internal class Tuna : Animal
    { 
        public Tuna() { }

        override
        public void move()
        {
            Console.WriteLine("Tuna swims");
        }

        override
        public void makeNoise()
        {
            Console.WriteLine("Blob Blob");
        }
    }
}
