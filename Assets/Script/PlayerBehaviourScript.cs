using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour {

    public Rigidbody2D rigidbody2D;
    public float speed = 5.0f;

	// Use this for initialization
	void Start () {
        // 得到绑定对象的运动组件，推论物体要想运动就要使用此组件，有此组件的对象就可以运动
        rigidbody2D = GetComponent<Rigidbody2D>();
	}

    void FixedUpdate()
    {
        float hmove = Input.GetAxis("Horizontal");
        float vmove = Input.GetAxis("Vertical");

        Vector2 v = new Vector2(hmove, vmove);

        rigidbody2D.AddForce(v * speed);
    }
   
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pickup"))
        {
            collision.gameObject.SetActive(false);
        }
    }

}
