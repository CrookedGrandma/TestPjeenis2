using UnityEngine;
using UnityEngine.UI;
using LitJson;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class EnemyChooser : MonoBehaviour {

    public List<Enemy> EnemyDatabase = new List<Enemy>();
    public JsonData EnemyStats;

    EnemySprite currentEnemy;
    int enemyC = -1;
    bool enemyChosen;
    bool enemyFound;
    bool enemyEntered;
    bool enemyLoaded;

    public Text announce;
    public Text enemyStat;

	// Use this for initialization
	void Start () {
        enemyC = ThirdPersonController.player.Enemy;
        enemyChosen = false;
        enemyFound = false;
        enemyEntered = false;
        enemyLoaded = false;

        EnemyStats = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/Enemies.json"));
        ConstructEnemyDatabase();
	}

	// Update is called once per frame
	void Update () {
	    if (enemyC != -1) {
            print("In combat: " + enemyC);
        }
        if (!enemyChosen) {
            EnemySprite[] currentEnemies = Object.FindObjectsOfType<EnemySprite>();
            foreach (EnemySprite e in currentEnemies) {
                e.opacity(0f);
                if (e.ID == enemyC) {
                    currentEnemy = e;
                    enemyFound = true;
                    announce.text = "You're up against: " + currentEnemy.linkedEnemy.Title;
                    enemyStat.text = "Attack 1: " + currentEnemy.linkedEnemy.Attack1Title + "\n" + "Damage: " + currentEnemy.linkedEnemy.Attack1Damage + "\n" +
                                     "Attack 2: " + currentEnemy.linkedEnemy.Attack2Title + "\n" + "Damage: " + currentEnemy.linkedEnemy.Attack2Damage;
                    e.opacity(1f);
                }
            }
            if (!enemyFound) {
                currentEnemy = null;
            }
            else if (!enemyEntered) {
                currentEnemy.pleaseEnter = true;
                enemyEntered = true;
            }
            if (!enemyLoaded) {

            }
            enemyChosen = true;
        }
	}

    private void ConstructEnemyDatabase() {
        for (int i = 0; i < EnemyStats.Count; i++) {
            if (EnemyStats[i]["type"].ToString() == "2attack") {
                EnemyDatabase.Add(new Enemy((int)EnemyStats[i]["id"], EnemyStats[i]["title"].ToString(), EnemyStats[i]["type"].ToString(),
                    EnemyStats[i]["attack1title"].ToString(), (int)EnemyStats[i]["attack1damage"],
                    (double)EnemyStats[i]["attack1scaling"], EnemyStats[i]["attack2title"].ToString(),
                    (int)EnemyStats[i]["attack2damage"], (double)EnemyStats[i]["attack2scaling"]));
            }
        }
    }
}