namespace dhc;

public readonly record struct HealthCheckResultGuidance(HealthCheckResultGuidanceBloodPressure BloodPressureGuidance, HealthCheckResultGuidanceWeight WeightGuidance, SmokingGuidance SmokingGuidance);
