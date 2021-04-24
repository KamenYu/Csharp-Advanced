namespace BuilderPattern
{
    public class CarBuilder :ICarBuilder
    {
        //public void BuildDoors(Car car)
        //{
        //    car.Doors = "Open/Close";
        //}

        //public void BuildEngine(Car car)
        //{
        //    car.Engine = "Powerful";
        //}

        //public void BuildTyres(Car car)
        //{
        //    car.Tyres = "4";
        //} -> this is BuilderPattern

        //-> this is Fluent API

        public ICarBuilder BuildDoors(Car car)
        {
            car.Doors = "Open/Close";
            return this;
        }

        public ICarBuilder BuildEngine(Car car)
        {
            car.Engine = "Powerful";
            return this;
        }

        public ICarBuilder BuildTyres(Car car)
        {
            car.Tyres = "4";
            return this;
        }
    }
}
