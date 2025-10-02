namespace Facade.src
{
	public class FacadeAir
	{
	    private Animal crow;
	    private Animal pigeon;

	    public FacadeAir()
	    {
	        crow = new Crow();
	        pigeon = new Pigeon();
	    }

	    // Simplified method for air animals to make noise
	    public void MakeAirAnimalsNoise()
	    {
	        crow.makeNoise();
	        pigeon.makeNoise();
	    }

	    // Simplified method for air animals to move
	    public void MoveAirAnimals()
	    {
	        crow.move();
	        pigeon.move();
	    }
	}
}
