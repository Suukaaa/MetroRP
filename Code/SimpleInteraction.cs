using Sandbox;

public class SimpleInteraction : Component
{
    [Property] public string InteractionName { get; set; } = "InteractionName";

    [Property] public float HoldDuration { get; set; } = 0.0f;
}
