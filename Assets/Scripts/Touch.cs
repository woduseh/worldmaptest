using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour {
    
    float delta = 0.1f;
    public Character Character;

    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update() {
       /* float newYPosition = transform.position.y + delta;
        transform.position = new Vector3(-6.95f, newYPosition, 0);

        if (newYPosition == 2.67f)
        {
            delta = 0f;
        }*/
    }

    private void OnMouseDown()
    {
        //Character.SetCurrentPin();
    }

    void Movement()
    {
        float newYPosition = Character.transform.position.y + delta;
        Character.transform.position = new Vector3(-6.95f, newYPosition, 0);

        if (newYPosition == 2.67f)
        {
            delta = 0f;
        }
    }
}
