using UnityEngine;
using System.Collections;

public class Enemy {

    public int ID { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
    public string Attack1Title { get; set; }
    public int Attack1Damage { get; set; }
    public double Attack1Scaling { get; set; }
    public string Attack2Title { get; set; }
    public int Attack2Damage { get; set; }
    public double Attack2Scaling { get; set; }

    //Constructor for 2-attack enemy
    public Enemy(int id, string title, string type, string attack1title, int attack1damage, double attack1scaling, string attack2title, int attack2damage, double attack2scaling) {
        this.ID = id;
        this.Title = title;
        this.Type = type;
        this.Attack1Title = attack1title;
        this.Attack1Damage = attack1damage;
        this.Attack1Scaling = attack1scaling;
        this.Attack2Title = attack2title;
        this.Attack2Damage = attack2damage;
        this.Attack2Scaling = attack2scaling;
    }
    //Constructor for nothing
    public Enemy() {
        this.ID = -1;
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
