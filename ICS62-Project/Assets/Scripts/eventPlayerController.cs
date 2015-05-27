using UnityEngine;
using System.Collections;

public class eventPlayerController : MonoBehaviour {

	public int pickCount;
	public Texture imgTexture;
	public Texture eighth;
	public Texture quarter;
	public Texture half;
	public Texture dotted_half;
	public Texture whole;
	public GUIText lessonText;

	void Start () {
		pickCount = 0;
	}
	
	void OnGUI(){
		GUI.Label (new Rect (10, 10, 200, 50), "Lessons collected: " + pickCount.ToString()+" /10");
		if (onGuiLessonPickUp.show) {
			onGuiLessonPickUp.lesson1(imgTexture);

		}
		if (onGuiLessonPickUp.plan) {

			onGuiLessonPickUp.questions.Add ("eighth");
			onGuiLessonPickUp.questions.Add ("quarter");
			onGuiLessonPickUp.questions.Add ("half");
			onGuiLessonPickUp.questions.Add ("dotted_half");
			onGuiLessonPickUp.questions.Add ("whole");
			while (onGuiLessonPickUp.health > 0){
				onGuiLessonPickUp.Lesson1Plan (eighth, quarter, half, dotted_half, whole);
				break;
			}
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
