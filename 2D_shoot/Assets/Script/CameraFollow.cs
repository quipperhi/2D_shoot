using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{
	public static float CameraSpeed = 4f;

	void Update ()
	{
		MoveToward();
	}
	void MoveToward ()
	{
		transform.position = new Vector3(transform.position.x + CameraSpeed * Time.deltaTime, transform.position.y, transform.position.z);
	}

	public Vector3 GetPosition()
	{
		return new Vector3(transform.position.x, transform.position.y, transform.position.z + 10f);
	}
}
