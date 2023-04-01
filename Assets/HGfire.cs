using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HGfire : MonoBehaviour
{
    public GameObject Bullet;
    public Transform FirePos;
    float delay = 1.0f;
    float timing = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timing <= delay)
        {
            timing += Time.deltaTime;
        }
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (timing >= delay)
        {
            Instantiate(Bullet, FirePos.transform.position, FirePos.transform.rotation);
            timing = 0;
        }
    }
}
