using UnityEngine;
//Script creado para instanciar balas, pero NO para moverlas.
public class ShootingBullet : MonoBehaviour
{
    public GameObject prefabBullet1;
    public GameObject prefabBullet2;
    public GameObject prefabBullet3;
    public Transform bulletSpawn1; //"Cañón" --> "BulletSpawn" como un objeto vacío. 
    public Transform bulletSpawn2;
    public Transform bulletSpawn3;
    void Start()
    {
        //Proyectile();
    }

    void Update()
    {
        ShootBullet();
    }

    /* Método creado para probar el Instantiate y usarlo SOLO en Start
     
     void Proyectile()
    {
        Instantiate(prefabBullet, bulletSpawn.position, transform.rotation);
    }
    
    */
    
    void ShootBullet() //método "Disparo"
    {
       //cada uno de estas condiciones instancian 1 bala que queda crea 1 clon de cada prefab de bala*
        
        if (Input.GetKeyDown(KeyCode.J)) //dispara 1 bala
        {
            Instantiate(prefabBullet1, bulletSpawn1.position, transform.rotation);
        }
        
        if (Input.GetKeyDown(KeyCode.K)) //dispara 2 balas
        {
            Instantiate(prefabBullet1, bulletSpawn1.position, transform.rotation);
            Instantiate(prefabBullet2, bulletSpawn2.position, transform.rotation);
        }
        
        if (Input.GetKeyDown(KeyCode.L)) //dispara 3 balas
        {
            Instantiate(prefabBullet1, bulletSpawn1.position, transform.rotation);
            Instantiate(prefabBullet2, bulletSpawn2.position, transform.rotation);
            Instantiate(prefabBullet3, bulletSpawn3.position, transform.rotation);
        }
    }
}
