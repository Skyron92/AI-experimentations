using System.Collections.Generic;
using UnityEngine;

public abstract class GOAPActions : MonoBehaviour {
    private HashSet<KeyValuePair<string, object>> precondition;
    private HashSet<KeyValuePair<string, object>> effects;

    [Header("Actions Settings")]
    [SerializeField] private float Cost;
    [SerializeField] private GameObject target;
    
    

}