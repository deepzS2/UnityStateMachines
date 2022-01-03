using UnityEngine;

/// <summary>
/// Hierarchical State Manager
/// </summary>
/// <typeparam name="T">Typeof the base state</typeparam>
public abstract class HierarchicalStateManager<T> : MonoBehaviour
{
    public T CurrentState;
}