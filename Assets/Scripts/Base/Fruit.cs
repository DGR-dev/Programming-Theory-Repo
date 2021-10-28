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
        // Abstraction
        SetColor();
        ShowName();
    }
    
    // Inheritance
    protected abstract void SetSize();

    protected virtual void SetColor()
    {
        _meshRenderer.material.color = fruitColor;
    }
    
    protected virtual void ShowName()
    {
        print(nameOfObject);
    }
}
