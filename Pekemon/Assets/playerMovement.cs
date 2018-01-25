using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public float speed,speedDefault = 2.7f;

	void Start () {
		
	}
	void Update () {

        if (Input.GetKey(KeyCode.Space))
        {
            speed = speedDefault * 2f;
        }
        else { speed = speedDefault; }

        moving(); 	
	}
    public void moving()
    {
        if (GetComponent<playerAttacking>().atkAllow == true)
        {
            if (Input.GetButton("up") || Input.GetKey(KeyCode.UpArrow))
            {
                GetComponent<playerAttacking>().DirectionFacing = directionFacing.up;
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            if (Input.GetButton("down") || Input.GetKey(KeyCode.DownArrow))
            {
                GetComponent<playerAttacking>().DirectionFacing = directionFacing.down;
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
            if (Input.GetButton("left") || Input.GetKey(KeyCode.LeftArrow))
            {
                GetComponent<playerAttacking>().DirectionFacing = directionFacing.left;
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            if (Input.GetButton("right") || Input.GetKey(KeyCode.RightArrow))
            {
                GetComponent<playerAttacking>().DirectionFacing = directionFacing.right;
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "wall")
        {
            Debug.Log("dfghjkl");
        }
        if (other.gameObject.tag == "Enemy")
        {
           // this.gameObject.GetComponent<playerAttacking>().playerHealth--;
        }
    }
    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy"&&GetComponent<playerAttacking>().playerHealth>0)
        {
            this.gameObject.GetComponent<playerAttacking>().playerHealth--;
        }
    }
}
