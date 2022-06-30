﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class START : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
