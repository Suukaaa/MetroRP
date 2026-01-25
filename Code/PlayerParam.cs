using Sandbox;

public sealed class PlayerParam : Component
{
	[Property] public HealthTable Health { get; private set; }
	[Property] public ShieldTable Shield { get; private set; }
	[Property] public StaminaTable Stamina { get; private set; }
	[Property] public RadiationTable Radiation { get; private set; }
	[Property] public OxygenTable Oxygen { get; private set; }
	[Property] public MadnessTable Madness { get; private set; }
	[Property] public DiseaseTable Disease { get; private set; }
	[Property] public FearTable Fear { get; private set; }

	protected override void OnAwake()
	{
		Health ??= new HealthTable();
		Shield ??= new ShieldTable();
		Stamina ??= new StaminaTable();
		Radiation ??= new RadiationTable();
		Oxygen ??= new OxygenTable();
		Madness ??= new MadnessTable();
		Disease ??= new DiseaseTable();
		Fear ??= new FearTable();
	}
}

// -------- BASE TEMPLATE --------
public abstract class StatTable
{
	[Property] protected int Value;

	public int Get() => Value;
	public void Set(int v) => Value = v;
	public void Increment(int v) => Value += v;
	public void Decrement(int v) => Value -= v;
}

// -------- STATS --------
public sealed class HealthTable : StatTable { }
public sealed class ShieldTable : StatTable { }
public sealed class StaminaTable : StatTable { }
public sealed class RadiationTable : StatTable { }
public sealed class OxygenTable : StatTable { }
public sealed class MadnessTable : StatTable { }
public sealed class DiseaseTable : StatTable { }
public sealed class FearTable : StatTable { }
