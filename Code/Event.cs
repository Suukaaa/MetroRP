using Sandbox;

public sealed class Event : Component, PlayerController.IEvents
{

	[Property]
	public PlayerController MyController { get; set; }

	void PlayerController.IEvents.OnEyeAngles( ref Angles angles )
	{
		Log.Info("Angles");
	}
	void PlayerController.IEvents.PostCameraSetup( CameraComponent cam )
	{
		Log.Info("PostCameraEvents");
	}
	void PlayerController.IEvents.OnJumped()
	{
		Log.Info("Jump");
	}
	void PlayerController.IEvents.OnLanded( float distance, Vector3 impactVelocity )
	{
		Log.Info("Land");
	}
	void PlayerController.IEvents.StartPressing( Component target )
	{
		Log.Info("StartPress");
	}
	void PlayerController.IEvents.StopPressing( Component target )
	{
		Log.Info("StopPress");
	}
	void PlayerController.IEvents.FailPressing()
	{
		Log.Info("FailPress");
	}
}
