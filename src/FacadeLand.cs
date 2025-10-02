namespace Facade.src
{
	public class FacadeLand
	{
	    private Animal cat;
	    private Animal dog;

	    public FacadeLand()
	    {
	        cat = new Cat();
	        dog = new Dog();
	    }

	    // Simplified method for land animals to make noise
	    public void MakeLandAnimalsNoise()
	    {
	        cat.makeNoise();
	        dog.makeNoise();
	    }

	    // Simplified method for land animals to move
	    public void MoveLandAnimals()
	    {
	        cat.move();
	        dog.move();
	    }
	}
}
