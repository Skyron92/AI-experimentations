using UnityEngine;

public class CheckIngredients : State {
    public CheckIngredients(Agent context) : base(context) {
    }

    public override void Do() {
        Debug.Log("Checking Ingredient...");
    }

    public override void Transition() {
        if (Kitchen.HasIngredient) Context.CurrentAction = new MakeAPie(Context);
        else Context.CurrentState = new CheckMoney(Context);
    }
}