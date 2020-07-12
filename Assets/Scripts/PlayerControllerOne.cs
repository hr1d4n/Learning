using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllerOne : MonoBehaviour
{
    // Private Variables
    public float speed = 5.0f;
    public Text notificationTextPlayer1;
    public Text notificationTextPlayer2;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardlInput;
    private float fallZone = -1.5f;
    private bool blockNotification = true;
    public GameObject restartPlayer1;
    public GameObject restartPlayer2;
    private GameObject vehicle2;
    private GameObject barrelObstacles;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get the player input
        horizontalInput = Input.GetAxis("HorizontalAD");
        forwardlInput = Input.GetAxis("VerticalSW");

        // We Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardlInput);
        // We turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        vehicle2 = GameObject.Find("Vehicle2");


        if (transform.position.y < fallZone && blockNotification && vehicle2.transform.position.y > fallZone)
        {
            notificationTextPlayer1.text = "YOU LOSE!";
            notificationTextPlayer2.text = "YOU WIN!";
            restartPlayer1.SetActive(true);
            restartPlayer2.SetActive(true);
            blockNotification = false;
            //UnityEngine.UI.Button button = GameObject.Find("Restart").GetComponent<UnityEngine.UI.Button>();
            //button.gameObject.SetActive(true);
            
        }
       
    }

    void OnCollisionEnter(Collision col)
    {
        barrelObstacles = GameObject.Find("Barrel Obstacles");

        if (col.gameObject.name == "Barrel" && blockNotification && vehicle2.transform.position.z < barrelObstacles.transform.position.z)
        {
            
            notificationTextPlayer1.text = "YOU WIN!";
            notificationTextPlayer2.text = "YOU LOSE!";
            restartPlayer1.SetActive(true);
            restartPlayer2.SetActive(true);
            blockNotification = false;
        }
    }
}
