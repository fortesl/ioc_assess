namespace CarAppIOC
{
    public class Car
    {
        private Engine _engine;
        private ILog _log;

        public Car(Engine engine, ILog log)
        {
            this._engine = engine;
            this._log = log;
        }

        public void Go()
        {
            this._engine.Ahead(100);
            _log.Write("Car going forward...");
        }

    }

}
