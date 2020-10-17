using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leathalscript1 : MonoBehaviour
{
    public float Health;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            collision.gameObject.GetComponent<HealthManager>().TakeHealth(Health);
        }
    }
}
