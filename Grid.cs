using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	public Rigidbody bloc;
	public Transform origin;
	public int length;
	public int width;
	
	private Vector3[] gridPos;
	
	void Start () 
	{
		for(float i = 0 ; i<length ; i++)
		{
			for(float j = 0 ; j<width ; j++)
			{
				if (i%2==0)
				{
					Instantiate (bloc, new Vector3(j-j*(1-Mathf.Sqrt(3)/2), 1, i-i*0.25f), origin.rotation);
				}
				else
				{
					Instantiate (bloc, new Vector3(j+Mathf.Sqrt(3)/4-j*(1-Mathf.Sqrt(3)/2), 1, i-i*0.25f), origin.rotation);
				}
			}
		}
		
	}
}
