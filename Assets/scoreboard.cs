using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreboard : MonoBehaviour
{
    int score = 0;

    TextMesh myTextComponent;

    // Use this for initialization
    void Start()
    {
        GameObject myTextGameObject = new GameObject();

        myTextGameObject.transform.position = transform.position;

        Transform myTextTransform = myTextGameObject.GetComponent<Transform>();

        myTextTransform.localScale = new Vector3(1, 1, 1);
        myTextTransform.position = new Vector3(0.41f, 2.47f, 4.01f);
        myTextTransform.Rotate(-14.5f, -28.365f, 0f);

        TextMesh myTextComponent = myTextGameObject.AddComponent<TextMesh>();


        myTextComponent.characterSize = .05f;
        myTextComponent.fontSize = 72;
        myTextComponent.text = score.ToString();

        setObject(myTextComponent);
    }
    void setObject(TextMesh x)
    {
        myTextComponent = x;
    }
    // Update is called once per frame
    void Update()
    {

        myTextComponent.text = score.ToString();
    }
    public void updateScore(int points)
    {
        score = score + points;
    }
}
