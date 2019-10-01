using TDDMicroExercises.TirePressureMonitoringSystem;
using NUnit.Framework;

namespace TDDMicroExercisesTests.TirePressureMonitoringSystem
{
    public class AlarmTests
    {
        [Test]
        public void Should_trigger_alarm_when_sensor_reports_pressure_below_threshold()
        {
            var sensor = new StubSensor(16);

            var alarm = CreateAlarm(sensor);

            alarm.Check();

            Assert.That(alarm.AlarmOn, Is.True);
        }

        [Test]
        public void Should_not_trigger_alarm_when_sensor_reports_pressure_at_or_above_threshold()
        {
            var sensor = new StubSensor(17);

            var alarm = CreateAlarm(sensor);

            alarm.Check();

            Assert.That(alarm.AlarmOn, Is.False);
        }

        private Alarm CreateAlarm(Sensor sensor)
        {
            return new Alarm(sensor);
        }
    }
}