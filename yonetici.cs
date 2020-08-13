using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yonetici : MonoBehaviour
{
    public static int skor = 0;
    public static int hskor;

    public Text txt;

    // Start is called before the first frame update
    void Start()
    {
        skor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = skor.ToString();
    }

    
}
