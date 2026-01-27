using Sandbox;

public sealed class PlayerParam : Component
{


    public TimeSince TimeAlive { get; set; } =0f;

    // -------- HEALTH --------
    [Property] private float Health ;
    public float GetHealth() => Health;
    public void SetHealth(float value) => Health = value;
    public void IncrementHealth(float value) => Health += value;
    public void DecrementHealth(float value) => Health -= value;

    // -------- SHIELD --------
    [Property] private float Shield;
    public float GetShield() => Shield;
    public void SetShield(float value) => Shield = value;
    public void IncrementShield(float value) => Shield += value;
    public void DecrementShield(float value) => Shield -= value;

    // -------- STAMINA --------
    [Property] private float Stamina;
    public float GetStamina() => Stamina;
    public void SetStamina(float value) => Stamina = value;
    public void IncrementStamina(float value) => Stamina += value;
    public void DecrementStamina(float value) => Stamina -= value;

    // -------- RADIATION --------
    [Property] private float Radiation;
    public float GetRadiation() => Radiation;
    public void SetRadiation(float value) => Radiation = value;
    public void IncrementRadiation(float value) => Radiation += value;
    public void DecrementRadiation(float value) => Radiation -= value;

    // -------- OXYGEN --------
    [Property] private float Oxygen;
    public float GetOxygen() => Oxygen;
    public void SetOxygen(float value) => Oxygen = value;
    public void IncrementOxygen(float value) => Oxygen += value;
    public void DecrementOxygen(float value) => Oxygen -= value;

    // -------- MADNESS --------
    [Property] private float Madness;
    public float GetMadness() => Madness;
    public void SetMadness(float value) => Madness = value;
    public void IncrementMadness(float value) => Madness += value;
    public void DecrementMadness(float value) => Madness -= value;

    // -------- DISEASE --------
    [Property] private float Disease;
    public float GetDisease() => Disease;
    public void SetDisease(float value) => Disease = value;
    public void IncrementDisease(float value) => Disease += value;
    public void DecrementDisease(float value) => Disease -= value;

    // -------- FEAR --------
    [Property] private float Fear;
    public float GetFear() => Fear;
    public void SetFear(float value) => Fear = value;
    public void IncrementFear(float value) => Fear += value;
    public void DecrementFear(float value) => Fear -= value;

    // -------- MONEY --------
    [Property] private int Money;
    public float GetMoney() => Money;
    public void SetMoney(int value) => Money = value;
    public void IncrementMoney(int value) => Money += value;
    public void DecrementMoney(int value) => Money -= value;
}
