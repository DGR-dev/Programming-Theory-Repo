
using UnityEngine;

public class Mango : Fruit
{
    protected override void SetSize()
    {
        var size = fruitMass * sizeMultiplier;
        transform.localScale = new Vector3(size, size, size);
    }
}
