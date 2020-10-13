using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "player")
        {
            other.GetComponent<pointsystem>().points++;
            //add 1 pont
            Destroy(gameObject); //this Destroys things
        }
        
    }


}
