using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Nodes : ScriptableObject {
    [SerializeField] private List<bool> Preconditions;
    [SerializeField] private List<Nodes> Output;
    [SerializeField] private int Cost;
    
    public abstract void Effect();

}