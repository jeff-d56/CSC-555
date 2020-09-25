using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject selectedObject;
    public bool lookingAtObject = false;

    // Update is called once per frame
    void Update()
    {
        if(lookingAtObject == true)
        {

        }
    }

    private void OnMouseOver()
    {
        print("worked");
    }
}
