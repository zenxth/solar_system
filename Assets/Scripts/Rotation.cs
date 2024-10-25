using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //declaring variable to select rotation target
    public Transform target;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotate around the first parameter is target position
        //rotate around needs second parameter about axis or rotation
        //rotate around third parameter needed is speed of rotation
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
}
