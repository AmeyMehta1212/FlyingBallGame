using Unity.VisualScripting;
using UnityEngine;

public class PipeMover : MonoBehaviour

{
    public int moveSpeed;

    private void Start()
    {
        float randomY = Random.Range(-5f, 5f);
        moveSpeed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameManager.Instance.gameOver)
        transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0, 0);

        if (transform.position.x < -25)
        {
            Destroy(gameObject);
        }
    }
              
    }


