using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Chase : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;

    private Transform target;
    private Vector2 startPos;



    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        startPos = transform.position;
    }

    void Update()
    {

        if(Vector2.Distance(transform.position, target.position)< stoppingDistance)
        {
            transform.position = Vector2.MoveTowards
                (transform.position, target.position, speed * Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, target.position) < stoppingDistance)
        {
            transform.position = startPos.normalized;
        }
    }
   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            Debug.Log("Derrota");
        }
    }*/
}
