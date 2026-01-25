using Sandbox;

public sealed class PlayerParam : Component
{
    // -------- HEALTH --------
    [Property] private int Health;
    public int GetHealth() => Health;
    public void SetHealth(int value) => Health = value;
    public void IncrementHealth(int value) => Health += value;
    public void DecrementHealth(int value) => Health -= value;

    // -------- SHIELD --------
    [Property] private int Shield;
    public int GetShield() => Shield;
    public void SetShield(int value) => Shield = value;
    public void IncrementShield(int value) => Shield += value;
    public void DecrementShield(int value) => Shield -= value;

    // -------- STAMINA --------
    [Property] private int Stamina;
    public int GetStamina() => Stamina;
    public void SetStamina(int value) => Stamina = value;
    public void IncrementStamina(int value) => Stamina += value;
    public void DecrementStamina(int value) => Stamina -= value;

    // -------- RADIATION --------
    [Property] private int Radiation;
    public int GetRadiation() => Radiation;
    public void SetRadiation(int value) => Radiation = value;
    public void IncrementRadiation(int value) => Radiation += value;
    public void DecrementRadiation(int value) => Radiation -= value;

    // -------- OXYGEN --------
    [Property] private int Oxygen;
    public int GetOxygen() => Oxygen;
    public void SetOxygen(int value) => Oxygen = value;
    public void IncrementOxygen(int value) => Oxygen += value;
    public void DecrementOxygen(int value) => Oxygen -= value;

    // -------- MADNESS --------
    [Property] private int Madness;
    public int GetMadness() => Madness;
    public void SetMadness(int value) => Madness = value;
    public void IncrementMadness(int value) => Madness += value;
    public void DecrementMadness(int value) => Madness -= value;

    // -------- DISEASE --------
    [Property] private int Disease;
    public int GetDisease() => Disease;
    public void SetDisease(int value) => Disease = value;
    public void IncrementDisease(int value) => Disease += value;
    public void DecrementDisease(int value) => Disease -= value;

    // -------- FEAR --------
    [Property] private int Fear;
    public int GetFear() => Fear;
    public void SetFear(int value) => Fear = value;
    public void IncrementFear(int value) => Fear += value;
    public void DecrementFear(int value) => Fear -= value;
}
