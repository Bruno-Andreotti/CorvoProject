using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    float throwForce = 1000;
    Vector2 objectPos;
    float distance;

    public bool canhold = true;
    public GameObject tempParent;
    public GameObject item;
    public bool isHolding = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(item.transform.position, tempParent.transform.position);
        if(distance>= 1f)
        {
            isHolding = false;
        }

        if(isHolding == true)
        {
            item.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            item.GetComponent<Rigidbody2D>().angularVelocity = 0;
            item.transform.SetParent(tempParent.transform);
            item.transform.position = tempParent.transform.position;

            if(Input.GetKeyDown(KeyCode.R))
            {
                item.GetComponent<Rigidbody2D>().AddForce(tempParent.transform.forward * throwForce);
                isHolding = false;
            }


        }
        else
        {
            objectPos = item.transform.position;
            item.transform.SetParent(null);
            item.transform.position = objectPos;
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            isHolding = true;
        }
    }
}
