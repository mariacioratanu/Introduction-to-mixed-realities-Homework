using UnityEngine;

public class BallHitEffect : MonoBehaviour //pt efectul vizual la lovirea mingii
{
    public ParticleSystem hitEffect;

    void OnCollisionEnter(Collision collision)
    {
        //verif daca mingea a fost lovita de crosa
        if (collision.gameObject.CompareTag("GolfClub"))
            hitEffect.Play(); 
    }
}