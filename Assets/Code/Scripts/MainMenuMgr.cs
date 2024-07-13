using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuMgr : MonoBehaviour
{
    public Button StartBtn;
    //public Button OptionBtn;

    // Start is called before the first frame update
    void Start()
    {
        if (StartBtn != null)
        {
            StartBtn.onClick.AddListener(StartBtnClick);
        }

        //if (OptionBtn != null)
        //{
        //    StartBtn.onClick.AddListener(OptionBtnClick);
        //}
    }

    private void StartBtnClick()
    {
        SceneManager.LoadScene("InGame");
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
