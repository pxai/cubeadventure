
using System;

public class Cube  {
	private Cell[,] cells;
	private const int SIZE = 10;
	private const int MAX_DAMAGE = 4;
	private Player player;

	public Cube () {
		cells = new Cell[SIZE,SIZE];
		init ();
	}

	// inits prison
	private void init () {
		Random random = new Random ();

		for (int i = 0; i < SIZE; i++) {
			for (int j = 0; j < SIZE; j++) {
				cells [i,j] = new Cell ("Cell-"+random.Next(100,1000), random.Next(0,MAX_DAMAGE));
			}
		}

		// set the one and only exit cell
		cells [random.Next (0, 10),random.Next (0, 10)].setAnExit (true);
		// inti player
		player = new Player(random.Next (0, 10),random.Next (0, 10));
	}


	/*
	 * moves player and returns status
	 */
	public int goNorth () {
		if (player.getY() == SIZE - 1) {
			return 0;
		} else {
			player.setY (player.getY() + 1);
			return currentStatus();
		}
	}

	/*
	 * moves player and returns status
	 */
	public int goSouth () {
		if (player.getY() == 0) {
			return 0;
		} else {
			player.setY (player.getY() - 1);
			return currentStatus();
		}
	}

	/*
	 * moves player and returns status
	 */
	public int goEast () {
		if (player.getX() == SIZE - 1) {
			return 0;
		} else {
			player.setX (player.getX() + 1);
			return currentStatus();
		}
	}

	/*
	 * moves player to west and returns status
	 */
	public int goWest () {
		if (player.getX() == 0) {
			return 0;
		} else {
			player.setX (player.getX() - 1);
			return currentStatus();
		}
	}

	/**
	 * determines the new status of the player 
	 * 1 : ok
	 * 0 : movement is not possible
	 * -1 : ok, and it's an exit!!
	 * -2 : player is dead
	 */
	private int currentStatus () {
		Cell currentCell = cells [player.getX (), player.getY ()];
		player.decreasePoints (currentCell.getDamage ());

		if (player.isDead ()) {
			return -2;
		} else if (currentCell.isAnExit ()) {
			return -1;
		} else {
			return 1;
		}
	}

	// Displays cube configuration for debug purposes
	public string showCube () {
		string cube = "";
		for (int i = 0; i < SIZE; i++) {
			for (int j = 0; j < SIZE; j++) {
				cube = cube + "[("+i +","+j+"),"+cells[i,j].getDamage()+","+cells[i,j].isAnExit()+"] ,";
			}
			cube = cube + "\n";
		}

		return cube;
	}

	// return player
	public Player getPlayer () {
		return player;
	}

}
