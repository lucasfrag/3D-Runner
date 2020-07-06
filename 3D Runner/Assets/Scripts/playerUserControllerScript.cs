using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class playerUserControllerScript : MonoBehaviour {

	playerCharacterScript playerCharacter;

	//Set keys
	public KeyCode jump;
	public KeyCode crouch;
	public KeyCode moveLeft;
	public KeyCode moveRight;

	public int laneNumber = 2;
	public string controlLocked = "n";

	public float speedMove = 4.0f; //Set player velocity
	public float move;
    public float altura;

	public Vector3 playerJump;
	public float jumpForce = 2.0f;

	public bool isGrounded;
	Rigidbody playerRB;
    Animator playerAnimator;
	
	void Start () {
        playerAnimator = GetComponent<Animator>();
		//playerCharacter = GetComponent <playerCharacterScript> ();
		playerRB = GetComponent <Rigidbody> ();
		move = speedMove;
	}

	void OnCollisionStay(Collision collisionInfo) {
		if (collisionInfo.gameObject.CompareTag ("Ground")) {
			isGrounded = true;
		}
	}

	void Update () {
        altura = transform.position.y;
        transform.Translate (0, 0, move * Time.deltaTime);

        if(altura < -3) {
            SceneManager.LoadScene(0);
        }

		if (Input.GetKeyDown (jump) && isGrounded == true) {
            playerAnimator.SetTrigger("Jump");
            playerRB.AddForce(playerJump * jumpForce, ForceMode.Impulse);
			isGrounded = false;
		}
		
		if (Input.GetKeyDown (crouch)) {
			//playerCharacter.Crouch();
		}
			
		if ((Input.GetKeyDown (moveLeft)) && (laneNumber > 1) && (controlLocked == "n")) {
			transform.Translate (-1, 0, 0);
			//StartCoroutine (stopSlide ());
			laneNumber -= 1;
			//controlLocked = "y";
		}

		if ((Input.GetKeyDown (moveRight)) && (laneNumber < 3) && (controlLocked == "n")) {
			transform.Translate (1, 0, 0);
			//StartCoroutine (stopSlide ());
			laneNumber += 1;
			//controlLocked = "y";
		}
	}

	IEnumerator stopSlide () {
		yield return new WaitForSeconds (0.1f);
		controlLocked = "n";
	}
}
