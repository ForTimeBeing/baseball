using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class spawn_target : MonoBehaviour
{
    public GameObject original;
    System.Random rnd = new System.Random();
    int numberOfTargets = 0;
    float zPosition = 0;
    float xPosition = 0;

    float yPosition = 0;

    float coneForZ = 0;

    float xrotation;
    float yrotation;
    float zrotation;

    void Start()
    {

        

        for (numberOfTargets = rnd.Next(10, 20); numberOfTargets > 0; numberOfTargets--)
        {
            

            zPosition = rnd.Next(-50, -5);
            
            xPosition = -(zPosition * .5f);
            yPosition = -(zPosition * .5f);

            xrotation = rnd.Next(0, 1);
            yrotation = rnd.Next(0, 1);
            zrotation = rnd.Next(0, 1);


            yPosition = rnd.Next(-30, 30);
            GameObject.Instantiate(original, new Vector3(zPosition, xPosition, yPosition), Quaternion.Euler(transform.rotation.x, transform.rotation.y, zrotation));
            
        }


    }
}
