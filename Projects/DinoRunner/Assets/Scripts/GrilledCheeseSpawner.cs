using UnityEngine;
using System.Collections;

public class GrilledCheeseSpawner : MonoBehaviour
{

    private float secondsUntilNextGrilledCheese;
    public float maxSecondsUntilNextGrilledCheese;
    public float minSecondsUntilNextGrilledCheese;
    public GameObject grilledCheesePrefab;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnGrilledCheese());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnGrilledCheese()
    {
        //what height?
        float y = Random.Range(-2.94f, 1.25f);
        Vector3 grilledCheesePosition = new Vector3(10, y, 0);
        
        //create the grilled cheese
        GameObject currentGrilledCheese = Instantiate(grilledCheesePrefab, grilledCheesePosition, transform.rotation);
        
        secondsUntilNextGrilledCheese = Random.Range(maxSecondsUntilNextGrilledCheese,minSecondsUntilNextGrilledCheese);
        yield return new WaitForSeconds(secondsUntilNextGrilledCheese);
        StartCoroutine(SpawnGrilledCheese());
    }
}
