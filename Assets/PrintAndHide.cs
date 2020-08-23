using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update
    int i;
    int randNum;
    public Renderer rend;

    void Start()
    {
        i = 0;
        randNum = Random.Range(200,250);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ":" + i);
        i++;

        if (gameObject.tag.Equals("Red") && i == 100) {
            gameObject.SetActive(false);
        }

        if (gameObject.tag.Equals("Blue") && i == randNum)
        {
            rend.enabled = false;
        }
    }
}
