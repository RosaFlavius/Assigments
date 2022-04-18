using System;


namespace MyApp 
{

    public abstract class AutoVehicle
    {
        public string TypeOfAutoVehicle { get; }
        public string DateOfFabrication { get; }
        public AutoVehicle(string typeOfAutoVehicle, string dateOfFabrication)
        {
            TypeOfAutoVehicle = typeOfAutoVehicle;
            DateOfFabrication = dateOfFabrication;
        }
        


        public override string ToString()
        {
            return "AutoVehicle " + TypeOfAutoVehicle + " created in " + DateOfFabrication;
        }
    }

    public abstract class Car : AutoVehicle
    {
        private int horsePower;
        public Car(string typeOfAutoVehicle, string dateOfFabrication, int horsePower) : base(typeOfAutoVehicle, dateOfFabrication)
        {
            this.horsePower = horsePower;
        }

        public int NumberOfWheels { get { return horsePower; } set { horsePower = value; } }

        public abstract void automaticPilot();
        public abstract void manualPilot();


    }

    public abstract class MotorCycle : AutoVehicle
    {
        public MotorCycle(string typeOfAutoVehicle, string dateOfFabrication) : base(typeOfAutoVehicle, dateOfFabrication){}


        //Overloading method
        public virtual void refuel() { }
        public virtual void refuel(int amount) { }
    }

    public class Tesla : Car
    {
        public Tesla(string typeOfAutoVehicle, string dateOfFabrication, int horsePower) : base(typeOfAutoVehicle, dateOfFabrication, horsePower){}

        public override void automaticPilot()
        {
            Console.WriteLine("Automatic pilot mode activated");
        }

        public override void manualPilot()
        {
            Console.WriteLine("Automatic pilot mode deactivated");
        }
    }

    public class HarleyDavidson : MotorCycle
    {
        public HarleyDavidson(string typeOfAutovehicle, string dateOfFabrication) : base(typeOfAutovehicle, dateOfFabrication){}

        public override void refuel()
        {
            Console.WriteLine(this.TypeOfAutoVehicle + " needs a refuel");
        }

        public override void refuel(int amount)
        {
            Console.WriteLine($"Refueling {amount} liters");
        }
    }


    internal class Program
    {

        static void Main(string[] args)
        {
            var car1 = new Tesla("Model3", "2012", 140);

            var car2 = new HarleyDavidson("Modelx", "2018");

            var car3 = new Tesla("ModelS", "2012", 140);

            car1.automaticPilot();
            car3.manualPilot();

            car2.refuel();
            car2.refuel(100);

        }
    }
}