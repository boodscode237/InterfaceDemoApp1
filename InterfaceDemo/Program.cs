using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    // Interface is a contract
    // Classes implement interfaces
    // It gives a shape and a number of props, then the class that wants to use it must respect it.
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IComputerController> controllers = new List<IComputerController>();

            Keyboard keyboard = new Keyboard();
            GameController gameController = new GameController();
            BatteryPoweGameController batteryGc = new BatteryPoweGameController();
            BatteryPowerKeyBoard batteryKb = new BatteryPowerKeyBoard();

            controllers.Add(keyboard);
            controllers.Add(gameController);
            controllers.Add(batteryGc);

            foreach (IComputerController controller in controllers)
            {
                controller.Connect();
                if (controller is GameController gc)
                {
                   
                }

                if (controller is IBatteryPowered power)
                {
                    
                }
            }

            using (GameController gc = new GameController())
            {

            }

            List<IBatteryPowered> powerds = new List<IBatteryPowered>();

            powerds.Add(batteryGc);
            powerds.Add(batteryKb);


            Console.ReadLine();
        }
    }

    public interface IComputerController : IDisposable, IBatteryPowered
    {
        void Connect();
        void CurrentKeyPressed();
    }

    public class Keyboard : IComputerController
    {
        public void Connect()
        {

        }

        public void CurrentKeyPressed()
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public string ConnectionType { get; set; }
        public int BatteryLevel { get; set; }
    }

    public class BatteryPowerKeyBoard : Keyboard, IBatteryPowered
    {
        public int BatteryLevel { get; set; }
    }

    public interface IBatteryPowered
    {
        int BatteryLevel { get; set; }
    }

    public class GameController : IComputerController, IDisposable
    {
        public int BatteryLevel { get; set; }

        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void CurrentKeyPressed()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }

    public class BatteryPoweGameController : GameController, IBatteryPowered
    {
        public int BatteryLevel { get; set; }

    }
}
