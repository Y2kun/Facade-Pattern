namespace Facade.src
{
	public class FacadeSea
	{
	    private Animal tuna;
	    private Animal salmon;

	    public FacadeSea()
	    {
	        tuna = new Tuna();
	        salmon = new Salmon();
	    }

	    // Simplified method for sea animals to make noise
	    public void MakeSeaAnimalsNoise()
	    {
	        tuna.makeNoise();
	        salmon.makeNoise();
	    }

	    // Simplified method for sea animals to move
	    public void MoveSeaAnimals()
	    {
	        tuna.move();
	        salmon.move();
	    }
	}
}
