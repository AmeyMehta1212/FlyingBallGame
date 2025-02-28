using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public GameObject pipes;

    public float lowerUpperRange = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnPipes", 1, 3);   
    }

    
   void SpawnPipes()
    {
        if (!GameManager.Instance.gameOver && GameManager.Instance.hasGameStarted)
        {
            Instantiate(pipes, new Vector3(transform.position.x+10, Random.Range(-lowerUpperRange, lowerUpperRange), 0), Quaternion.identity);
        }
    }
}
