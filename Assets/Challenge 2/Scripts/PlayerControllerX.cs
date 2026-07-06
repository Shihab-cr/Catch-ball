using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool dogIsAvailable = true;
    private float dogCooldown = 1f;
    // Update is called once per frame
    private void Start()
    {
        InvokeRepeating("DogIsAvailable", dogCooldown, dogCooldown);
    }
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && dogIsAvailable)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogIsAvailable = false;
        }
    }
    void DogIsAvailable()
    {
        dogIsAvailable = true;
    }
}
