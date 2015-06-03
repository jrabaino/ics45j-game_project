using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Lesson2 : MonoBehaviour {
	public static bool lesson2_show = false;
	public static bool lesson2_plan = false;
	public static int health = 5;
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
		if (lesson2_show) {
			lesson2_show = false;
		} else {
			lesson2_show = true;
		}
	}

	public static void lesson2_text(Texture imgtexture){
		GUI.Box (new Rect (50, 50, 700, 500), "Lesson 2: Sheet Music Symbols");
		GUI.DrawTexture (new Rect (100, 225, 375, 205), imgtexture);
		GUI.Label (new Rect (100, 100, 500, 300), "Notes are not the only components of sheet music. Notes are placed on a staff," +
		           "which is represented by five horizontal lines. On sheet music for the piano," +
		           "there are usually two staffs, and altogether they are called the grand staff. " + 
		           "At the very beginning of each staff is a symbol called a clef, which indicates " +
		           "what region of the piano the notes placed on it is supposed to represent." +
		           "The upper staff is marked by the treble clef, denoting that the notes to be played on it " +
		           "are higher in pitch. The lower staff is marked by the bass clef, denoting that the notes " +
		           "to be played on it are lower in pitch.");
		if (GUI.Button (new Rect (100, 450, 150, 50), "Continue Lesson")) {
			lesson2_show = false;
			lesson2_plan = true;
		}
		if (GUI.Button (new Rect (350, 450, 150, 50), "Exit")) {
			lesson2_show = false;
			PlayerMovement.MovementBool ();
		}
	}

	public static void LessonTwoPlan(Texture staff, Texture treble, Texture bass)
	{
		while (health>0) {
			questions.Add ("treble_staff");
			questions.Add ("bass_staff");
			questions.Add ("treble");
			questions.Add ("bass");
			questions.Add ("staff");
			Lesson2Plan (staff, treble, bass);
			break;
		}

	}

	public static void Lesson2Plan(Texture staff, Texture treble, Texture bass)
	{
		if (tracker == true) {
			question = questions [Random.Range (0, questions.Count)];
			tracker = false;
		}
		switch(question)
		{
		case "treble_staff":
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 4, 500, 100), "In general, what does the treble clef represent when placed on a staff?");
			break;
		case "bass_staff":
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 4, 500, 100), "In general, what does the bass clef represent when placed on a staff?");
			break;
		case "treble":
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 4, 500, 100), "What is this called");
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 3, 500, 100), treble);
			break;
		case "bass":
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 4, 500, 100), "What is this called");
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 3, 500, 100), bass);
			break;
		case "staff":
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 4, 500, 100), "What is this called");
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 3, 500, 100), staff);
			break;
		}

		if (GUI.Button (new Rect (Screen.width / 10, Screen.height / 2, 250, 100), "Higher pitched notes")) 
		{
			answer = "treble_staff";
		}
		
		else if (GUI.Button (new Rect (Screen.width / 10 * 3, Screen.height / 2, 250, 100), "Lower pitched notes")) 
		{
			answer = "bass_staff";
		} 
		
		else if (GUI.Button (new Rect (Screen.width / 2, Screen.height / 2, 100, 100), "Treble cleff")) 
		{
			answer = "treble";
		} 
		
		else if (GUI.Button (new Rect (Screen.width / 10 * 7, Screen.height / 2, 100, 100), "Bass cleff")) 
		{
			answer = "bass";
		} 
		
		else if (GUI.Button (new Rect (Screen.width / 10 * 9, Screen.height / 2, 100, 100), "Music staff")) 
		{
			answer = "staff";
		}
		if (answer == question)
		{
			tracker = true;
			questions.Remove(question);
			health = health - 1;
			if (health == 0)
			{
				lesson2_plan = false;
				PlayerMovement.MovementBool();
			}
		}

	}
}
