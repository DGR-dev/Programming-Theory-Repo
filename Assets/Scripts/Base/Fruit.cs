using UnityEngine;

public abstract class Fruit : MonoBehaviour
{
    [SerializeField] protected Color fruitColor = Color.white;
    [SerializeField] protected string nameOfObject = string.Empty;
    [SerializeField] protected float fruitMass;
    [SerializeField] protected float sizeMultiplier;
    
    private MeshRenderer _meshRenderer;

    protected void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        // ABSTRACTION
        SetColor();
    }
    
    // INHERITANCE
    protected abstract void SetSize();

    protected virtual void SetColor()
    {
        _meshRenderer.material.color = fruitColor;
    }
    
    public virtual string ShowName()
    {
        return nameOfObject;
    }

}
