using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject ignePrefabs;

    // mausa tıklayınca iğneyi gönderme işlemi 

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            igneSpawner();

        }
    }

// iğneyi spaw atme işlemi

    void igneSpawner()
    {
        Instantiate(ignePrefabs,transform.position,transform.rotation);
    }


}
