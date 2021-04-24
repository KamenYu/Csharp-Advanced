namespace FactoryMethodPattern.Contracts
{
    public interface IAnimalFactory
    {
        public ICarnivore GetCarnivore();

        // in abstract factory pattern , here we have more than one Ic

        //public IHerbivore GetHerbivore();
        //public IOmnivore GetOmnivore(); ...
    }
}
