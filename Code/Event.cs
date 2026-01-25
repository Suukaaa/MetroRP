using Sandbox;

public sealed class Event : Component, PlayerController.IEvents
{

	[Property] public PlayerController MyController { get; set; }

	private GameObject parent;
	private PlayerParam playerParam;

	protected override void OnStart()
	{
		parent = GameObject.Parent;
		playerParam = parent.Components.Get<PlayerParam>();
		playerParam.SetHealth(0);
	}

	void PlayerController.IEvents.OnEyeAngles( ref Angles angles )
	{
		// laissez en commentaires ça s'execute en boucles
		//Log.Info("Angles");
	}
	void PlayerController.IEvents.PostCameraSetup( CameraComponent cam )
	{
		// laissez en commentaires ça s'execute en boucles
		//Log.Info("PostCameraEvents");
	}
	void PlayerController.IEvents.OnJumped()
	{
		playerParam.IncrementHealth(80);
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
