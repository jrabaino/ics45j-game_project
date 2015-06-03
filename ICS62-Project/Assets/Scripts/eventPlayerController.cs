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

	public Texture imgTexture2;
	public Texture treble;
	public Texture bass;
	public Texture staff;

	public Texture imgTexture3;
	public Texture A;
	public Texture B;
	public Texture C;
	public Texture D;
	public Texture E;
	public Texture F;
	public Texture G;

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
			onGuiLessonPickUp.LessonOnePlan(eighth, quarter, half, dotted_half, whole);
		}

		if (Lesson2.lesson2_show) {
			Lesson2.lesson2_text (imgTexture2);
		}

		if (Lesson2.lesson2_plan) {
			Lesson2.LessonTwoPlan (staff, treble, bass);
		}

		if (Lesson3.lesson3_show) {
			Lesson3.lesson3_text (imgTexture3);
		}

		if (Lesson3.lesson3_plan) {
			Lesson3.LessonThreePlan (A, B, C, D, E, F, G);
		}
	}


	void OnTriggerEnter(Collider other) 
	{
		if (other.CompareTag("Pickup")) {
			other.gameObject.SetActive (false);
			pickCount += 1;
			PlayerMovement.MovementBool();
			onGuiLessonPickUp.showInventory();
			//Lesson2.showInventory();
			//Lesson3.showInventory();

		}
	}
}
