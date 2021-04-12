using System;
using System.Linq;
using System.Collections.Generic;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;
using System.Text;

namespace OnlineShop.Models.Products.Computers
{
    public abstract class Computer : Product, IComputer
    {
        private readonly ICollection<IComponent> components;
        private readonly ICollection<IPeripheral> peripherals;

        public Computer(int id, string manufacturer, string model, decimal price, double overallPerformance)
            : base(id, manufacturer, model, price, overallPerformance)
        {
            components = new List<IComponent>();
            peripherals = new List<IPeripheral>();
        }

        public IReadOnlyCollection<IComponent> Components => components.ToList().AsReadOnly();

        public IReadOnlyCollection<IPeripheral> Peripherals => peripherals.ToList().AsReadOnly();

        public override double OverallPerformance
            => components.Count == 0 ? base.OverallPerformance : components.Average(a => a.OverallPerformance) + base.OverallPerformance;

        public override decimal Price => base.Price + Components.Sum(p => p.Price) + Peripherals.Sum(p => p.Price);               

        public void AddComponent(IComponent component)
        {
            if (components.Any(x => GetType().Name == component.GetType().Name))
            {
                throw new ArgumentException($"Component {component.GetType().Name} already exists in {GetType().Name} with Id {Id}.");
            }

            components.Add(component);
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            if (peripherals.Any(x => x.GetType().Name == peripheral.GetType().Name))
            {
                throw new ArgumentException($"Peripheral {peripheral.GetType().Name} already exists in {GetType().Name} with Id {Id}.");
            }

            peripherals.Add(peripheral);
        }

        public IComponent RemoveComponent(string componentType)
        {
            //check
            IComponent removed = components.FirstOrDefault(x => x.GetType().Name == componentType);
            if (removed == null)
            {
                throw new ArgumentException($"Component {componentType.GetType().Name} does not exist in { GetType().Name} with Id {Id}.");
            }

            components.Remove(removed);
            return removed;
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            IPeripheral removed = peripherals.FirstOrDefault(x => x.GetType().Name == peripheralType);

            if (removed == null)
            {
                throw new ArgumentException($"Peripheral {peripheralType.GetType().Name} does not exist in {GetType().Name} with Id {Id}.");
            }

            peripherals.Remove(removed);
            return removed;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine($" Components ({components.Count}):");

            foreach (IComponent item in components)
            {
                result.AppendLine($"  {item}");
            }
            double averageOverallPerformancePeripherals = peripherals.Count == 0 ? 0 : peripherals.Average(op => op.OverallPerformance);
            
            result.AppendLine($" Peripherals({ peripherals.Count}); Average Overall Performance({ averageOverallPerformancePeripherals}):");

            foreach (IPeripheral item in peripherals)
            {
                result.AppendLine($"  {item}");
            }

            return result.ToString().TrimEnd();
        }
    }
}
