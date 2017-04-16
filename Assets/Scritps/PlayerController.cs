using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Rigidbody2D jugador;
	public float gravedad, velocidad, salto;
	bool win;
	// Use this for initialization
	void Start () 
	{
		jugador = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(!win)
		{
			if(!Input.GetKey(KeyCode.Escape))
			{
				Physics.gravity = new Vector3(0,-gravedad,0);
				if (IsGrounded())
				{
					if (Input.GetButton("Fire1"))
					{
						jugador.velocity = new Vector3(0,salto,0);
					}
				}
				transform.position = 
				new Vector3(transform.position.x + velocidad, transform.position.y, transform.position.z);	
			}
		}
	}
	bool IsGrounded()
	{
		return Physics.Raycast(transform.position, -Vector3.up, 0.1f);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Meta")
		{
			win = true;
		}
	}
}
