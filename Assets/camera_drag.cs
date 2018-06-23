using UnityEngine;
 using UnityEngine;
 using System.Collections;
 
 public class camera_drag : MonoBehaviour
 {
    public float speed = 5.0f;
    public Transform target;

  
 void Update () {
     if (Input.GetMouseButton(0)) {
         transform.LookAt(target);
         transform.RotateAround(target.position, Vector3.up, Input.GetAxis("Mouse X")*speed);
     }
 }
 }