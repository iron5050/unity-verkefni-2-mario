using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// kóði fyrir að láta restart takkan (botn vinstrameginn) loada fyrsta levelinu 
public class restart : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("level 01");
    }
}