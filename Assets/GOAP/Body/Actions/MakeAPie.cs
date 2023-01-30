using UnityEngine;

public class MakeAPie : GOAPActions {
    
    public override bool IsDone() {
        return CurrentAgent.HasPie;
    }

    public override void Do() {
        if(!CurrentAgent.HasIngredients) return;
        Debug.Log("Cooking...");
        CurrentAgent.HasPie = true;
        Kitchen.HasIngredient = false;
    }

    public MakeAPie(Agent currentAgent) : base(currentAgent) {
    }
}