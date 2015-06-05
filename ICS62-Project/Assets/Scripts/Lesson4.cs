using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Lesson4 : MonoBehaviour {
	public static bool lesson4_show = false;
	public static bool lesson4_plan = false;
	public static int health = 5;
	private static bool tracker = true;
	private static string answer;
	public static string question;
	public static List<string> questions = new List<string>();

	
	// Use this for initialization
	void Start () {
		questions.Add ("A Note");
		questions.Add ("B Note");
		questions.Add ("C Note");
		questions.Add ("D Note");
		questions.Add ("E Note");
		questions.Add ("F Note");
		questions.Add ("G Note");
		questions.Add ("Middle C Note");
	}
	
	// Update is called once per frame
	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			showInventory ();
		}
	}
	
	public static void showInventory(){
		if (lesson4_show) {
			lesson4_show = false;
		} else {
			lesson4_show = true;
		}
	}
	public static void lesson4_text(Texture imgtexture){
		GUI.Box (new Rect (50, 50, 700, 500), "Lesson 4: Putting Notes on Music Sheet Part 3");
		GUI.DrawTexture (new Rect (100, 225, 375, 205), imgtexture);
		GUI.Label (new Rect (100, 100, 300, 300), "On the piano, when reading notes on the bass clef, " +
			"the note on the “invisible” line above the uppermost line of the staff represents middle C. " +
			"The note on the space between first two bottom lines of the staff represents another C, " +
			"exactly 7 notes below middle C. This holds true for every other note in the musical " +
			"alphabet - take any note, like E. 7 notes above it and 7 notes below it will also be E.");

		if (GUI.Button (new Rect (100, 450, 150, 50), "Continue Lesson")) {
			lesson4_show = false;
			lesson4_plan = true;
		}
		if (GUI.Button (new Rect (350, 450, 150, 50), "Exit")) {
			lesson4_show = false;
			GameObject.FindGameObjectWithTag("Pickup").SetActive(true);
			eventPlayerController.pickCount -= 1;
			PlayerMovement.MovementBool ();
		}
	}
	public static void LessonFourPlan(Texture note_a, Texture note_b, Texture note_c, Texture note_d, Texture note_e,
	                                  Texture note_f, Texture note_g, Texture note_mc)
	{
		while (health > 0) {
			questions.Add ("A Note");
			questions.Add ("B Note");
			questions.Add ("C Note");
			questions.Add ("D Note");
			questions.Add ("E Note");
			questions.Add ("F Note");
			questions.Add ("G Note");
			questions.Add ("Middle C Note");
			Lesson4Plan (note_a,note_b,note_c,note_d, note_e, note_f,note_g, note_mc);
			break;
		}
	}

	public static void Lesson4Plan(Texture note_a, Texture note_b, Texture note_c, Texture note_d, Texture note_e,
	                               Texture note_f, Texture note_g, Texture note_mc)
	{
		if (tracker == true) 
		{
			question = questions [Random.Range (0, questions.Count)];
			tracker = false;
		}
		
		switch (question) {

		case "A Note":
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 4, 500, 100), "Which note is the A note?");
			break;
			
		case "B Note":
	
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 4, 500, 100), "Which note is the B note?");
			break;
			
		case "C Note":
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 4, 500, 100), "Which note is the C note?");
			break;
			
		case "D Note":
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 4, 500, 100), "Which note is the D note?");
			break;
			
		case "E Note":
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 4, 500, 100), "Which note is the E note?");
			break;
		
		case  "F Note":
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 4, 500, 100), "Which note is the F note?");
			break;
		
		case  "G Note": 
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 4, 500, 100), "Which note is the G note?");
			break;

		case "Middle C Note":
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 4, 500, 100), "Which note is the Middle C note?");
			break;
		}
		if (GUI.Button (new Rect (Screen.width / 10, Screen.height / 2, 100, 100), note_a)) 
			{
				answer = "A Note";
			} 
			
		else if (GUI.Button (new Rect (Screen.width / 10 * 2, Screen.height / 2, 100, 100), note_b)) 
			{
				answer = "B Note";
			} 
			
		else if (GUI.Button (new Rect (Screen.width / 10 * 3, Screen.height / 2, 100, 100), note_c)) 
			{
				answer = "C Note";
			} 
			
		else if (GUI.Button (new Rect (Screen.width / 10 * 4, Screen.height / 2, 100, 100), note_d)) 
			{
				answer = "D Note";
			} 
			
		else if (GUI.Button (new Rect (Screen.width / 10 * 5, Screen.height / 2, 100, 100), note_e)) 
			{
				answer = "E Note";
			} 
		else if (GUI.Button (new Rect (Screen.width / 10 * 6, Screen.height / 2, 100, 100), note_f)) 
			{
				answer = "F Note";
			} 
		else if (GUI.Button (new Rect (Screen.width / 10 * 7, Screen.height / 2, 100, 100), note_g)) 
			{
				answer = "G Note";
			} 
		else if (GUI.Button (new Rect (Screen.width / 10 * 8, Screen.height / 2, 100, 100), note_mc)) 
			{
				answer = "Middle C Note";
			} 


		
		if (answer == question)
		{
			questions.Remove(question);
			tracker = true;
			health = health - 1;
			if (health == 0)
			{
				lesson4_plan = false;
				PlayerMovement.MovementBool();
			}
		}
	}
	
}

