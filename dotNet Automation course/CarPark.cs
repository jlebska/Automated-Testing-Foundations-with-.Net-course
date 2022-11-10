
using dotNet_Automation_course.CustomExceptions;
using dotNet_Automation_course.Vehicles;
using System.Reflection;

namespace dotNet_Automation_course
{
    public class CarPark
    {
        public Dictionary<string,Vehicle> VehicleLog
        {
            get;set;
        }

        int defaultId = 0;

        public CarPark()
        {
            VehicleLog = new Dictionary<string,Vehicle>();
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
                VehicleLog.Add(id, vehicle);
            }
            catch(ArgumentException e)
            {
                throw new AddException(e.Message);
            }
        }

        public List<Vehicle> GetAutoByParameter(string parameter, string value)
        {
            List<Vehicle> vehicles = VehicleLog.Values.ToList();
            List<Vehicle> found = new List<Vehicle>();
            PropertyInfo? property = null;

            foreach (Vehicle vehicle in vehicles)
            {
                property = vehicle.GetType().GetProperty(parameter);
                if(property != null)
                {
                    if (property.GetValue(vehicle).ToString().Equals(value))
                    {
                        found.Add(vehicle);
                    }
                }
            }

            if (found.Count == 0)
            {
                if (property == null)
                {
                    throw new GetAutoByParameterException($"Provided parameter \"{parameter}\" doesn't exist in the scope.");
                }
                else
                {
                    throw new GetAutoByParameterException($"No vehicle with the value of the parameter \"{parameter}\" equal to \"{value}\".");
                }
            }

            return found;
        }

        public void UpdateAuto(string id, Vehicle vehicle)
        {
            if (VehicleLog.ContainsKey(id))
            {
                VehicleLog[id] = vehicle;
            }
            else
            {
                throw new UpdateAutoException($"No vehicle with provided id={id}.");
            }
        }


        public void RemoveAuto(string id)
        {
            if (VehicleLog.ContainsKey(id))
            {
                VehicleLog.Remove(id);
            }
            else
            {
                throw new RemoveAutoException($"No vehicle with provided id={id}.");
            }
        }


    }
}
