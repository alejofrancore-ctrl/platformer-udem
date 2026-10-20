using UnityEngine;

public class playermovement : MonoBehaviour
{
    [SerializeField] private float _fuerzasalto=5f;
    [SerializeField] private float _fuerzamover=5f;
    [SerializeField] private Rigidbody2D _cuerporigido;
    [SerializeField] private SpriteRenderer _spriterenderer;
    [SerializeField] private groundcheck _groundcheck;

    private Animator _animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        _cuerporigido =GetComponent<Rigidbody2D>();
        _animator=GetComponent<Animator>();
    }
    // Update is called once per frame
     private void Update()
    {
        if(_groundcheck.estaEnSuelo)
        {
             _animator.SetBool("is jumping",false);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _cuerporigido.AddForce(Vector2.up * _fuerzasalto,ForceMode2D.Impulse );
            _animator.SetBool("is jumping",true);
        }
        else
        {
           
        }
        }

    }

    private void FixedUpdate()
    {
      float Movehorizontal=Input.GetAxisRaw("Horizontal");

      _cuerporigido.linearVelocity= new Vector2(Movehorizontal*_fuerzamover,_cuerporigido.linearVelocity.y);

       if (Movehorizontal !=0)
      {
         _animator.SetBool("isrunning",true);

         if (Movehorizontal>0)
         {
            _spriterenderer.flipX=false;
        
         }
         if (Movehorizontal<0)
         _spriterenderer.flipX=true;
      }

      else
      {
        _animator.SetBool("isrunning",false);
      }

      
    }
}
