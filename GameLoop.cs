using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameLoop : MonoBehaviour
{

    public void Baslat()
    {
        SceneManager.LoadScene(1);


    }

    public void devam()
    {
        SceneManager.LoadScene(1);


    }
    public void restartGame()
    {
        SceneManager.LoadScene(1);
        gameEvent.puan = 0;

   }
}
