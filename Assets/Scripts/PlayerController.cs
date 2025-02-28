using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.5f;
           
    public Rigidbody2D rb;

      
    //int counter = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (!GameManager.Instance.gameOver && GameManager.Instance.hasGameStarted)
            {
                rb.linearVelocity = new Vector3(0, speed, 0);
                //GetComponent<PipeMover>().enabled = true;
            }
        }
        //transform.Translate(speed*Time.deltaTime, 0, 0);
    }
    
   

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.Instance.Score();              
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(!GameManager.Instance.gameOver)
        {
            GameManager.Instance.GameOver();
        }
        
        if (collision.gameObject.CompareTag("pipe"))
        {
           Debug.Log("Pipe se takraya");
            speed = 0;

        }
        
    }
}
