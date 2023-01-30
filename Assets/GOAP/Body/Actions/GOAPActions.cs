using System;
using UnityEngine;

public abstract class GOAPActions : MonoBehaviour {

    public GOAPActions(Agent currentAgent) {
        CurrentAgent = currentAgent;
    }
    private Tuple<string, object> precondition;
    private Tuple<string, object> effects;

    [Header("Actions Settings")]
    public float Cost;

    public Agent CurrentAgent;

    public abstract bool IsDone();
    public abstract void Do();

}