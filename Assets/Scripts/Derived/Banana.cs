using UnityEngine;

public class Banana : Fruit
{
    // ENCAPSULATION
    private string _nameOfObject;
    public string nameOfObject
    {
        get
        {
          return _nameOfObject = "Banana Joe";
        }
    }

    public override string ShowName()
    {
       return nameOfObject;
    }
    
    protected override void SetSize()
    {
        var size = fruitMass * sizeMultiplier;
        transform.localScale = new Vector3(size, size, size);
    }
}
