using UnityEngine;
using System.Collections;

public class onGuiLessonPickUp : MonoBehaviour {
	public bool show = false;
	// Use this for initialization
	void Start () {
		
	}
	void OnGUI(){
		
		if (show) {
			GUI.Label (new Rect (10, 10, 200, 50), "gui test");
		}
		
	}
	// Update is called once per frame
	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			showInventory ();
		}
	}
	
	void showInventory(){
		if (show) {
			show = false;
		} else {
			show = true;
		}
	}
	
}

