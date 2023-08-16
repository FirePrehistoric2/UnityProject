using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{

    public GameObject Player; 
    public GameObject child; 
    public float speed;

    private void Start() {
        Player = GameObject.FindGameObjectWithTag("CameraTarget");
        child = Player.transform.Find("CameraConstraint").gameObject;
        
    }
   
    private void FixedUpdate() {
    
        follow();

    }

    private void follow() {

        gameObject.transform.position = Vector3.Lerp(transform.position,child.transform.position,Time.deltaTime * speed);
        gameObject.transform.LookAt(Player.gameObject.transform.position);

    }

}
