using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsController : MonoBehaviour
{
    public GameObject Inst1;
    public GameObject Inst2;
    public GameObject Inst3;
    public GameObject Inst4;
    public GameObject Inst5;

    int instruccion = 1;

    // Start is called before the first frame update
    public void Start()
    {
        Inst1.SetActive(true);
        Inst2.SetActive(false); Inst3.SetActive(false); Inst4.SetActive(false); Inst5.SetActive(false);
    }

    void FixedUpdate()
    {
        if (instruccion < 1)
        {
            instruccion = 1;
        }
        if (instruccion > 5)
        {
            instruccion = 5;
        }

        switch (instruccion)
        {
            case 1: Inst1.SetActive(true);
                Inst2.SetActive(false);
                Inst3.SetActive(false);
                Inst4.SetActive(false);
                Inst5.SetActive(false);
                break;
            case 2: Inst2.SetActive(true);
                Inst1.SetActive(false);
                Inst3.SetActive(false);
                Inst4.SetActive(false);
                Inst5.SetActive(false);
                break;
            case 3: Inst3.SetActive(true);
                Inst2.SetActive(false);
                Inst1.SetActive(false);
                Inst4.SetActive(false);
                Inst5.SetActive(false);
                break;
            case 4: Inst4.SetActive(true);
                Inst2.SetActive(false);
                Inst3.SetActive(false);
                Inst1.SetActive(false);
                Inst5.SetActive(false);
                break;
            case 5: Inst5.SetActive(true);
                Inst2.SetActive(false);
                Inst3.SetActive(false);
                Inst4.SetActive(false);
                Inst1.SetActive(false);
                break;
        }
    }
    public void Next()
    {
        instruccion++;
    }
    public void Prev()
    {
        instruccion--;
    }
}
