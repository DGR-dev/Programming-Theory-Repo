using UnityEngine;

public class Banana : Fruit
{
    // Encapsulation
    private string _nameOfObject;
    public string nameOfObject
    {
        get
        {
          return _nameOfObject = "Banana Joe";
        }
    }

    protected override void ShowName()
    {
        print(nameOfObject);
    }
    
    protected override void SetSize()
    {
        var size = fruitMass * sizeMultiplier;
        transform.localScale = new Vector3(size, size, size);
    }
}
