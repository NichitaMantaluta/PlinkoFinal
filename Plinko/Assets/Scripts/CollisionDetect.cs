using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        var objectName = collision.gameObject.name;
        if (objectName == "Score0-1" || objectName == "Score0-2" || objectName == "Score0-3")
        {
            Scorekeeper.scoreValue = 0;
        }

        if (objectName == "Score50-1" || objectName == "Score50-2")
        {
            Scorekeeper.scoreValue = 50;
        }

        if (objectName == "Score100-1" || objectName == "Score100-2")
        {
            Scorekeeper.scoreValue = 100;
        }
    }
}
