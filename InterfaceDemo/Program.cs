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

            controllers.Add(keyboard);
            controllers.Add(gameController);

            foreach (IComputerController controller in controllers)
            {
                controller.Connect();
            }

            using (GameController gc = new GameController())
            {

            }

            Console.ReadLine();
        }
    }

    public interface IComputerController
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
        public string ConnectionType { get; set; }

    }

    public class GameController : IComputerController, IDisposable
    {
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

        public int BatteryLevel { get; set; }
    }
}
