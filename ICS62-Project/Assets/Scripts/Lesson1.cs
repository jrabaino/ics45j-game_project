using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Lesson1 : MonoBehaviour {
	
	public Texture eighth;
	public Texture quarter;
	public Texture half;
	public Texture dotted_half;
	public Texture whole;
	private int health;
	private bool tracker;
	private string answer;
	private string question;
	private List<string> questions = new List<string>();
	
	// Use this for initialization
	void Start () 
	{
		tracker = true;
		health = 5;
		questions.Add ("eighth");
		questions.Add ("quarter");
		questions.Add ("half");
		questions.Add ("dotted_half");
		questions.Add ("whole");


	}

	void Update()
	{
		if (tracker == true) 
		{
			question = questions [Random.Range (0, questions.Count)];
			tracker = false;
		}

		while (questions.Count>0) 
		{
			Debug.Log (2);
			//question = questions [Random.Range (0, questions.Count)];
			OnGUI ();
			Debug.Log (answer);
			break;
		}

		if (answer == question)
		{
			questions.Remove(question);
			tracker = true;
			health = health - 1;
		}

	}
	
	void OnGUI()
	{	

		if (question == "eighth") 
		{
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 4, 500, 100), "Which note is the eighth note?");
		} 

		else if (question == "quarter") 
		{
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 4, 500, 100), "Which note is the quarter note?");
		} 

		else if (question == "half") 
		{
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 4, 500, 100), "Which note is the half note?");
		} 

		else if (question == "dotted_half") 
		{
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 4, 500, 100), "Which note is the dotted half note?");
		} 

		else if (question == "whole") 
		{
			GUI.Label (new Rect (Screen.width / 2-100, Screen.height / 4, 500, 100), "Which note is the whole note?");
		}

		if (GUI.Button (new Rect (Screen.width / 10, Screen.height / 2, 100, 100), eighth)) 
		{
			answer = "eighth";
		} 

		else if (GUI.Button (new Rect (Screen.width / 10 * 3, Screen.height / 2, 100, 100), quarter)) 
		{
			answer = "quarter";
		} 

		else if (GUI.Button (new Rect (Screen.width / 2, Screen.height / 2, 100, 100), half)) 
		{
			answer = "half";
		} 

		else if (GUI.Button (new Rect (Screen.width / 10 * 7, Screen.height / 2, 100, 100), dotted_half)) 
		{
			answer = "dotted_half";
		} 

		else if (GUI.Button (new Rect (Screen.width / 10 * 9, Screen.height / 2, 100, 100), whole)) 
		{
			answer = "whole";
		} 


	}
}
