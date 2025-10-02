namespace Facade.src
{
	public class AnimalFacade
	{
	    private Animal cat;
	    private Animal crow;
	    private Animal dog;
	    private Animal pigeon;
	    private Animal salmon;
	    private Animal tuna;

	    public AnimalFacade()
	    {
	        cat = new Cat();
	        crow = new Crow();
	        dog = new Dog();
	        pigeon = new Pigeon();
	        salmon = new Salmon();
	        tuna = new Tuna();
	    }

	    // Simplified method to make all animals make noise
	    public void MakeAllAnimalsNoise()
	    {
	        cat.makeNoise();
	        crow.makeNoise();
	        dog.makeNoise();
	        pigeon.makeNoise();
	        salmon.makeNoise();
	        tuna.makeNoise();
	    }

	    // Simplified method to make all animals move
	    public void MoveAllAnimals()
	    {
	        cat.move();
	        crow.move();
	        dog.move();
	        pigeon.move();
	        salmon.move();
	        tuna.move();
	    }
	}
}
