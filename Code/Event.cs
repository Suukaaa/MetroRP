using System.Dynamic;
using System.Net.Mail;
using Microsoft.VisualBasic;
using Sandbox;
using Sandbox.Audio;

public sealed class Event : Component, PlayerController.IEvents
{

	[Property] public PlayerController MyController { get; set; }

	private PlayerParam playerParam;

		protected override void OnUpdate()
	{
		Log.Info ("coucou");
	}
	protected override void OnStart()
	{
		
		playerParam = GameObject.Components.Get<PlayerParam>();
		playerParam.SetHealth(100);
	}
	
	void PlayerController.IEvents.OnJumped()
	{

	}


}
