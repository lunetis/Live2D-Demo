using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wink : MonoBehaviour {

	private Animator animator;
	private bool isPlaying;

	void Start () {
		animator = GetComponent<Animator>();
		isPlaying = false;
	}
	
	void Update()
	{
		if(isPlaying == false && Input.GetKeyDown(KeyCode.W))
		{
			StartCoroutine(PlayWink());
		}
	}

	private IEnumerator PlayWink()
	{
		isPlaying = true;
		animator.CrossFade("Wink", 0.12f);
		yield return new WaitForSeconds(2.8f);
		isPlaying = false;
	}


	// 버튼을 눌렀을 때를 위해서 따로 함수로 빼놓음
	// Additional function for pushing button
	public void CallWink()
	{
		if(isPlaying == false)
		{
			StartCoroutine(PlayWink());
		}
	}
}
