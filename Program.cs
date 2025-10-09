using Facade.src;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Land Animals:");
            FacadeLand landFacade = new FacadeLand();
            landFacade.MakeLandAnimalsNoise();
            landFacade.MoveLandAnimals();
            Console.WriteLine("Sea Animals:");
            FacadeSea seaFacade = new FacadeSea();
            seaFacade.MakeSeaAnimalsNoise();
            seaFacade.MoveSeaAnimals();
            Console.WriteLine("Air Animals:");
            FacadeAir airFacade = new FacadeAir();
            airFacade.MakeAirAnimalsNoise();
            airFacade.MoveAirAnimals();
        }
    }
}
