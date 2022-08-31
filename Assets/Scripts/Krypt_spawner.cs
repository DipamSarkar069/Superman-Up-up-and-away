using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Krypt_spawner : MonoBehaviour
{
    public float maxTime = 1f;
    public float timer = 0f;
    public float height;
    public GameObject krypt;

    // Update is called once per frame
    void Update()
    {
        if(timer>maxTime)
        {
            GameObject newKrypt = Instantiate(krypt);
            newKrypt.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newKrypt, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
    
}
