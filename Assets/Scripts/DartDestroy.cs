using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(destroy());
    }
    
    IEnumerator destroy()
    {
        yield return new WaitForSecondsRealtime(4);
        Destroy(gameObject);
    }
}
