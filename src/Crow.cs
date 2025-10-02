namespace Facade.src
{
    internal class Crow : Animal
    {
        public Crow() { }

        override
        public void move()
        {
            Console.WriteLine("Crow Flighs");
        }

        override
        public void makeNoise()
        {
            Console.WriteLine("Caw Caw");
        }
    }
}
