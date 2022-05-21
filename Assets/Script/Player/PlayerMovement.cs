using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] // sert à créer une variable pouvant etre utilisé dans Unity
    private float _speed = 1f;

    private Rigidbody _rigidbody; //creation de rigidbody
    private Vector3 _movementInput; //mouvement du perso
    private Vector3 _directionInput;//mouvement visée
    private Transform _transform;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>(); // recherche de rigidbody
        _transform = GetComponent<Transform>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); // cherche quand on appui sur un bouton
        float vertical = Input.GetAxisRaw("Vertical"); // pareil mais pour vertical

        _movementInput = new Vector3(horizontal, 0, vertical);

        if (Input.GetKey(KeyCode.Z) 
            || Input.GetKey(KeyCode.Q) 
            || Input.GetKey(KeyCode.S) 
            || Input.GetKey(KeyCode.D)) // vérification des touches du clavier pour la direction
        {
            _movementInput.Normalize(); // normalise les déplacements via ZQSD
        }

        float rightHorizontal = Input.GetAxisRaw("RightStickX");//cherche joy droit X
        float rightVertical = Input.GetAxisRaw("RightStickY");//cherche joy gauche Y
       

        _directionInput = new Vector3(rightHorizontal, 0f, rightVertical);


        
    }

    private void LateUpdate()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 velocity = _movementInput * _speed; // défini un vecteur pour avancer : la touche où on appuie * la vitesse

        _rigidbody.velocity = velocity;
        /*
        Quaternion lookRotation = Quaternion.LookRotation(_directionInput * Time.deltaTime );

          if(_directionInput != Vector3.zero)
        _rigidbody.MoveRotation(_rigidbody.rotation);
        */
        if (_directionInput.sqrMagnitude > 0)
        {
            
            Quaternion lookRotation = Quaternion.LookRotation(_directionInput);
            // transform.rotation = lookRotation;
            // OU
            _rigidbody.MoveRotation(lookRotation);
        }

    }
    public void TurnTowardsPlayer()
    {
        Vector3 relativePos = _transform.position - transform.position;
        relativePos.y = 0f;

        /*
         * transform.position.Set( transform.position.x, 0f, 0f );
         * transform.position = new Vector3( transform.position.x, 0f, 0f );
        */

        Quaternion PlayerPos = Quaternion.LookRotation(relativePos);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, PlayerPos, _speed);
    }
}
