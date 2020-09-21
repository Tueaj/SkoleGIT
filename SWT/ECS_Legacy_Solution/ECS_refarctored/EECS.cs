using ECS_refarctored;

namespace ECS.refarctored
{
    public class EECS
    {
        private int _threshold;
        private readonly ITempSensor _tempSensor;
        private readonly IHeater _heater;

        public EECS(int thr, ITempSensor TS, IHeater H)
        {
            SetThreshold(thr);
            _tempSensor = TS;
            _heater = H;
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < _threshold)
                _heater.TurnOn();
            else
                _heater.TurnOff();

        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }

        public int GetCurTemp()
        {
            return _tempSensor.GetTemp();
        }

        public bool RunSelfTest()
        {
            return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        }
    }
}
