using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CopAdamHareket : MonoBehaviour
{
    private float xhiz;
    private float yhiz;
    public static int sifirla = 0;
    

    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xhiz = Input.GetAxis("Horizontal");
        yhiz = Input.GetAxis("Vertical");

        GetComponent<Rigidbody2D>().velocity = new Vector2(xhiz * 2, yhiz * 2);
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "coin")
        {
            sifirla = 1;
            Destroy(collision.gameObject);
            GameObject geliyolar = Instantiate(coin);
            yonetici.skor += 1;
        }
        else if (collision.transform.tag == "cember")
        {
            yonetici.hskor = PlayerPrefs.GetInt("skor");
            if(yonetici.hskor < yonetici.skor)
            {
                PlayerPrefs.SetInt("skor", yonetici.skor);
            }

            SceneManager.LoadScene(1);
        }
    }
}
