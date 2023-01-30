using System;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour {
    public State CurrentState;
    public NavMeshAgent _navMeshAgent;
    public Transform Kitchen;
    public int Money;
    public bool HasIngredients => global::Kitchen.HasIngredient;
    public bool HasPie;
    public GOAPActions CurrentAction;

    private void Awake() {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        CurrentState = new InKitchen(this);
        CurrentAction = new GoToKitchenAction(this);
    }

    private void Update() {
        CurrentAction.Do();
    }
}