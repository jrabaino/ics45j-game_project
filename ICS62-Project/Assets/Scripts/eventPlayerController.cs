using UnityEngine;
using System.Collections;

public class eventPlayerController : MonoBehaviour {

	public static int pickCount;
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

	public Texture imgTexture4;
	public Texture clefA;
	public Texture clefB;
	public Texture clefC;
	public Texture clefD;
	public Texture clefE;
	public Texture clefF;
	public Texture clefG;
	public Texture clefMC;

	public Texture imgTexture5;
	public Texture isecond;
	public Texture ithird;
	public Texture ifourth;
	public Texture ififth;
	public Texture isixth;
	public Texture iseventh;
	public Texture ioctave;


	void Start () {
		pickCount = 0;


	}


	//GameObject.FindGameObjectWithTag("Pickup").SetActive(false);
	

	
	void OnGUI(){
		GUI.Label (new Rect (10, 10, 200, 50), "Lessons collected: " + pickCount.ToString () + " /5");
		if (Lesson1.show) {
			Lesson1.lesson1_text (imgTexture);

		}
		if (Lesson1.plan) {
			Lesson1.LessonOnePlan (eighth, quarter, half, dotted_half, whole);
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
		if (Lesson4.lesson4_show) {
			Lesson4.lesson4_text (imgTexture4);
		}
		
		if (Lesson4.lesson4_plan) {
			Lesson4.LessonFourPlan (clefA, clefB, clefC, clefD, clefE, clefF, clefG,clefMC);
		}
		if (Lesson5.lesson5_show) {
			Lesson5.lesson5_text (imgTexture4);
		}
		
		if (Lesson5.lesson5_plan) {
			Lesson5.LessonFivePlan (isecond, ithird, ifourth, ififth, isixth, iseventh, ioctave);
		}
	}


	void OnTriggerEnter(Collider other) 
	{
		if (other.CompareTag("Pickup")) {
			other.gameObject.SetActive (false);
			pickCount += 1;
			PlayerMovement.MovementBool();
			Lesson1.showInventory();
			

		}
		else if (other.CompareTag("Pickup2")) {
			other.gameObject.SetActive (false);
			pickCount += 1;
			PlayerMovement.MovementBool();
			Lesson2.showInventory();
			
		}
		if (other.CompareTag("Pickup3")) {
			other.gameObject.SetActive (false);
			pickCount += 1;
			PlayerMovement.MovementBool();
			Lesson3.showInventory();
			
		}
		if (other.CompareTag("Pickup4")) {
			other.gameObject.SetActive (false);
			pickCount += 1;
			PlayerMovement.MovementBool();
			Lesson4.showInventory();
			
		}
		if (other.CompareTag("Pickup5")) {
			other.gameObject.SetActive (false);
			pickCount += 1;
			PlayerMovement.MovementBool();
			Lesson5.showInventory();
			
		}
	}
}
