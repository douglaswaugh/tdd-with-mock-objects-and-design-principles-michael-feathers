﻿using System;
namespace TDDMicroExercises.OneSolution.TelemetrySystem.SomeDependencies
{
    public class TelemetryDiagnosticControlsClient1
    {
		// A class with the only goal of simulating a dependency on TelemetryDiagnosticControls
		// that has impact on the refactoring.

		public TelemetryDiagnosticControlsClient1()
        {
            var teleDiagnostic = new TelemetryDiagnosticControls();

            teleDiagnostic.CheckTransmission();

            var result = teleDiagnostic.DiagnosticInfo;
        }
    }
}
