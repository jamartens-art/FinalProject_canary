using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    public List<string> collection;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Collectable"))
        {
            collection.Add(collision.gameObject.GetComponent<Collectable>().itemName);
            Destroy(collision.transform);
        }
    }
}
