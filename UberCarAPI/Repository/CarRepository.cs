using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UberCarAPI.Models;

namespace UberCarAPI.Repository
{
    public class CarRepository
    {
        public static List<Models.Car> Cars;

        public static void GenerateData()
        {
            CarRepository.Cars = new List<Models.Car>();

            CarRepository.Cars.Add(new Models.Car()
            {
                Id = 1,
                Model = "Etios",
                Brand = "Toyota",
                Color = "Black",
                FabricationYear = 2018,
                Plate = "1234-ABS",
                IsLuxe = true,
                HasAc = true,
                UberCategory = "Black"
            });

            CarRepository.Cars.Add(new Models.Car()
            {
                Id = 2,
                Model = "Sandeiro",
                Brand = "Renault",
                Color = "Gray",
                FabricationYear = 2019,
                Plate = "1324-OOB",
                IsLuxe = false,
                HasAc = true,
                UberCategory = "X"
            });

            CarRepository.Cars.Add(new Models.Car()
            {
                Id = 3,
                Model = "GT-500",
                Brand = "Mustang",
                Color = "Black",
                FabricationYear = 2019,
                Plate = "1029-BWE",
                IsLuxe = true,
                HasAc = true,
                UberCategory = "Black"
            });
        }
    }
}
