using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public Transform playerTransform;
    public int health;
    public int maxHealth;
    public int damage;
    protected Rigidbody2D rb;
    protected bool dead;
    public Vector3 firePoint;
    public float movespeed;
    public float minAgroDist;
    public float maxAgoDist;
    public Vector3 upAxis, rightAxis, forwardAxis;
    public Rigidbody body;
    
    public Animator anim;    
 
    public void Start() {
        anim = GetComponent<Animator>();
    }

    void Awake()
    {
        body = GetComponent<Rigidbody>();
        body.useGravity = false;
    }
}
