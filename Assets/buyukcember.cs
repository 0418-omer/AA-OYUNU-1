using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyukcember : MonoBehaviour
{

    // Hız değişkeni atama 
   public float speed;

    //Cember döndürme işlemi
   private void Update()
   {
    transform.Rotate(0,0,speed*Time.deltaTime);
   } 
}
