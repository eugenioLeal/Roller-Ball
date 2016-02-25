using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	// Since we dont use forces void Updade is used instead of void FixedUpdate
	void Update () {
        /*delta Time is to get The time in seconds it took to complete the last frame (Read Only).
        to make your game frame rate independent.*/
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
}
