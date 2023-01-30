using UnityEngine;

public class CheckMoney : State {
    public CheckMoney(Agent context) : base(context) {
    }

    public override void Do() {
        Debug.Log("Checking money...");
    }

    public override void Transition() {
        throw new System.NotImplementedException();
    }
}