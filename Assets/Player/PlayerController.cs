using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Barboza.Core.Singleton;

public class PlayerController : Singleton<PlayerController>
{
    //Publics
    [Header("Lerp")]
    public Transform target;
    public float lerpSpeed = 1f;

    public float speed = 1f;

    public string tagToCheckEnemy = "Enemy";
    public string tagToCheckEndLine = "EndLine";

    public GameObject endScreen;
    public bool invencible = true;

    //Privates
    private bool _canRun;
    private Vector3 _pos;
    private float _currentSpeed;

    private void Start()
    {
        ResetSpeed();
    }


    void Update()
    {
        if (!_canRun) return;

        _pos = target.position;
        _pos.y = transform.position.y;
        _pos.z = transform.position.z;

        transform.position = Vector3.Lerp(transform.position, _pos, lerpSpeed * Time.deltaTime);
        transform.Translate(transform.forward * _currentSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == tagToCheckEnemy)
        {
            if(!invencible) EndGame();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == tagToCheckEndLine)
        {
            if (!invencible) EndGame();
        }
    }

    private void EndGame()
    {
        _canRun = false;
        endScreen.SetActive(true);
    }


    public void StartToRun()
    {
        _canRun = true;
    }

    #region POWER_UPS
    public void PowerUpSpeedUp(float f)
    {
        _currentSpeed = f;
    }

    public void SetInvencilbe(bool b = true)
    {

        invencible = b;
    }

    public void ResetSpeed()
    {
        _currentSpeed = speed;
    }
    #endregion
}
