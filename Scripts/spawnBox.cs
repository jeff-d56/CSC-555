using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBox : MonoBehaviour
{
    public GameObject box;
    private GameObject box1;
  
    private void OnMouseEnter()
    {
        box1 = Instantiate(box, this.gameObject.transform.position, Quaternion.identity);
        box1.transform.SetParent(this.transform);
    }

    private void OnMouseExit()
    {
        Destroy(box1.gameObject);
    }
}
