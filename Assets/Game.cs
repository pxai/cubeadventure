using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Game : MonoBehaviour {

	private Cube cube;
	public Text playerStatus;
	public Text gameStatus;

	// Use this for initialization
	void Start () {
		cube = new Cube ();
		print (cube.showCube());
		gameStatus.text = "Ready to move?";
		playerStatus.text = cube.getPlayer().toString();
	}
	
	// Update is called once per frame
	void Update () {
		int result = 0;
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			result = cube.goNorth ();
			print ("Down was pressed. New status: " + cube.getPlayer().toString ());
			showStatus (result);
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			result = cube.goSouth ();
			print ("Up was pressed. New status: " + cube.getPlayer().toString ());
			showStatus (result);
		} else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			result = cube.goWest ();
			print ("Left was pressed. New status: " + cube.getPlayer().toString ());
			showStatus (result);
		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			result = cube.goEast ();
			print ("Right was pressed. New status: " + cube.getPlayer().toString ());
			showStatus (result);
		} 

	}

	// Show messages depending on the status
	private void showStatus (int resultCode) {
		switch (resultCode) {
		case -2:
			gameStatus.text = "You are DEAD";
			break;
		case -1:
			gameStatus.text = "YOU ARE FREE!!!";
			break;
		default:
			gameStatus.text = "Try harder";
			break;
		}

		playerStatus.text = cube.getPlayer ().toString ();
		print (gameStatus.text);
	}
}
