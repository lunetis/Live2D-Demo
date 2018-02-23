using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPoint : MonoBehaviour {

	public Camera cam;
	private Vector3 vector = new Vector3();

	// Face / Eye Correction
	// 얼굴 및 눈 초기값 수정
	public Vector3 correctionVector = new Vector3();
	public float factor;

	void Start()
	{
		transform.position = correctionVector;
	}

	void Update () {
		if(Input.GetMouseButton(0))
		{
			vector = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

			transform.position = (vector * factor) + correctionVector;
		}

		else
		{
			transform.position = correctionVector;
		}
	}
}
