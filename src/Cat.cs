namespace Facade.src
{
    internal class Cat : Animal
    {
        public Cat() { }

        override
        public void move()
        {
            Console.WriteLine("Cat runs");
        }

        override
        public void makeNoise()
        {
            Console.WriteLine("Meow");
        }
    }
}
