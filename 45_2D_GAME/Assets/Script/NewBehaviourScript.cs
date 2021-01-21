using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Header("角色移動速度"), Range(0, 20)]
    public float speed;
    [Header("角色移動加速度"), Range(0, 10)]
    public float Addspeed;
    [Header("角色攻擊力"), Range(0, 15)]
    public float attack;
    [Header("角色血量"), Range(0, 100)]
    public float life;
    [Header("角色生命數"), Range(0, 3)]
    public float Lift;
    [Header("敵人移動速度"), Range(0, 8)]
    public float enspeed;
    [Header("敵人移動速度"), Range(0, 20)]
    public float enattack;
    [Header("敵人血量"), Range(0, 20)]
    public float enlift;
}
