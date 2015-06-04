using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Lesson5 : MonoBehaviour {
	public static bool lesson5_show = false;
	public static bool lesson5_plan = false;
	public static int health = 5;
	private static bool tracker = true;
	private static string answer;
	public static string question;
	public static List<string> questions = new List<string>();
	
	
	// Use this for initialization
	void Start () {
		questions.Add ("second");
		questions.Add ("third");
		questions.Add ("fourth");
		questions.Add ("fifth");
		questions.Add ("sixth");
		questions.Add ("seventh");
		questions.Add ("octave");
	}
	
	// Update is called once per frame
	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			showInventory ();
		}
	}
	
	public static void showInventory(){
		if (lesson5_show) {
			lesson5_show = false;
		} else {
			lesson5_show = true;
		}
	}

	public static void lesson5_text(Texture imgtexture){
		GUI.Box (new Rect (50, 50, 700, 500), "Lesson 5: Intervals");
		GUI.DrawTexture (new Rect (100, 225, 375, 205), imgtexture);
		GUI.Label (new Rect (100, 100, 600, 300), "The vertical distance between two notes " +
					"(whether they’re on top of each other or next to each other) is called an interval. " +
					"As a rule of thumb, to calculate the interval between two notes, count the total " +
					"amount of lines and spaces it takes to get from the bottom note to the top note. " +
					"For example, the first interval in the picture is called a second because it takes " +
					"one space and one line (a total of two) to get from the bottom note to the top note." +
					"Musicians take into account intervals when composing music, as a second sounds much " +
					"different than a fourth, a third much different than an octave, etc.");

		if (GUI.Button (new Rect (100, 450, 150, 50), "Continue Lesson")) {
			lesson5_show = false;
			lesson5_plan = true;
		}
		if (GUI.Button (new Rect (350, 450, 150, 50), "Exit")) {
			lesson5_show = false;
			PlayerMovement.MovementBool ();
		}
	}

	public static void LessonFivePlan(Texture second, Texture third, Texture fourth, Texture fifth, Texture sixth,
	                               Texture seventh, Texture octave)
	{
		while (health > 0) {
			questions.Add ("second");
			questions.Add ("third");
			questions.Add ("fourth");
			questions.Add ("fifth");
			questions.Add ("sixth");
			questions.Add ("seventh");
			questions.Add ("octave");
		
			Lesson5Plan (second,third,fourth,fifth, sixth, seventh,octave);
			break;
		}
	
	
	
	
	}
	public static void Lesson5Plan(Texture second, Texture third, Texture fourth, Texture fifth, Texture sixth,
	                               Texture seventh, Texture octave)
	{
		if (tracker == true) 
		{
			question = questions [Random.Range (0, questions.Count)];
			tracker = false;
		}
		
		switch (question) {

		case "second":
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 4, 500, 100), "Which of the following is the second interval?");
			break;

		case "third":
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 4, 500, 100), "Which of the following is the third interval?");
			break;
		case "fourth":
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 4, 500, 100), "Which of the following is the fourth interval?");
			break;
		case "fifth":
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 4, 500, 100), "Which of the following is the fifth interval?");
			break;

		case "sixth":
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 4, 500, 100), "Which of the following is the sixth interval?");
			break;

		case "seventh":
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 4, 500, 100), "Which of the following is the seventh interval?");
			break;

		case "octave":
			GUI.Label (new Rect (Screen.width / 2 - 100, Screen.height / 4, 500, 100), "Which of the following is the octave interval?");
			break;

		
		
		}


			 
			if (GUI.Button (new Rect (Screen.width / 10, Screen.height / 2, 100, 100), second)) 
			{
				answer = "second";
			} 
			
			else if (GUI.Button (new Rect (Screen.width / 10 * 2, Screen.height / 2, 100, 100), third)) 
			{
				answer = "third";
			} 
			
			else if (GUI.Button (new Rect (Screen.width / 10 * 3, Screen.height / 2, 100, 100), fourth)) 
			{
				answer = "fourth";
			} 
			
			else if (GUI.Button (new Rect (Screen.width / 10 * 4, Screen.height / 2, 100, 100), fifth)) 
			{
				answer = "fifth";
			} 
			
			else if (GUI.Button (new Rect (Screen.width / 10 * 5, Screen.height / 2, 100, 100), sixth)) 
			{
				answer = "sixth";
			} 
			else if (GUI.Button (new Rect (Screen.width / 10 * 6, Screen.height / 2, 100, 100), seventh)) 
			{
				answer = "seventh";
			} 
			else if (GUI.Button (new Rect (Screen.width / 10 * 7, Screen.height / 2, 100, 100), octave)) 
			{
				answer = "octave";
			} 
	
		
		if (answer == question)
		{
			questions.Remove(question);
			tracker = true;
			health = health - 1;
			if (health == 0)
			{
				lesson5_plan = false;
				PlayerMovement.MovementBool();
			}
		}
	}
	
}



