
using dotNet_Automation_course.CustomExceptions;
using dotNet_Automation_course.Vehicles;
using System.Reflection;

namespace dotNet_Automation_course
{
    public class CarPark
    {
        public Dictionary<string,Vehicle> ListOfAvaibleVehicles
        {
            get;set;
        }

        int defaultId = 0;

        public CarPark()
        {
            ListOfAvaibleVehicles = new Dictionary<string,Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle, string? id =null)
        {
            try
            {
                if (id == null)
                {
                    id = defaultId.ToString();
                    defaultId++;
                }
                ListOfAvaibleVehicles.Add(id, vehicle);
            }
            catch(ArgumentException e)
            {
                throw new AddException(e.Message);
            }
        }

        public int GetAutoByParameter(string parameter, string value)
        {

            var selected = ListOfAvaibleVehicles.Values.SelectMany(v => v.GetType().GetProperties()).Where(p => p.Name.Equals(parameter) && p.GetValue(parameter).Equals(value)).Count();

            return selected;
        }


    }
}
