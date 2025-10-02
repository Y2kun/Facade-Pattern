using Facade.src;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalFacade animalFacade = new AnimalFacade();
            animalFacade.MakeAllAnimalsNoise();
            animalFacade.MoveAllAnimals();
        }
    }
}
