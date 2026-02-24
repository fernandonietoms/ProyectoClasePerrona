using UnityEngine;

public class Damage_Invisible : Obstacle1
{
    protected override void OnCollisionEnter(UnityEngine.Collision collision)
    {
        base.OnCollisionEnter(collision);
        Debug.Log("Sorpresa");

        if(collision.gameObject.TryGetComponent(out esto_es_mi_codigo playerController))

        {
            Debug.Log("Is player");
            collision.gameObject.transform.localScale=new Vector3(0.001f,0.001f,0.001f);
        }
    }

    

    
}
