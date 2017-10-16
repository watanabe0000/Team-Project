using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    [SerializeField]
    private GameObject enemy1;
    [SerializeField]
    private GameObject enemy2;
    [SerializeField]
    private GameObject enemy3;

    [SerializeField]
    private float x, y;

    private float timeElapsed;
    private float spawnTime;
    private int repeatTimes;
    
    enum Dir {
        NORTH = 0,
        EAST = 1,
        SOUTH = 2,
        WEST = 3
    };

    void CreateEnemy(GameObject _obj, Dir _direction) {
        var degree = 0;

        switch (_direction) {
            default:
            case Dir.NORTH: degree = 0; break;
            case Dir.EAST: degree = 90; break;
            case Dir.SOUTH: degree = 180; break;
            case Dir.WEST: degree = 270; break;
        }

        var obj = Instantiate(_obj, _obj.transform.position, _obj.transform.rotation);
        obj.transform.position = new Vector2(Random.value * x - x/2, Random.value * 2 + y);
        obj.transform.RotateAround(Vector3.zero, new Vector3(0, 0, 1), -degree);
    }

	void Start () {
        spawnTime = 2f;
	}
	
	void Update () {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= spawnTime) {
            Dir direction = (Dir)Random.Range(0, 4);

            if (repeatTimes % 15 == 0)
                CreateEnemy(enemy3, direction);
            else if(repeatTimes % 10 == 0)
                CreateEnemy(enemy2, direction);
            else
                CreateEnemy(enemy1, direction);


            timeElapsed = 0.0f;
            ++repeatTimes;
        }
	}
}
