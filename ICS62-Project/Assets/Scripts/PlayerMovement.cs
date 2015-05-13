using UnityEngine;
using System.Collections;
[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour {

	public float speed;
	public float rotation;
	public static bool AllowMove = true;
	CharacterController cc;

	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (AllowMove) {
			Vector3 forward = Input.GetAxis ("Vertical") * transform.TransformDirection (Vector3.down) * speed;
			transform.Rotate (new Vector3 (0, 0, Input.GetAxis ("Horizontal") * rotation * Time.deltaTime));
			cc.Move (forward * Time.deltaTime);
			cc.SimpleMove (Physics.gravity);
		}

	}

	public static void MovementBool(){
		if (AllowMove) {
			AllowMove = false;
		} else {
			AllowMove = true;
		}
	}



}
