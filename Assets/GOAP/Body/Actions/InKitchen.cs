using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class InKitchen : State {
    public InKitchen(Agent context) : base(context) {
    }
    
    
    public override void Do() {
        Context.CurrentAction = new GoToKitchenAction(Context);
    }

    public override void Transition() {
        if (Vector3.Distance(Context.transform.position, Context.Kitchen.position) <= 0.001)
            Context.CurrentState = new CheckIngredients(Context);
    }
}
