using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    public class Planet
    {

        //private variables for all the properties of the planets
        private string name;
        private double mass;
        private double diameter;
        private double density;
        private double gravity;
        private double rotationPeriod;
        private double lengthOfDay;
        private double distanceFromSun;
        private double orbitalPeriod;
        private double orbitalVelocity;
        private double meanTemperature;
        private double numberOfMoons;
        private bool ringSystem;

        //All getters and setters for the properties of the planets
        #region GettersAndSetters
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double Mass
        {
            get
            {
                return mass;
            }
            set
            {
                mass = value;
            }
        }
        public double Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }
        public double Density
        {
            get
            {
                return density;
            }
            set
            {
                density = value;
            }
        }
        public double Gravity
        {
            get
            {
                return gravity;
            }
            set
            {
                gravity = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return rotationPeriod;
            }
            set
            {
                rotationPeriod = value;
            }
        }
        public double LengthOfDay
        {
            get
            {
                return lengthOfDay;
            }
            set
            {
                lengthOfDay = value;
            }
        }
        public double DistanceFromSun
        {
            get
            {
                return distanceFromSun;
            }
            set
            {
                distanceFromSun = value;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return orbitalPeriod;
            }
            set
            {
                orbitalPeriod = value;
            }
        }
        public double OrbitalVelocity
        {
            get
            {
                return orbitalVelocity;
            }
            set
            {
                orbitalVelocity = value;
            }
        }
        public double MeanTemperature
        {
            get
            {
               return meanTemperature;
            }
            set
            {
                meanTemperature = value;
            }
        }
        public double NumberOFMoons
        {
            get
            {
                return numberOfMoons;
            }
            set
            {
                numberOfMoons = value;
            }
        }
        public bool RingSystem
        {
            get
            {
                return ringSystem;
            }
            set
            {
                ringSystem = value;
            }
        }
        #endregion


        //Constructor for the Planet class, which is made so you cannot instantiate a new planet without giving the data of all of the properties 
        #region PlanetValues
        public Planet(string planetName, double planetMass, double planetDiameter, double planetDensity, double planetGravity, double planetRotationPeriod, double planetLengthOfDay, 
            double planetDistanceFromSun, double planetOrbitalPeriod, double planetOrbityVelocity, double planetMeanTemperature, double planetNumberOfMoons, bool planetRingSystem)
        {
            name = planetName;
            mass = planetMass;
            diameter = planetDiameter;
            density = planetDensity;
            gravity = planetGravity;
            rotationPeriod = planetRotationPeriod;
            lengthOfDay = planetLengthOfDay;
            distanceFromSun = planetDistanceFromSun;
            orbitalPeriod = planetOrbitalPeriod;
            orbitalVelocity = planetOrbityVelocity;
            meanTemperature = planetMeanTemperature;
            numberOfMoons = planetNumberOfMoons;
            ringSystem = planetRingSystem;
        }
        #endregion


    }
}
