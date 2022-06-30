using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WAVE : MonoBehaviour
{
    public GameObject back;
    public GameObject clear;
    public Text text;
    public GameObject shoot1;
    public GameObject shoot2;
    public GameObject shoot3a;
    public GameObject shoot4;

    int t = 0;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
        t = t + 1;
        
        if (t == 100)
        {
            text.enabled = true;
            text.text = ("WAVE1");
        }
        switch(t)
        {
            case 200:
                text.enabled = false;
                shoot1.SetActive(true);
                break;
            case 1300:
                shoot1.SetActive(false);
                break;
            case 1600:
                text.enabled = true;
                text.text = ("WAVE2");
                break;
            case 1700:
                text.enabled = false;
                shoot2.SetActive(true);
                break;
            case 3300:
                shoot2.SetActive(false);
                break;
            case 3500:
                text.enabled = true;
                text.text = ("WAVE3");
                break;
            case 3600:
                text.enabled = false;
                shoot3a.SetActive(true);
                break;
            case 5200:
                text.enabled = true;
                shoot3a.SetActive(false);
                text.text = ("WAVE4");
                break;
            case 5300:
                text.enabled = false;
                shoot4.SetActive(true);
                break;
            case 7000:
                shoot4.SetActive(false);
                break;
            case 7200:
                Invoke("end", 3);
                break;

        }
    }

    
    void end()
    {
        back.SetActive(true);
        clear.SetActive(true);
    }


    
    // Update is called once per frame

}
