using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManagerScript : MonoBehaviour
{
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] float spawnInterval = 2f;
    
    [SerializeField] Transform spawnPointXpos;

    float obstacleSpeed = 5;
    
    void Start()
    {
        StartCoroutine(SpawnObstacleAtIntervals());


        
        
        

    }

    // Update is called once per frame
    void Update()
    {
        //Accelerate game speed over time with time acceleration and max speed

        for (Time.timeScale =  )
        {

        }



        obstacleSpeed += 1;
    }

    private void SpawnObstacle()
    {
        //Instantiate(obstaclePrefab, spawnPointXpos.position, Quaternion.identity);

      GameObject obstacle =  Instantiate(obstaclePrefab, new Vector3(spawnPointXpos.position.x, Random.Range(-10f, -6f), 0), Quaternion.identity);
        obstacle.GetComponent<ObstacleScript>().MoveSpeed =obstacleSpeed;
    }

    // new Vector3(transform.position.y, Random.Range(-4f, 4f), 0),
    IEnumerator SpawnObstacleAtIntervals()
    {
        while (true)
        {
            SpawnObstacle();
            yield return new WaitForSeconds(spawnInterval); 
        }
    }

    


    //instantiate obstacle at random y position at set time intervals with Ienumeator
    //set spawn to right side of screen

}
