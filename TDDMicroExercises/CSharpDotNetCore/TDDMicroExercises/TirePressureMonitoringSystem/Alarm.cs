namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm
    {
        private const double LowPressureThreshold = 17;
        private const double HighPressureThreshold = 21;

        private readonly Sensor _sensor;
        private readonly Control _control;

        bool _alarmOn = false;

        public Alarm() : this (new RandomSensor(), new Control(LowPressureThreshold, HighPressureThreshold, new RandomSensor())) {}

        public Alarm(Sensor sensor, Control control)
        {
            _sensor = sensor;
            _control = control;
        }

        public void Check()
        {
            double psiPressureValue = _sensor.PopNextPressurePsiValue();

            if (psiPressureValue < LowPressureThreshold || HighPressureThreshold < psiPressureValue)
            {
                _alarmOn = true;
            }
        }

        public bool AlarmOn
        {
            get { return _alarmOn; }
        }
    }
}
