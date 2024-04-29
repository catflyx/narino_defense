using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarinoController : MonoBehaviour
{
    HordeController hordeC;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("<-1> de VIDA");
            hordeC.lives--; hordeC.LivesT.text = hordeC.lives.ToString();
        }
    }
}
