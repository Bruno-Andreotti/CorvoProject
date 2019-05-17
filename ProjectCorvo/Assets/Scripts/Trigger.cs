using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject Gate;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Gate.transform.position =Gate.transform.position + Gate.transform.up * 600;
        Debug.Log("entrou na colisão");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Gate.transform.position = Gate.transform.position + Gate.transform.up * -600;
        Debug.Log("saiu da colisão");
    }
}
