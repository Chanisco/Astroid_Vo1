using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public Rigidbody Bullets;
	public Transform playershootpoint;
 	public float moveSpeed = 200f;
    public float turnSpeed = 200f;
	float reload = 0;
	public AudioClip Dead;

    void Update ()
    {
		reload += Time.deltaTime;
        if(Input.GetKey(KeyCode.W)){
            rigidbody.AddRelativeForce(Vector3.forward * moveSpeed);
		}
        
        if(Input.GetKey(KeyCode.S)){
             rigidbody.AddRelativeForce(-Vector3.forward * moveSpeed / 2);
		}
        
        if(Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
		
		if(Input.GetKey(KeyCode.Space)){
			if (reload > 0.5f){ 
			 	Instantiate(Bullets, playershootpoint.position, playershootpoint.rotation)	;
				reload = 0;
			}
		}
    }
}

