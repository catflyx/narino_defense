using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            if (horde >= 15 && HordeStart == false)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            lives--; LivesT.text = lives.ToString();
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
