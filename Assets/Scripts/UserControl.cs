using UnityEngine;


public class UserControl : MonoBehaviour
{
    private Fruit fruit;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // ABSTRACTION
            ObjectSelection();
        }
    }

    private void ObjectSelection()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            var obj = hit.collider.GetComponentInParent<Fruit>();
            
            if (obj != null)
            {
                this.fruit = obj;
                GameUI.Instance.ShowInfo(fruit.ShowName());
            }
        }
    }
}
