using UnityEngine;
//Script con comportamiento de movimiento de balas en una dirección con una velocidad determinada y modificable

public class Bullet : MonoBehaviour
{
    [Range(0,20)]
    public float bulletSpeed = 7f;
    public Vector3 bulletDirection;
    
    //variable pública solo para la entrega del desafío, mostrará el damage pero no hará nada en el script.
    public int bulletDamage = 15;
    void Update()
    {
        transform.position += bulletDirection * bulletSpeed * Time.deltaTime;
        Destroy(gameObject, 2f);
    }
}
