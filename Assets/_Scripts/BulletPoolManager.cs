using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{
    

    //TODO: create a structure to contain a collection of bullets
    public GameObject objectToPool;
    public int amountToPool;
    public Queue<GameObject> bullets = new Queue<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        // TODO: add a series of bullets to the Bullet Pool
       
        
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(objectToPool);
            obj.transform.parent = GameObject.Find("bullets").transform;
            obj.SetActive(false);
            bullets.Enqueue(obj);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //TODO: modify this function to return a bullet from the Pool
    public GameObject GetBullet()
    {
        GameObject outpool = bullets.Dequeue();
        outpool.SetActive(true);
        return outpool;
    }

    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {
       bullet.SetActive(false);
        bullets.Enqueue(bullet);
    }
}
