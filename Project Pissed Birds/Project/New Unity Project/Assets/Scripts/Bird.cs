using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour
{
    Vector3 _initialPosition;
    private bool _birdWasLaunched;
    private float _timeSittingAround;
    bool isPressed = true;

    public Rigidbody2D rb;

    [SerializeField] private float launchPower = 500;

    private void Awake()
    {
        _initialPosition = transform.position;
    }

    private void Update()
    {
        GetComponent<LineRenderer>().SetPosition(1, _initialPosition);
        GetComponent<LineRenderer>().SetPosition(0, transform.position);

        if (_birdWasLaunched && GetComponent<Rigidbody2D>().velocity.magnitude <= 0.1f)
        {
            _timeSittingAround += Time.deltaTime;
        }

        if (transform.position.y > 10 ||
            transform.position.y < -6 ||
            transform.position.x > 14 ||
            transform.position.x < -21
            || _timeSittingAround > 3)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }

        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene("Main Menu");
        }

        
        if (isPressed)
        {

            if (transform.position.x > -11)
            { string currentSceneName = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene(currentSceneName);
            }

            void OnMouseDown()
            {
                GetComponent<SpriteRenderer>().color = Color.red;
                GetComponent<LineRenderer>().enabled = true;
            }

        }
        
    }
    
   


    private void OnMouseUp()
    {     
       isPressed = false;
       GetComponent<SpriteRenderer>().color = Color.white;
       Vector2 directionToInitialPosition = _initialPosition - transform.position;
       GetComponent < Rigidbody2D>().AddForce(directionToInitialPosition * launchPower);
       GetComponent<Rigidbody2D>().gravityScale = 1;
       _birdWasLaunched = true;
       GetComponent<LineRenderer>().enabled = false;
        
    }

    private void OnMouseDrag()
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPosition.x, newPosition.y+1);
    }

   
}
