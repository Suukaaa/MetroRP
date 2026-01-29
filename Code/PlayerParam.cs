using Sandbox;

public sealed class PlayerParam : Component
{
    //PROPERTY MAX 
    [Property] public float MaxHealth { get; set; } = 100f;
    [Property] public float MaxShield { get; set; } = 100f;
    [Property] public float MaxStamina { get; set; } = 100f;
    
    // PROPERTY
    [Property] public int Money {get; set;} = 0;
    [Property] public float Madness {get; set;} = 0f;
    [Property] public float Oxygen {get; set;} = 100f;
    [Property] public float Radiation {get; set;}=0f;
    [Property] public float Health {get; set;} = 100f;
    [Property] public float Shield { get; set;} = 0f;
    [Property] public float Stamina {get; set; } = 0f;
    [Property] public float Disease {get; set;} = 0f;
    [Property] public float Fear {get; set;} = 0f;

    // VARIABLE QUI CALCUL LE TEMPS A CHAQUE FRAME, ET QUI MONTRE LE TEMPS EN JEUX ( DANS LE UI )
    public TimeSince TimeAlive { get; set; } =0f;

}