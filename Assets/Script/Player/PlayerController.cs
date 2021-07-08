using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public GameObject projectilePrefab;
    public GameObject boundary;

    private BoxCollider2D boxCollider2D;
    
    
    // Start is called before the first frame update
    void Start()
    {
        boxCollider2D = boundary.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        
        transform.Translate(Vector3.right * horizontal);


        if (transform.position.x <= boxCollider2D.bounds.min.x)
            transform.position = new Vector3(boxCollider2D.bounds.min.x, transform.position.y, 0);
        if (transform.position.x >= boxCollider2D.bounds.max.x)
            transform.position = new Vector3(boxCollider2D.bounds.max.x, transform.position.y, 0);
        
        if(Input.GetKeyDown(KeyCode.Space))
            Shoot();
    }

    private void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, this.transform.position, Quaternion.identity);
       // projectile.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 250, ForceMode2D.Impulse);
    }
}
