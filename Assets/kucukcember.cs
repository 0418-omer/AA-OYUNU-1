using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukcember : MonoBehaviour
{
    //Rigidbody çağırma işlemi
    public Rigidbody2D rb;

    // hız atama işlemi
    public float speed;
    bool tuttumu;

    //iğnenin yukarı doğru  gönderme işlemi 
    private void Update()
    {
        if(!tuttumu)
        rb.MovePosition(rb.position+Vector2.up*speed*Time.deltaTime);
    }


    // iğnenin çembere yapışma işlemi

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("buyukcember"))
        {
            
            transform.SetParent(other.transform);
            other.GetComponent<buyukcember>().speed*=-1f;
            tuttumu=true;
            FindObjectOfType<skor>().UpdateScore();
        }

        else if (other.CompareTag("kucukcember"))
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        
    }
}
