using Sandbox;

public sealed class PlayerInfo : Component
{
	[Property]
	public int Health {get; set;}
	protected override void OnStart()
	{
		Health = 200;
	}
}
