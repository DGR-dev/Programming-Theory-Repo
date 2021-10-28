
using UnityEngine;

public class Apple : Fruit
{
    protected override void SetSize()
    {
        var size = fruitMass * sizeMultiplier;
        transform.localScale = new Vector3(size, size, size);
    }

    // Polymorphism
    protected override void ShowName()
    {
        print($"I am {nameOfObject}");
    }
}
