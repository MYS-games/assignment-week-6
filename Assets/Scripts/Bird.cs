using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    [Tooltip("The speed of the bird on release")]
    [SerializeField]
    float speed = 300f;

    public GameObject topBorder;
    public GameObject leftBorder;
    public GameObject rightBorder;

    private bool _birdLanched = false;
    private float _timeSitting;
    private float _limitedTimeSitting = 3f;


    Vector3 _initPosition;
    private void Awake()
    {
        _initPosition = transform.position;
    }

    private void Update()
    {
        if(_birdLanched && (GetComponent<Rigidbody2D>().velocity.magnitude <= 0.1))
        {
            _timeSitting += Time.deltaTime;
        }
        if (transform.position.y > topBorder.transform.position.y ||
            transform.position.x < leftBorder.transform.position.x ||
            transform.position.x > rightBorder.transform.position.x ||
            _timeSitting > _limitedTimeSitting) 
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }

    private void OnMouseUp()
    {
        Vector2 direction = _initPosition - transform.position;
        GetComponent<Rigidbody2D>().AddForce(direction * speed);
        GetComponent<Rigidbody2D>().gravityScale = 1;
        _birdLanched = true;
    }

    private void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
    }
}
