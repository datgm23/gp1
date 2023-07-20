using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

/// <summary>
/// # 改造
/// - 開始と同時に、ルーレットを回転させる
/// - クリックしたら、ルーレットが停止を始める
/// 
/// # おまけ
/// - ルーレットの速度が一定以下になったら停止
/// - 停止してから、クリックしたら、ルーレットの回転再開
/// 
/// # 状態
/// - ルーレット停止
/// - ルーレットが回転中
/// - ルーレット減速中
/// 
/// </summary>
public class RouletteController : MonoBehaviour
{
    enum State
    {
        None=-1,
        Stop,           // 停止
        Rotate,         // 回転中
        Decelerating,   // 減速中
    }

    State currentState = State.None;
    State nextState = State.Stop;

    float rotSpeed = 0;
    static float StartSpeed => 10;
    static float DeceleratingRate => 0.96f;
    static float StopSpeed => 0.01f;

    void Start()
    {
        Application.targetFrameRate = 60;    
    }

    void Update()
    {
        ChangeState();
        UpdateState();
    }

    void ChangeState()
    {
        if (nextState == State.None) return;
        currentState = nextState;
        nextState = State.None;

        switch(currentState)
        {
            case State.Stop:
                rotSpeed = 0;
                break;
            case State.Rotate:
                rotSpeed = StartSpeed;
                break;
        }
    }

    void UpdateState()
    {
        transform.Rotate(0, 0, this.rotSpeed);

        switch (currentState)
        {
            case State.Stop:
                if (Input.GetMouseButtonDown(0))
                {
                    nextState = State.Rotate;
                }
                break;
            case State.Rotate:
                if (Input.GetMouseButtonDown(0))
                {
                    nextState = State.Decelerating;
                }
                break;
            case State.Decelerating:
                this.rotSpeed *= 0.96f;
                break;
        }
    }
}
