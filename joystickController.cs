using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class joystickController : MonoBehaviour
{

    float y, x;
    public int hiz;

    public Joystick j;

    public static int basla;

    private void Start()
    {
        basla = 0;
    }

    private void FixedUpdate()
    {
        y = j.Vertical;
        x = j.Horizontal;

        if(x != 0 || y != 0)
        {
            basla = 1;
        }

        GetComponent<Animator>().SetFloat("x", Mathf.Abs(x));
        GetComponent<Animator>().SetFloat("y", Mathf.Abs(y));
        GetComponent<Animator>().SetFloat("durx", x);
        GetComponent<Animator>().SetFloat("dury", y);

        transform.rotation = Quaternion.Euler(0, 0, 0);

        if (y != 0 || x != 0)
        {
            
            transform.right = new Vector3(x * hiz, y * hiz, 0);
            transform.Translate(new Vector3(x, y, 0) * hiz * Time.deltaTime, Space.World);
        }
    }
}
