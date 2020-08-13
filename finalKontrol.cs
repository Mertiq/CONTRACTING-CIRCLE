using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class finalKontrol : MonoBehaviour
{
    int skor;
    int hskor;
    public Text txt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yonetici.hskor = PlayerPrefs.GetInt("skor");
        skor = yonetici.skor;
        hskor = yonetici.hskor;

        txt.text = "HIGHSCORE\n" + hskor +"\nSCORE\n" + skor;
        

    }


    public void basadon()
    {
        SceneManager.LoadScene(0);
    }

}
