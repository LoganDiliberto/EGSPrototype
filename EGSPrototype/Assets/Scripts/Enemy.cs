using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public Transform playerTransform;
    public int currentHealth;
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
    
    public void receiveDamage(int damage){
     
        currentHealth -= damage;
        //Debug.Log("Damage Applied");
    }
    
    public void death(){        
 
        Destroy(this.gameObject);        
     
    }

    public void checkStatus()
    {
        if(currentHealth > maxHealth)
            currentHealth = maxHealth;
     
        if(currentHealth < 0)
            currentHealth = 0;
     
        if(currentHealth == 0)
            death();
    }
}
