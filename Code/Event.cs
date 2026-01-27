using System.Dynamic;
using System.Net.Mail;
using Microsoft.VisualBasic;
using Sandbox;
using Sandbox.Audio;

public sealed class Event : Component, PlayerController.IEvents
{

	[Property] public PlayerController MyController { get; set; }

	private PlayerParam playerParam;

	private float Delay ;

	protected override void OnStart()
	{
		
		playerParam = GameObject.Components.Get<PlayerParam>();
		
	}

	protected override void OnUpdate()
	{
		// Le delay est en seconde, 300 secondes = 5 minutes.
		Delay += Time.Delta;
		Log.Info ("Delay =" + Delay);
		if (Delay >= 300)
		{
			Delay = 0;
			playerParam.Money += 50;
		}

		
	}
	void PlayerController.IEvents.OnJumped()
	{
		if (playerParam.MaxHealth-1 < playerParam.Health)
		{
			playerParam.Health = playerParam.MaxHealth;
		}
		else
		{
			playerParam.Health +=1;
		}
		
		playerParam.Money +=20;
	}


}
