namespace SimpleFactoryPattern
{
    public class AnimalFactory
    {
        public static IAnimal CreateAnimal(string animal)
        {
            if (animal == "Lion")
            {
                return new Lion();
            }
            if (animal == "Rat")
            {
                return new Rat();
            }

            // add additional logic if Lion needs other complex objects
            //return new Lion();
            return null;
        }
    }
}
