using Sandbox;
using Sandbox.Utility;
using System.Threading.Tasks;

public class PlayerInteraction : Component
{
    [Property] public float RayDistance { get; set; } = 500f;
    [Property] public float InteractionDistance { get; set; } = 80f;

    private string InteractionKey = "use";
    [Property] public GameObject InteractionPanelPrefab { get; set; }
    private GameObject CurrentPanel;

    private bool isHolding = false;
    private TimeSince holdTime = 0;
    private bool interactionDone = false;

    protected override void OnUpdate()
    {
        if (Scene.Camera == null || !InteractionPanelPrefab.IsValid())
        {
            ResetHold();
            DeletePanel();
            return;
        }

        var camTransform = Scene.Camera.GameObject.Transform.World;
        Vector3 start = camTransform.Position;
        Vector3 end = start + camTransform.Forward * RayDistance;

        var tr = Scene.Trace
            .Ray(start, end)
            .WithoutTags("IgnoreInteract")
            .Run();

        Gizmo.Draw.Line(start, end);

        if (!tr.Hit || tr.Shape?.Collider == null)
        {
            ResetHold();
            DeletePanel();
            return;
        }

        var hitObject = tr.Shape.Collider.GameObject;

        float distanceToPlayer = GameObject.WorldPosition.Distance(hitObject.WorldPosition);
        if (distanceToPlayer > InteractionDistance)
        {
            ResetHold();
            DeletePanel();
            return;
        }

        var data = hitObject.GetComponent<SimpleInteraction>();
        if (data == null)
        {
            ResetHold();
            DeletePanel();
            return;
        }

		if (CurrentPanel == null || !CurrentPanel.IsValid())
		{
			CurrentPanel = InteractionPanelPrefab.Clone();
			CurrentPanel.Parent = hitObject;
		}

        var panelComp = CurrentPanel.GetComponent<InteractionPanel>();
		if (panelComp.IsValid())
		{
			panelComp.InteractionString = data.InteractionName;
			panelComp.IsHoldInteraction = data.HoldDuration > 0;
			
			panelComp.ProgressionHold = data.HoldDuration > 0 
				? MathX.Clamp(holdTime / data.HoldDuration, 0f, 1f) 
				: 0f;
		}

        if (Input.Down(InteractionKey))
        {
            if (!isHolding)
            {
                isHolding = true;
                holdTime = 0;
                interactionDone = false;
            }

            if (data.HoldDuration <= 0 && !interactionDone)
            {
                interactionDone = true;
                OnInteract(hitObject, data);
            }
            else if (data.HoldDuration > 0)
            {
                holdTime += Time.Delta;
                if (holdTime >= data.HoldDuration && !interactionDone)
                {
                    interactionDone = true;
                    OnInteract(hitObject, data);
                }
            }
        }
        else
        {
            ResetHold();
        }
    }

    private void ResetHold()
    {
        isHolding = false;
        interactionDone = false;
        holdTime = 0;
    }

    private void DeletePanel()
    {
        if (CurrentPanel.IsValid())
        {
            CurrentPanel.Destroy();
            CurrentPanel = null;
        }
    }

    protected virtual void OnInteract(GameObject target, SimpleInteraction data)
    {
        Log.Info($"Interagi avec {target.Name} : {data.InteractionName}");
        // vous pouvez faire des fonctions en fonction du nom de l'interaction
    }
}
