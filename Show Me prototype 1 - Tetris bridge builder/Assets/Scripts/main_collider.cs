using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class main_collider : MonoBehaviour
{

    private Collider2D trigger;
    public bool hasCollided = false;






    // Start is called before the first frame update
    void Start()
    {

        trigger = gameObject.GetComponent<Collider2D>();


    }



    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "RightBlock" && hasCollided == false)
        {
            hasCollided = true;
            

        }
    }


}
