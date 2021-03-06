using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;

    public float speed = 10.0f;

    public float xRange = 17;

    public GameObject projectilePrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        ///Character movement
        horizontalInput = Input.GetAxis("Horizontal");
        this.transform.Translate(speed * Time.deltaTime * horizontalInput*Vector3.right);


        //left bound
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        //right bound
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        ///Character actions
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //launch proyectile
            Instantiate(projectilePrefab, this.transform.position+new Vector3(0,1.5f,1.5f),projectilePrefab.transform.rotation);
        }

    }
}
