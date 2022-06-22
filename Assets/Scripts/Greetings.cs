using UnityEngine;
//Script agregado a un Quad oculto en la escena para verificar el commit de una rama en Git-Hub.
public class Greetings : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello World!");
        Debug.Log("Automatic Shoot: Activated");
        Debug.Log("Shoot 1 bullet: press Space");
        Debug.Log("Shoot 2 bullets: press J");
        Debug.Log("Shoot 3 bullets: press K");
        Debug.Log("Shoot 4 bullets: press L");
        Debug.Log("You only have 100 HP. For any bullet shooted with Space Key you will lose health, be carefull");
    }
}
