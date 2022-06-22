using UnityEngine;
//Script para disparar con espacio e instanciar una bala automáticamente
public class BulletSpawnSpace : MonoBehaviour
{
    public GameObject prefabBulletSpace;
    public Transform bulletSpawnSpace; //"Cañón" --> "BulletSpawn" como un objeto vacío. 
   
    void Start()
    {
        AutomaticShoot(); //para que se instancie una bala automáticamente
    }

    void Update()
    {
        SpawnBulletSpace();
    }
    
     void AutomaticShoot()
    {
        Instantiate(prefabBulletSpace, bulletSpawnSpace.position, transform.rotation);
    }
    
    
    void SpawnBulletSpace() //método "Disparo"
    {

        if (Input.GetKeyDown(KeyCode.Space)) //dispara 1 bala con espacio
        {
            Instantiate(prefabBulletSpace, bulletSpawnSpace.position, transform.rotation);
        }
        
    }
}
