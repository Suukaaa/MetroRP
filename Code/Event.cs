using System.Dynamic;
using System.Net.Mail;
using Microsoft.VisualBasic;
using Sandbox;

public sealed class Event : Component, PlayerController.IEvents
{

	[Property]
	public PlayerController MyController { get; set; }

	[Property]
	public PlayerInfo PlayerInfo {get; set;}


	private bool alive = true;	
	private bool isAlive()
	{
		
		return alive;
	}
	void setHealth (int NewHealth)
	{
		PlayerInfo.Health = NewHealth;
	
	}
	public int getHealth ()
	{

		return PlayerInfo.Health;
	
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
		if (isAlive()){

			Log.Info("Jump");
			setHealth(getHealth()-100);
			Log.Info(getHealth());
			
			if ( getHealth() <= 0 )
			{
				Log.Info("t'es dead chackal");
				alive = false;
			}
			
		}


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
