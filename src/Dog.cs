namespace Facade.src
{
    internal class Dog : Animal
    {
        public Dog() { }

        override
        public void move()
        {
            Console.WriteLine("Dog walks");
        }

        override
        public void makeNoise()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
