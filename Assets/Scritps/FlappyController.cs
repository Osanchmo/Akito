using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyController : MonoBehaviour {

	public GameObject child;

	Renderer childRend;
	Renderer rend;

	void Start () {
		childRend = child.GetComponent<Renderer>();
		rend = GetComponent<Renderer>();

		childRend.enabled = false;
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.transform.tag == "flappy") 
		{
			if (childRend.enabled){
				rend.enabled = true;
				childRend.enabled = false;
			} else 
			{
				rend.enabled = false;
				childRend.enabled = true;
			}

		}
	}
}
