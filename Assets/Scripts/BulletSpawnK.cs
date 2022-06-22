using UnityEngine;
//Disparar 3 balas con la K
public class BulletSpawnK : MonoBehaviour
{
    public GameObject prefabBulletK1;
    public GameObject prefabBulletK2;
    public GameObject prefabBulletK3;
    public Transform bSpawnK1;
    public Transform bSpawnK2;
    public Transform bSpawnK3;
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            SpawnBulletK();
        }
    }

    void SpawnBulletK()
    {
        Instantiate(prefabBulletK1, bSpawnK1.position, transform.rotation);
        Instantiate(prefabBulletK2, bSpawnK2.position, transform.rotation);
        Instantiate(prefabBulletK3, bSpawnK3.position, transform.rotation);
    }
}
