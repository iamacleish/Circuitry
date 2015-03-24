using UnityEngine;
using System.Collections;

public class CameraInitialization : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Camera.main.orthographicSize = 30;
	}

	void OnGui(){
		float horizRatio = Screen.width / 1920.0f;
		float vertRatio = Screen.height / 1200.0f;
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3(horizRatio, vertRatio, 1.0f));
	}


	// Update is called once per frame
	void Update () {
	
	}
}
