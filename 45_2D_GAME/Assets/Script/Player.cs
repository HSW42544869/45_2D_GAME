using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("移動速度"), Range(0.1f,1)]
    public float speed = 0.1f;
    [Header("是否在地板上"), Tooltip("用來儲存玩家是否站在地板上")]
    public bool isGround = false;


    [Header("法術"), Tooltip("存放要生成的法術預置物")]
    public GameObject Spells;
    [Header("法術生成點"), Tooltip("法術生成的起始位置")]
    public Transform point;
    [Header("法術速度"), Range(0, 500)]
    public int Speedspelles = 500;
    [Header("施法音效")]
    public AudioClip soundFire;
    [Header("生命數量"), Range(0, 10)]
    public int live = 3;

    private int score;
    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;

    void Update()
    {
        Move();
    }
    private void Awake()
    {
        //剛體 = 取得元件<剛體元件>();
        //抓到角色身上的剛體元件存放到 rig 欄位內
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    private void Start()
    {
        
    }

    /// <summary>
    /// 移動功能
    /// </summary>
    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(h * speed, rig.velocity.y);
       
    }

    /// <summary>
    /// 施法功能
    /// </summary>
    private void Fire()
    {
        
    }

    /// <summary>
    /// 死亡功能
    /// </summary>
    /// <param name="obj"></param>
    private void Dead(string obj)
    { 
    
    }
    
}
