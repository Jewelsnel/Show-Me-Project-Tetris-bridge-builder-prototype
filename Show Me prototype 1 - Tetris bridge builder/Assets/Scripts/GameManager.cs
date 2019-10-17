using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject mainCol;

    private main_collider colliderScript;

    public GameObject player;
    public Rigidbody2D playerRB;
    public float playerSpeed;
    private float playerStop = 0;
    public float playerTimer = 2;

    public Camera mainCamera;
    private float camY;
    private float camZ;

    public bool camCanMove = false;

    // Start is called before the first frame update
    void Start()
    {
        colliderScript = mainCol.gameObject.GetComponent<main_collider>();
        playerRB = player.gameObject.GetComponent<Rigidbody2D>();
        mainCamera = mainCamera.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {



        if (colliderScript.hasCollided == true)
        {
            
            playerRB.transform.Translate(Vector2.right * playerSpeed * Time.deltaTime);
            camCanMove = true;
            playerTimer -= Time.deltaTime;
            if (playerTimer < -0)
            {
                playerSpeed = playerStop;
                
                //playerRB.transform.Translate(Vector2.right * 0 * Time.deltaTime);
            }
            colliderScript.hasCollided = false;
            
            

        }

        if (camCanMove)
        {
            mainCamera.transform.position = mainCamera.transform.position + new Vector3(11f, 0f, 0f) * Time.deltaTime;
            camCanMove = false;
        }
    }
}