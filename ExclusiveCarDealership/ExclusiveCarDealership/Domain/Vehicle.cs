using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExclusiveCarDealership.Domain {
    public class Vehicle {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [MaxLength(500)]
        public string BriefDescription { get; set; }

        public string FullDescription { get; set; }

        public ElectricCar ElectricCar { get; set; }
        public GasCar GasCar { get; set; }
    }

    public interface IVehicle {
        Vehicle Base { get; set; }
    }

    public class ElectricCar : IVehicle{
        public int Id { get; set; }

        [Required]
        public Vehicle Base { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Range cannot be less than 0")]
        public int Range { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int ChargeTime { get; set; }
    }

    public class GasCar : IVehicle {
        public int Id { get; set; }

        [Required]
        public Vehicle Base { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int GaseMileage { get; set; }
    }
}