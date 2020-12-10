﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Debankita
public class LostUI : MonoBehaviour
{
    public GameObject menu;
    public GameObject player;
    public GameObject lostmessage;
    public GameObject timeactive;
    public mainmenu m;
    // Start is called before the first frame update
    public void Start()
    {
        m= GetComponent<mainmenu>();
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("making_tiles");
        m.activate = true;
        if (m.activate == true)
        {
            player.SetActive(true);
            lostmessage.SetActive(false);
            timeactive.SetActive(true);
        }
    }
    public void Quit()
    {
        SceneManager.LoadScene("making_tiles");
        m.activate = false;
        menu.SetActive(true);
        timeactive.SetActive(false);
        lostmessage.SetActive(false);

    }

}
