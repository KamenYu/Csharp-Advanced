using System;
using System.Collections.Generic;
using System.Linq;

using OnlineShop.Common.Enums;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Peripherals;

namespace OnlineShop.Core
{
    public class Controller : IController
    {
        private List<IComputer> computers;
        private List<IPeripheral> peripherals;
        private List<IComponent> components;
        private const string COMPUTER_DOESNT_EXIST = "Computer with this id does not exist.";

        public Controller()
        {
            computers = new List<IComputer>();
            peripherals = new List<IPeripheral>();
            components = new List<IComponent>();
        }

        public string AddComponent(int computerId, int id, string componentType,
            string manufacturer, string model, decimal price,
            double overallPerformance, int generation)
        {
            ComponentType cType = new ComponentType();
            IComponent component = null;

            if (DoesComputerExist(computerId))
            {
                throw new ArgumentException(COMPUTER_DOESNT_EXIST);
            }             
            else if (computers.Where(x => x.Id == computerId).Any(x => x.Components.Any(x =>x.Id == id)))
            {
                throw new ArgumentException("Component with this id already exists.");
            }
            else if (!Enum.TryParse<ComponentType>(componentType, out cType))
            {
                throw new ArgumentException("Component type is invalid.");
            }
            else if (cType == ComponentType.CentralProcessingUnit)
            {
                component = new CentralProcessingUnit(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (cType == ComponentType.Motherboard)
            {
                component = new Motherboard(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (cType == ComponentType.PowerSupply)
            {
                component = new PowerSupply(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (cType == ComponentType.RandomAccessMemory)
            {
                component = new RandomAccessMemory(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (cType == ComponentType.SolidStateDrive)
            {
                component = new SolidStateDrive(id, manufacturer, model, price, overallPerformance, generation);
            }
            else if (cType == ComponentType.VideoCard)
            {
                component = new VideoCard(id, manufacturer, model, price, overallPerformance, generation);
            }

            components.Add(component);
            IComputer computer = computers.Where(x => x.Id == computerId).FirstOrDefault();
            computer.AddComponent(component);
            return $"Component {component.GetType().Name} with id {component.Id} added successfully in computer with id {computer.Id}.";
        }

        public string AddComputer(string computerType, int id, string manufacturer, string model, decimal price)
        {
            ComputerType cType = new ComputerType();
            IComputer computer = null;

            if (!DoesComputerExist(id))
            {
                throw new ArgumentException("Computer with this id already exists.");
            }
            else if (!Enum.TryParse<ComputerType>(computerType, out cType))
            {
                throw new ArgumentException("Computer type is invalid.");
            }
            else if(cType == ComputerType.DesktopComputer)
            {
                computer = new DesktopComputer(id, manufacturer, model, price);
            }
            else if (cType == ComputerType.Laptop)
            {
                computer = new Laptop(id, manufacturer, model, price);
            }

            computers.Add(computer);
            return $"Computer with id {computer.Id} added successfully.";

        }

        public string AddPeripheral(int computerId, int id, string peripheralType,
            string manufacturer, string model, decimal price, double overallPerformance, string connectionType)
        {
            PeripheralType pType = new PeripheralType();
            IPeripheral peripheral = null;

            if (DoesComputerExist(computerId))
            {
                throw new ArgumentException(COMPUTER_DOESNT_EXIST);
            }
            else if(computers.Where(x => x.Id == computerId).Any(x => x.Peripherals.Any(x => x.Id == id)))
            {
                throw new ArgumentException("Peripheral with this id already exists.");
            }
            else if (!Enum.TryParse<PeripheralType>(peripheralType, out pType))
            {
                throw new ArgumentException("Peripheral type is invalid.");
            }
            else if (pType == PeripheralType.Headset)
            {
                peripheral = new Headset(id, manufacturer, model, price, overallPerformance, connectionType);
            }
            else if (pType == PeripheralType.Keyboard)
            {
                peripheral = new Keyboard(id, manufacturer, model, price, overallPerformance, connectionType);
            }
            else if (pType == PeripheralType.Monitor)
            {
                peripheral = new Monitor(id, manufacturer, model, price, overallPerformance, connectionType);
            }
            else if (pType == PeripheralType.Mouse)
            {
                peripheral = new Mouse(id, manufacturer, model, price, overallPerformance, connectionType);
            }

            peripherals.Add(peripheral);
            computers.Where(i => i.Id == computerId).FirstOrDefault().AddPeripheral(peripheral);

            return $"Peripheral {peripheral.GetType().Name} with id { peripheral.Id} added successfully in computer with id {computerId}.";
        }

        public string BuyBest(decimal budget)
        {
            IComputer best = computers
                .OrderByDescending(x => x.OverallPerformance)
                .FirstOrDefault(p => p.Price <= budget);

            if (best == null)
            {
                throw new ArgumentException($"Can't buy a computer with a budget of ${budget}.");
            }

            computers.Remove(best);
            return best.ToString();
        }

        public string BuyComputer(int id)
        {
            if (DoesComputerExist(id))
            {
                throw new ArgumentException(COMPUTER_DOESNT_EXIST);
            }

            IComputer bought = computers.Where(i => i.Id == id).FirstOrDefault();
            computers.Remove(bought);
            return bought.ToString();
        }

        public string GetComputerData(int id)
        {
            if (DoesComputerExist(id))
            {
                throw new ArgumentException(COMPUTER_DOESNT_EXIST);
            }

            return computers.Where(i => i.Id == id).FirstOrDefault().ToString();
        }

        public string RemoveComponent(string componentType, int computerId)
        {
            if (DoesComputerExist(computerId))
            {
                throw new ArgumentException(COMPUTER_DOESNT_EXIST);
            }

            //IComponent component = computers
            //    .Where(x => x.Id == computerId)
            //    .FirstOrDefault()
            //    .RemoveComponent(componentType);

            IComponent component = components.FirstOrDefault(c => c.GetType().Name == componentType);
            IComputer computer = computers.First(c => c.Id == computerId);

            if (components.Count == 0 || component == null)
            {
                return null;
            }

            components.Remove(component);
            computer.RemoveComponent(componentType);
            return $"Successfully removed {component.GetType().Name} with id {component.Id}.";
        }

        public string RemovePeripheral(string peripheralType, int computerId)
        {
            if (DoesComputerExist(computerId))
            {
                throw new ArgumentException(COMPUTER_DOESNT_EXIST);
            }

            //IPeripheral peripheral = computers
            //   .Where(x => x.Id == computerId)
            //   .FirstOrDefault()
            //   .RemovePeripheral(peripheralType);


            IPeripheral peripheral = peripherals.FirstOrDefault(c => c.GetType().Name == peripheralType);
            IComputer computer = computers.First(c => c.Id == computerId);

            if (peripheral == null || peripherals.Count == 0)
            {
                return null;
            }

            peripherals.Remove(peripheral);
            computer.RemovePeripheral(peripheralType);

            return $"Successfully removed {peripheral.GetType().Name} with id { peripheral.Id}.";
        }

        private bool DoesComputerExist(int compID)
             => !computers.Any(x => x.Id == compID);
    }   
}
