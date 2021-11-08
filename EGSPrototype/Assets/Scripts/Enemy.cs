using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public Transform playerTransform;
    public int health;
    public int damage;
    protected Rigidbody2D rb;
    protected bool dead;
    
    public Animator anim;    
 
    public void Start() {
        anim = GetComponent<Animator>();
    }
}
