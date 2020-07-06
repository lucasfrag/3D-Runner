using UnityEngine;
using System.Collections;

public class playerCharacterScript : MonoBehaviour {

	Animator playerAnimator;

	void Start () {
		playerAnimator = GetComponent<Animator> ();
	}
	
	public void Jump(){
		playerAnimator.SetTrigger("Attack");
	}
	
	public void Crouch(){
		playerAnimator.SetTrigger("Hit");
	}

	public void Death(){
		playerAnimator.SetTrigger("Death");
	}

	public void Move(float v,float h){
		playerAnimator.SetFloat ("Forward", v);
		playerAnimator.SetFloat ("Turn", h);
	}
}
