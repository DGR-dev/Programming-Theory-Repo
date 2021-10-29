
using UnityEngine;

public class Apple : Fruit
{
    protected override void SetSize()
    {
        var size = fruitMass * sizeMultiplier;
        transform.localScale = new Vector3(size, size, size);
    }

    // POLYMORPHISM
    public override string ShowName()
    {
        return "I am " +nameOfObject;
    }
}
