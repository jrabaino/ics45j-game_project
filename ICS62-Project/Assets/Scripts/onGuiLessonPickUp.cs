using UnityEngine;
using System.Collections;

public class onGuiLessonPickUp : MonoBehaviour {
	public static bool show = false;

	// Use this for initialization
	void Start () {
		
	}

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
	public static void lesson1(Texture imgtexture){
		GUI.Box (new Rect (50, 50, 700, 500), "Lesson 1: Type of Musical Notes");
		GUI.Label(new Rect (100, 200, 100, 100), imgtexture);
		GUI.Label(new Rect (100, 100, 300, 300), "Music is written using different types of notes. " +
		          "When placed on sheet music, notes represent which tone to play and for how long. " +
		          "Visually, notes are a combination of two shapes - the head, which is shaped like an " +
		          "oval, and a stem, which is shaped like a vertical line. The most commonly used notes to " +
		          "denote music are:");
		GUI.Button (new Rect (100, 450, 150, 50), "Continue Lesson");
	}

	
}

