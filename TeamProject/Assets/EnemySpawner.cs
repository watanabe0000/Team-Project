using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    [SerializeField]
    private GameObject enemy1;

    private float timeOut;
    private float timeElapsed;
    
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
        obj.transform.position = new Vector2(Random.value * 30 - 15, Random.value * 10 + 30);
        obj.transform.RotateAround(Vector3.zero, new Vector3(0, 0, 1), -degree);
    }

	void Start () {
        timeOut = 2f;
	}
	
	void Update () {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut) {
            Dir direction = (Dir)Random.Range(0, 4);

            CreateEnemy(enemy1, direction);

            timeElapsed = 0.0f;
        }
	}
}
