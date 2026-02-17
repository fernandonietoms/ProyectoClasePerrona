using UnityEngine;

public class Damage_Obs : Obstacle1
{
    protected override void OnCollisionEnter(UnityEngine.Collision collision)
    {
        base.OnCollisionEnter(collision);
        Debug.Log("Dañito");
        //Si el objeto con el que colisiona es un GameObject. Busco componente y si lo tiene valida la condición
        if(collision.gameObject.TryGetComponent(out esto_es_mi_codigo playerController))

        {
            Debug.Log("Is player");
            collision.gameObject.transform.position=new Vector3(0,12,-8);
        }

        
    }
}
