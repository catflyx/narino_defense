using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEditor.U2D.Path;

public class HordeController : MonoBehaviour
{
    public GameObject StartB; public TextMeshProUGUI HordesT;
    int horde = 0;
    public TextMeshProUGUI MoneyT; public TextMeshProUGUI LivesT;
    public float money; public float lives;

    public GameObject Towers; public GameObject Powers;

    public bool HordeStart;

    // Start is called before the first frame update
    void Start()
    {
        HordeStart = false;
        HordesT.text = horde + " / 15";

        money = 1000; lives = 10;
        MoneyT.text = money.ToString(); LivesT.text = lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (HordeStart == false)
        {
            StartB.SetActive(true);

            Towers.SetActive(true); Powers.SetActive(false);
        } 

        if (lives <= 0)
        {
            SceneManager.LoadScene(48);
        }
        else
        {
            if (horde >= 15 && HordeStart == false)
            {
                SceneManager.LoadScene(49);
            }
        }

        //Gametesting
        if (Input.GetKeyDown(KeyCode.X))
        {
            lives--; LivesT.text = lives.ToString();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            horde++; HordesT.text = horde + " / 15";
        }
    }
    public void StartHorde()
    { 
        StartB.SetActive(false);
        horde++; HordesT.text = horde + " / 15";
        HordeStart = true;

        Towers.SetActive(false); Powers.SetActive(true);
    }
}
