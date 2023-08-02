using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BulletSpawn : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;

    public Transform bulletSpawn;

    public GameObject bulletPrefab;

    public float everySecond = 0.5f;

    public float bulletSpeed = 1;

    private float _countdownToSpawn = 0;

    private bool _previousPressed = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var pressed = pinchAnimationAction.action.IsPressed();

        if (_previousPressed != pressed)
        {
            _countdownToSpawn = 0;
            _previousPressed = pressed;
        }

        if (!pressed) return;

        if (_countdownToSpawn <= 0)
        {
            // run bullet

            GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();

            bulletRb.AddForce(bulletSpeed * -bulletSpawn.up, ForceMode.Impulse);

            _countdownToSpawn = everySecond;

            Debug.Log("Spawn bullet");
        }

        _countdownToSpawn -= Time.deltaTime;
    }
}
