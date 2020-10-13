using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class pointsystem : MonoBehaviour
{
    public int points = 0;
    static int scene_counter;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //if (points >= 6)
        //{
        //Application.LoadLevel("level 02");
        //}
        if (points >= 6)
        {
            scene_counter = SceneManager.GetActiveScene().buildIndex;
            if (scene_counter < 3)
            {
                scene_counter++;
                // loads next level
                SceneManager.LoadScene(scene_counter);
            }
        }

    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Score : " + points);
    }
}
