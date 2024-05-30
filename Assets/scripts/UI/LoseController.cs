using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseController : MonoBehaviour
{
    static int currentLevel = 1; //No s� como hacer q esto se guarde al cambiar de escena AHHH
    //EL STATIC ERA LA CLAVE?!

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("NIVEL ACTUAL: " + currentLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TryAgain()
    {
        Debug.Log("NIVEL ACTUAL: " + currentLevel);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        switch (currentLevel)
        {
            case 1: SceneManager.LoadScene(50); break;
            case 2: SceneManager.LoadScene(51); break;
            case 3: SceneManager.LoadScene(52); break;
        }
    }
    public void NextLevel()
    {
        Debug.Log("NIVEL ACTUAL: " + currentLevel);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        currentLevel++;
        switch (currentLevel)
        {
            case 2: SceneManager.LoadScene(51); break;
            case 3: SceneManager.LoadScene(52); break;
        }
    }
    public void MenuLose()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
        SceneManager.LoadScene(45);
    }
    public void MenuWin()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
        SceneManager.LoadScene(45);
    }
}