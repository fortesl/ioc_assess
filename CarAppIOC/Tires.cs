namespace CarAppIOC
{
    public class Tires
    {
        private ILog _log;

        public Tires(ILog log)
        {
            this._log = log;
        }

        public void Rotate()
        {
            this._log.Write("Tires rotated");
        }

    }
}
