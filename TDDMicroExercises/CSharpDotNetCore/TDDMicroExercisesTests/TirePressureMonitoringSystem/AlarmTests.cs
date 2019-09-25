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

            var alarm = new Alarm(sensor);

            alarm.Check();

            Assert.That(alarm.AlarmOn, Is.True);
        }
    }
}