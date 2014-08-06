using UnityEngine;
using System.Collections;

public class CherryTest : MonoBehaviour {

	public float Speed = 0.05f;
	public float Distance = 4f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var player = GetPlayer();
		if(player != null) {
			ChasePlayer(player);
		}
	}

	GameObject GetPlayer() {
		var p = new Vector2(transform.position.x, transform.position.y);
		var l = Physics2D.OverlapCircleAll(p, Distance);
		foreach(var collider in l){
			var go = collider.gameObject;
			if(go.CompareTag("player"))
				return go;
		}
		return null;
	}

	void ChasePlayer(GameObject player) {
		var d = (player.transform.position - this.transform.position);
		d.z = 0f;
		d.Normalize();
		this.transform.position += (d * this.Speed);
	}
}
