using UnityEngine;
using System.Collections;

public class Cell {
	private string name;
	private bool anExit;
	private int damage;

	public Cell (string name, int damage) {
		this.name = name;
		this.damage = damage;
	}

	public string getName () {
		return name;
	}

	public bool isAnExit () {
		return anExit;
	}

	public void setAnExit(bool anExit) {
		this.anExit = anExit;
	}

	public int getDamage () {
		return damage;
	}

}
