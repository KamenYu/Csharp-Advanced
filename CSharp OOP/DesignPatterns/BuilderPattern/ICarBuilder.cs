using System;
namespace BuilderPattern
{
    public interface ICarBuilder
    {
        //void BuildTyres(Car car);

        //void BuildEngine(Car car);

        //void BuildDoors(Car car); -> BuulderPattern

        //FluentAPI
        ICarBuilder BuildTyres(Car car);

        ICarBuilder BuildEngine(Car car);

        ICarBuilder BuildDoors(Car car);
    }
}
