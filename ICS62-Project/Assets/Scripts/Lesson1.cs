using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Lesson1 : MonoBehaviour {

	public static Vector3 start_pos = new Vector3(1124,40,1091);
	public static bool show = false;
	public static bool plan = false;
	public static int health = 5;
	public static int player_hp = 5;
	public static bool correct = true;
	private static bool tracker = true;

	private static string answer;
	private static string question;
	public static List<string> questions = new List<string>();
	

	// Update is called once per frame
	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			showInventory ();
		}
	}
	
	public static void showInventory(){
		if (show) {
			show = false;
		} else {
			show = true;
		}
	}
	public static void lesson1_text(Texture imgtexture){
		GUI.Box (new Rect (50, 50, 700, 500), "Lesson 1: Type of Musical Notes");
		GUI.DrawTexture (new Rect (100, 225, 375, 205), imgtexture);
		GUI.Label (new Rect (100, 100, 300, 300), "Music is written using different types of notes. " +
			"When placed on sheet music, notes represent which tone to play and for how long. " +
			"Visually, notes are a combination of two shapes - the head, which is shaped like an " +
			"oval, and a stem, which is shaped like a vertical line. The most commonly used notes to " +
			"denote music are:");
		if (GUI.Button (new Rect (100, 450, 150, 50), "Continue Lesson ")) {
			show = false;
			plan = true;
		}
		if (GUI.Button (new Rect (350, 450, 150, 50), "Exit Lesson")) {
			show = false;
			PlayerMovement.MovementBool ();
		
		}
	}

	public static void LessonOnePlan(Texture eighth, Texture quarter, Texture half, Texture dotted_half, Texture whole)
	{
		questions.Add ("eighth");
		questions.Add ("quarter");
		questions.Add ("half");
		questions.Add ("dotted_half");
		questions.Add ("whole");
		while (health > 0) {

			Lesson1Plan (eighth, quarter, half, dotted_half, whole);
			break;
		}
	}

	public static void Lesson1Plan(Texture eighth, Texture quarter, Texture half, Texture dotted_half, Texture whole)
	{
		if (tracker == true) {
			question = questions [Random.Range (0, questions.Count)];
			tracker = false;
		}
		switch (question) {
		case "eighth":
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 4, 500, 100), "Which note is the eighth note?");
			break;
		case "quarter":
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 4, 500, 100), "Which note is the quarter note?");
			break;
		case "half":
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 4, 500, 100), "Which note is the half note?");
			break;
		case "dotted_half":
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 4, 500, 100), "Which note is the dotted half note?");
			break;
		case "whole":
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 4, 500, 100), "Which note is the whole note?");
			break;
		}

			
		if (GUI.Button (new Rect (Screen.width / 10, Screen.height / 2, 100, 100), eighth)) {
			answer = "eighth";
			if (answer != question){
				player_hp = player_hp - 1; 
			}
		} else if (GUI.Button (new Rect (Screen.width / 10 * 3, Screen.height / 2, 100, 100), quarter)) {
			answer = "quarter";
			if (answer != question){
				player_hp = player_hp - 1; 
			}
		} else if (GUI.Button (new Rect (Screen.width / 2, Screen.height / 2, 100, 100), half)) {
			answer = "half";
			if (answer != question){
				player_hp = player_hp - 1; 
			}
		} else if (GUI.Button (new Rect (Screen.width / 10 * 7, Screen.height / 2, 100, 100), dotted_half)) {
			answer = "dotted_half";
			if (answer != question){
				player_hp = player_hp - 1; 
			}
		} else if (GUI.Button (new Rect (Screen.width / 10 * 9, Screen.height / 2, 100, 100), whole)) {
			answer = "whole";
			if (answer != question){
				player_hp = player_hp - 1; 
			}
		}


		if (answer == question) {
			tracker = true;
			questions.Remove (question);
			health = health - 1;
			if (health == 0) {
				plan = false;
				PlayerMovement.MovementBool ();
			}
		}
		//if (player_hp == 0) {
			//plan = false;
			///GameObject.FindGameObjectWithTag ("Player").transform.position = start_pos;
			//GameObject.FindGameObjectWithTag ("Pickup").SetActive (true);
			//eventPlayerController.pickCount -= 1;
			//PlayerMovement.MovementBool ();
		
		//}

			



	}
	


		
}

