using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class pickUpScript : MonoBehaviour {

	public Text pointText;
	private int point;

	void Start () {
		point = 0;
		SetCountText ();
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("PickUp")) {
			other.gameObject.SetActive (false);
			point = point + 1;
			SetCountText ();
		}
	}


	void SetCountText () {
		pointText.text = "Points: " + point.ToString ();
	}
}