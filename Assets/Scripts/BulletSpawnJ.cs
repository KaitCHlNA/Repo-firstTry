using UnityEngine;
//Disparar 2 balas con la J
public class BulletSpawnJ : MonoBehaviour
{
    public GameObject prefabBulletJ1;
    public GameObject prefabBulletJ2;
    public Transform bSpawnJ1;
    public Transform bSpawnJ2;
  
   void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            SpawnBulletJ();
        }
    }

   void SpawnBulletJ()
   {
       Instantiate(prefabBulletJ1, bSpawnJ1.position, transform.rotation);
       Instantiate(prefabBulletJ2, bSpawnJ2.position, transform.rotation);
   }
}
