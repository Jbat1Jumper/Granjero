using UnityEngine;
using System.Collections;

public class GranjeroTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public float Speed = 1f;

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.D))
			this.transform.position += new Vector3(Speed, 0, 0);
		if(Input.GetKey(KeyCode.A))
			this.transform.position += new Vector3(-Speed, 0, 0);
		if(Input.GetKey(KeyCode.S))
			this.transform.position += new Vector3(0, -Speed, 0);
		if(Input.GetKey(KeyCode.W))
			this.transform.position += new Vector3(0, Speed, 0);
	}
}
