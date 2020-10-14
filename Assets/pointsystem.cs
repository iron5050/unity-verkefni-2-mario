using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class pointsystem : MonoBehaviour
{
    //setur stig sem 0
    public int points = 0;
    //notað varðandi level loads
    static int scene_counter;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //tékkar hvort stigin séu 6
        if (points >= 6)
        {
            //kóði til að loada næsta leveli
            scene_counter = SceneManager.GetActiveScene().buildIndex;
            if (scene_counter < 3)
            {
                scene_counter++;
                // loadar næsta leveli
                SceneManager.LoadScene(scene_counter);
            }
        }

    }
    //sýnir hversu mikið af stigum þú hefur
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Score : " + points);
    }
}
