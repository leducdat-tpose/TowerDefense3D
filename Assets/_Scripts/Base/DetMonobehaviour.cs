using UnityEngine;

public abstract class DetMonobehaviour : MonoBehaviour
{
    protected virtual void Reset() {
        LoadComponents();
    }
    protected virtual void Awake() {
        LoadComponents();
    }
    protected virtual void LoadComponents(){}
    protected virtual void Initialise(){}
}
