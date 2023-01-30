using UnityEngine;

public class BuyAPie : GOAPActions {
    
    public override bool IsDone() {
        return CurrentAgent.HasPie;
    }

    public override void Do() {
        if(CurrentAgent.Money < 101) return;
        Debug.Log("Buying a pie...");
        CurrentAgent.Money -= 101;
        CurrentAgent.HasPie = true;
    }

    public BuyAPie(Agent currentAgent) : base(currentAgent) {
    }
}