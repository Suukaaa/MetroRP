using Sandbox;

public sealed class Event : Component, PlayerController.IEvents
{

	[Property]
	public PlayerController MyController { get; set; }

	void PlayerController.IEvents.OnLanded( float distance, Vector3 impactVelocity )
	{
		Log.Info("Land");
		PlayerController.Body;
	}
}
