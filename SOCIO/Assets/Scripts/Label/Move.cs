using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int f;

    // Start is called before the first frame update
    void Start()
    {
        f = (GameObject.Find("Save").GetComponent<Saves>().savename).Count;
        if (f == 7)
        {
            GameObject.Find("7").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("7").GetComponent<SpriteRenderer>().enabled = true;
        }
        if (f == 8)
        {
            GameObject.Find("7").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("7").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("7").GetComponent<Transform>().transform.position = new Vector2(-1.52f, -2.31f);
            GameObject.Find("Text7").GetComponent<Transform>().transform.position = new Vector2(-1.52f, -2.31f);
            GameObject.Find("8").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("8").GetComponent<SpriteRenderer>().enabled = true;
        }
        if (f == 9)
        {
            GameObject.Find("7").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("7").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("7").GetComponent<Transform>().transform.position = new Vector2(-1.52f, -2.31f);
            GameObject.Find("Text7").GetComponent<Transform>().transform.position = new Vector2(-1.52f, -2.31f);
            GameObject.Find("8").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("8").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("9").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("9").GetComponent<SpriteRenderer>().enabled = true;
        }
        
        if (f == 10)
        {
            GameObject.Find("7").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("7").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("7").GetComponent<Transform>().transform.position = new Vector2(-1.52f, -2.31f);
            GameObject.Find("Text7").GetComponent<Transform>().transform.position = new Vector2(-1.52f, -2.31f);
            GameObject.Find("8").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("8").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("9").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("9").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("9").GetComponent<Transform>().transform.position = new Vector2(-1.52f, -3.38f);
            GameObject.Find("Text9").GetComponent<Transform>().transform.position = new Vector2(-1.52f, -3.38f);
            GameObject.Find("10").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("10").GetComponent<SpriteRenderer>().enabled = true;

        }

        if (f == 11)
        {
            GameObject.Find("7").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("7").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("7").GetComponent<Transform>().transform.position = new Vector2(-1.52f, -2.31f);
            GameObject.Find("Text7").GetComponent<Transform>().transform.position = new Vector2(-1.52f, -2.31f);
            GameObject.Find("8").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("8").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("9").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("9").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("9").GetComponent<Transform>().transform.position = new Vector2(-1.52f, -3.38f);
            GameObject.Find("Text9").GetComponent<Transform>().transform.position = new Vector2(-1.52f, -3.38f);
            GameObject.Find("10").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("10").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("11").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("11").GetComponent<SpriteRenderer>().enabled = true;
        }

        if (f == 12)
        {
            GameObject.Find("7").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("7").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("7").GetComponent<Transform>().transform.position = new Vector2(-1.52f, -2.31f);
            GameObject.Find("Text7").GetComponent<Transform>().transform.position = new Vector2(-1.52f, -2.31f);
            GameObject.Find("8").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("8").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("9").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("9").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("9").GetComponent<Transform>().transform.position = new Vector2(-1.52f, -3.38f);
            GameObject.Find("Text9").GetComponent<Transform>().transform.position = new Vector2(-1.52f, -3.38f);
            GameObject.Find("10").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("10").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("11").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("11").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("11").GetComponent<Transform>().transform.position = new Vector2(-1.52f, -4.49f);
            GameObject.Find("Text11").GetComponent<Transform>().transform.position = new Vector2(-1.52f, -4.49f);
            GameObject.Find("12").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("12").GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
