
using System.Collections;

public class Player  {
	private string name;
	private int points;
	private int x;
	private int y;

	public Player (int x, int y) {
		this.x = x;
		this.y = y;
		points = 15;		
	}

	public int getPoints () {
		return points;
	}

	public void decreasePoints (int damage) {
		points = points - damage;
	}

	public string getName () {
		return name;
	}

	public int getX () {
		return x;
	}

	public void setX(int x) {
		this.x = x;
	}
		
	public int getY () {
		return y;
	}

	public void setY(int y) {
		this.y = y;
	}

	public bool isDead () {
		return points < 0;
	}

	public string toString () {
		return "Player.  [x:" + x + ",y:" + y + "]: " + points +"p."; 
	}
}
