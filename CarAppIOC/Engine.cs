using System;

namespace CarAppIOC
{
    public class Engine
    {
        private Tires _tires;
        private ILog _log;
        private int _id;

        public Engine(Tires tires, ILog log)
        {
            this._log = log;
            this._tires = tires;
            this._id = new Random().Next();
        }

        public void Ahead(int power)
        {
            this._tires.Rotate();

            this._log.Write($"Engine [{this._id}] ahead {power}");
        }
    }
}
