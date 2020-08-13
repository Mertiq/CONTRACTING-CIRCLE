using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleHareket : MonoBehaviour
{
    int sifirla;

    float eksilcekdeger = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        eksilcekdeger = 0.001f;
    }

    // Update is called once per frame
    void Update()
    {
        if(joystickController.basla == 1)
        {

            if (yonetici.skor % 10 == 0)
            {
                eksilcekdeger += 0.0001f;
            }

            sifirla = CopAdamHareket.sifirla;

            if (sifirla == 1)
            {
                transform.localScale = new Vector3(1f, 1f, 1f);
                CopAdamHareket.sifirla = 0;
            }
            else
            {
                transform.localScale = new Vector3(transform.localScale.x - eksilcekdeger * Time.deltaTime, transform.localScale.y - eksilcekdeger * Time.deltaTime, 0f);
            }

        }

        
        
    }


}
