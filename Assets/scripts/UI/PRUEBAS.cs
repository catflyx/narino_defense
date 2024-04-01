using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUIController : MonoBehaviour
{
    public TextMeshProUGUI MoneyT; public TextMeshProUGUI LivesT;
    float money; float lives;

    public HordeController script;
    bool playing;

    // Start is called before the first frame update
    void Start()
    {
        money = 1000; lives = 10;
        MoneyT.text = money.ToString(); LivesT.text = lives.ToString();

        playing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (script.HordeStart)
        {
            playing = true;
        }
        else
        {
            playing = false;
        }

    }
}
