using System;
using Vector3 = UnityEngine.Vector3;

public class GoToKitchenAction : GOAPActions {
    public override bool IsDone() {
        return Vector3.Distance(CurrentAgent.transform.position, CurrentAgent.Kitchen.position) <= 0.1;
    }

    public override void Do() {
        CurrentAgent._navMeshAgent.SetDestination(CurrentAgent.Kitchen.position);
    }

    private void Update() {
        if (IsDone()) CurrentAgent.CurrentAction = new MakeAPie(CurrentAgent);
    }

    public GoToKitchenAction(Agent currentAgent) : base(currentAgent) {
    }
}