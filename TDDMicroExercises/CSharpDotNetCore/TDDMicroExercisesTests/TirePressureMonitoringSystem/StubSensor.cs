using TDDMicroExercises.TirePressureMonitoringSystem;

namespace TDDMicroExercisesTests.TirePressureMonitoringSystem
{
  public class StubSensor : Sensor
  {
    private double _popNextPressurePsiValue;

    public StubSensor(double popNextPressurePsiValue)
    {
      _popNextPressurePsiValue = popNextPressurePsiValue;
    }

    public double PopNextPressurePsiValue()
    {
      return _popNextPressurePsiValue;
    }
  }
}