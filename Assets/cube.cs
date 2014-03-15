using UnityEngine;
using System.Collections;

public class cube : MonoBehaviour {
	string aa;

	// Use this for initialization
	void Start () {
		aa = "";
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseOver(){
		if (Input.GetMouseButton (0)) {
			this.rotate();

			// call web side javascript function
			Application.ExternalCall( "puts", 1,2,3 );
			Application.ExternalCall( "console.log", 5, 6, 7 );
			Application.ExternalCall( "alert", 1 );
		}	
	}

	// define a null parameter function
	void rotate(){
		this.transform.Rotate (new Vector3 (0, 0, 10));
	}

	// you can't pass more than one parameter from web call unity function
	// so define function with only single parameter.
	string echo(string p1){
		aa = p1 + " (from Web JavaScript Invoke!)";
		return aa;
	}

	void OnGUI(){
		GUI.Label (new Rect (0, 0, Screen.width, Screen.height), aa);
	}
}
