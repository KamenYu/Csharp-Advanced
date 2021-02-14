using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> data;

        public Clinic(int capacity)
        {
            Capacity = capacity;
            data = new List<Pet>();
        }

        public int Capacity { get; set; }
        public int Count { get { return data.Count; } }

        public void Add(Pet pet)
        {
            if (data.Count < Capacity)
            {
                data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            Pet pet = data.FirstOrDefault(x => x.Name == name);

            if (pet == null)
            {
                return false;
            }

            return true;
        }

        public Pet GetPet(string name, string owner)
        {
            Pet pet = data.FirstOrDefault(x => x.Name == name && x.Owner == owner);
            return pet;
        }

        public Pet GetOldestPet()
        {
            Pet oldest = data.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldest;
        }

        public string GetStatistics()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("The clinic has the following patients:");

            foreach (Pet pet in data)
            {
                result.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return result.ToString().Trim();
        }
    }
}
