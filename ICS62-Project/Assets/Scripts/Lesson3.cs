using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Lesson3 : MonoBehaviour {
	public static bool lesson3_show = false;
	public static bool lesson3_plan = false;
	public static int health = 5;
	private static bool tracker = true;
	private static string answer;
	private static string question;
	public static List<string> questions = new List<string>();


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			showInventory ();
		}
	}

	public static void showInventory(){
		if (lesson3_show) {
			lesson3_show = false;
		} else {
			lesson3_show = true;
		}
	}
	public static void lesson3_text(Texture imgtexture){
		GUI.Box (new Rect (50, 50, 700, 500), "Lesson 3: Musical Notes *Treble Cleff*");
		GUI.DrawTexture (new Rect (100, 225, 375, 205), imgtexture);
		GUI.Label (new Rect (100, 100, 500, 300), "We will now learn how to read treble cleff notes when they are placed on the sheet music." +
		           "On the piano, the note on the “invisible” line under the bottommost line of the staff represents middle C." +
		           "Notice how the notes are lettered in the range of A through G. " + 
		           "After G, the lettering of the notes go back to A. " +
		           "Here, we start at C, and go through the musical alphabet until we reach another C, 7 notes later.");
		if (GUI.Button (new Rect (100, 450, 150, 50), "Continue Lesson")) {
			lesson3_show = false;
			lesson3_plan = true;
		}
		if (GUI.Button (new Rect (350, 450, 150, 50), "Exit")) {
			lesson3_show = false;
			PlayerMovement.MovementBool ();
		}
	}

	public static void LessonThreePlan(Texture A, Texture B, Texture C, Texture D, Texture E, Texture F, Texture G)
	{
		while (health>0) {
			questions.Add ("A");
			questions.Add ("B");
			questions.Add ("C");
			questions.Add ("D");
			questions.Add ("E");
			questions.Add ("F");
			questions.Add ("G");
			Lesson3Plan (A, B, C, D, E, F, G);
			break;
		}	
	}

	public static void Lesson3Plan(Texture A, Texture B, Texture C, Texture D, Texture E, Texture F, Texture G)
	{
		if (tracker == true) {
			question = questions [Random.Range (0, questions.Count)];
			tracker = false;
		}
		switch(question)
		{
		case "A":
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 4, 500, 100), "What note is this?");
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 3, 500, 100), A);
			break;
		case "B":
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 4, 500, 100), "What note is this?");
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 3, 500, 100), B);
			break;
		case "C":
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 4, 500, 100), "What note is this?");
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 3, 500, 100), C);
			break;
		case "D":
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 4, 500, 100), "What note is this?");
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 3, 500, 100), D);
			break;
		case "E":
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 4, 500, 100), "What note is this?");
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 3, 500, 100), E);
			break;
		case "F":
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 4, 500, 100), "What note is this?");
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 3, 500, 100), F);
			break;
		case "G":
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 4, 500, 100), "What note is this?");
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 3, 500, 100), G);
			break;
		}
		
		if (GUI.Button (new Rect (Screen.width / 21, Screen.height / 2, 100, 100), "A")) 
		{
			answer = "A";
		}
		
		else if (GUI.Button (new Rect (Screen.width / 7, Screen.height / 2, 100, 100), "B")) 
		{
			answer = "B";
		} 
		
		else if (GUI.Button (new Rect (Screen.width / 7 * 2, Screen.height / 2, 100, 100), "C")) 
		{
			answer = "C";
		} 
		
		else if (GUI.Button (new Rect (Screen.width / 7 * 3, Screen.height / 2, 100, 100), "D")) 
		{
			answer = "D";
		} 
		
		else if (GUI.Button (new Rect (Screen.width / 7 * 4, Screen.height / 2, 100, 100), "E")) 
		{
			answer = "E";
		}

		else if (GUI.Button (new Rect (Screen.width / 7 * 5, Screen.height / 2, 100, 100), "F")) 
		{
			answer = "F";
		}

		else if (GUI.Button (new Rect (Screen.width / 7 * 6, Screen.height / 2, 100, 100), "G")) 
		{
			answer = "G";
		}
		if (answer == question)
		{
			tracker = true;
			questions.Remove(question);
			health = health - 1;
			if (health == 0)
			{
				lesson3_plan = false;
				PlayerMovement.MovementBool();
			}
		}

	}
}
