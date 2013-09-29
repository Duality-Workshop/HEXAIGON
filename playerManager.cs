using UnityEngine;
using System.Collections;

public class playerManager : MonoBehaviour {
	
	public Rigidbody model;
	public Transform spawn;
	public float moveSpeed;
	public float jumpForce;
	
	private Rigidbody player;
	
	// Use this for initialization
	void Start () {
		player = Instantiate(model, spawn.position, spawn.rotation) as Rigidbody;
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
		float v = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
		
		player.transform.Translate(new Vector3(v, 0, -h));
		
		if (Input.GetButtonDown("Jump"))
		{
			player.AddForce(Vector3.up * jumpForce); //, ForceMode.Acceleration, jumpForce, ForceMode.Acceleration);
			Debug.Log("Jump!");
		}
	}
}
