using UnityEngine;

public class EatPie : GOAPActions {
    public override bool IsDone() {
        return !CurrentAgent.HasPie;
    }

    public override void Do() {
        if(!CurrentAgent.HasPie) return;
        CurrentAgent.HasPie = false;
        Debug.Log("Miam !");
    }

    public EatPie(Agent currentAgent) : base(currentAgent) {
    }
}