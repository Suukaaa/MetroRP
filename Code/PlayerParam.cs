using Sandbox;

public sealed class PlayerParam : Component
{
	[Property] private int Health;

	public int GetHealth()
	{
		return Health;
	}
	public void SetHealth(int NewHealth)
	{
		Health = NewHealth;
	}

	public void IncrementHealth(int NewHealth)
	{
		Health += NewHealth;
	}

	public void DecrementHealth(int NewHealth)
	{
		Health -= NewHealth;
	}
}
