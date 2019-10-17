using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tetris_block : MonoBehaviour
{
    Collider2D col;
    public float newXposition;
    public float newYposition;
    public float speed;
    public bool isTouched;


    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchedCollider && isTouched == false)
                {
                    isTouched = true;
                }
            }

            /*if (touch.phase == TouchPhase.Moved)
            {
                if (isTouched)
                {
                    transform.position = new Vector2(newXposition, newYposition);
                }
            }*/


            if (touch.phase == TouchPhase.Ended)
            {
                if (isTouched)
                {
                 transform.position = transform.position + new Vector3(0f,-3.74f,0f);
                    
                }
            }
        }
    }
}
