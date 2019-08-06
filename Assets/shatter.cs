using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class shatter : MonoBehaviour
{
    private int points = 0;
    private scoreboard gameController;
    public GameObject replacement;

    public Transform otherDistanceObject;

    TextMesh myTextComponent;


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("baseballBall"))
        {
            TextMesh myText = GetComponent<TextMesh>();
            Destroy(myText);
            gameController.updateScore(points);
            Destroy(gameObject);
            GameObject.Instantiate(replacement, transform.position, transform.rotation);
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
    }
    void Start()
    {


        if (otherDistanceObject)
        {
            float dist = Vector3.Distance(otherDistanceObject.position, transform.position);
            dist = dist / 10;
            points = Convert.ToInt32(Math.Floor(dist));
            points = points * 10;
            if (points == 0)
            {
                points = 10;
            }
            print("Distance to other: " + points);
        }

        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<scoreboard>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }

        GameObject myTextGameObject = new GameObject();

        myTextGameObject.transform.position = transform.position;
        myTextGameObject.transform.position += Vector3.right * .2f;
        myTextGameObject.transform.position += Vector3.back * .4f;
        myTextGameObject.transform.position += Vector3.up * .4f;

        Transform myTextTransform = myTextGameObject.GetComponent<Transform>();

        TextMesh myTextComponent = myTextGameObject.AddComponent<TextMesh>();

        myTextTransform.Rotate(0, -90, 0);

        myTextComponent.characterSize = .1f;
        myTextComponent.fontSize = 72;
        myTextComponent.text = points.ToString();
    }
}
