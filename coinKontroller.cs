using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinKontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-1.2f, 1.2f);
        float y = Random.Range(0.8f, 3.1f);

        transform.position = new Vector3(x, y, transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
