using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform playerBody;
    public CharacterController controller;
    public GameObject temp;

    void Update()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;

        if (Physics.Raycast(transform.position, fwd, out hit))
        {
            if (hit.collider.gameObject.tag == "Teleport")
            {
                if (Input.GetKeyDown("q"))
                {
                    controller.enabled = false;
                    playerBody.transform.position = new Vector3(hit.collider.transform.position.x, playerBody.transform.position.y, hit.collider.transform.position.z);
                    controller.enabled = true;
                }
            }
        }
    }
}
