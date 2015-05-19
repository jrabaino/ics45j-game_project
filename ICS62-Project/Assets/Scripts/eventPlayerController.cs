using UnityEngine;
using System.Collections;

public class eventPlayerController : MonoBehaviour {

	public int pickCount;
	public Texture imgTexture;
	public GUIText lessonText;

	void Start () {
		pickCount = 0;
	}
	void OnGUI(){
		GUI.Label (new Rect (10, 10, 200, 50), "Lessons collected: " + pickCount.ToString()+" /10");
		if (onGuiLessonPickUp.show) {
			onGuiLessonPickUp.lesson1(imgTexture);

		}
	}


	void OnTriggerEnter(Collider other) 
	{
		if (other.CompareTag("Pickup")) {
			other.gameObject.SetActive (false);
			pickCount += 1;
			PlayerMovement.MovementBool();
			onGuiLessonPickUp.showInventory();

		}
	}
}
