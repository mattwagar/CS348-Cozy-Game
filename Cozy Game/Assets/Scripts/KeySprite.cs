using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class KeySprite : MonoBehaviour
{
    public KeyCode keyCode;
    
    public ParticleSystem particleEffect;

    public AudioSource audioSource;

    private SpriteRenderer spriteRenderer;

    private bool keyPressed;
    
    private float volumeChangeSpeed = 0.2f;

    private Coroutine audioRoutine;
    
    // Start is called before the first frame update
    void Start()
    {
        if(particleEffect != null)
        {
            audioSource = GetComponent<AudioSource>();
            StartCoroutine(EffectsLoop());
        }
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private IEnumerator EffectsLoop()
    {
        while(true)
        {
            yield return new WaitUntil(() => Input.GetKeyDown(keyCode));
            Debug.Log("KeyPressed");
            particleEffect.Stop();
            particleEffect.Play();
            //spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 1.0f);
            audioSource.volume = 1;
            audioSource.Play();
            yield return new WaitUntil(() => Input.GetKeyUp(keyCode));
            Debug.Log("KeyReleased");
            if(audioRoutine != null)
                StopCoroutine(audioRoutine);
            audioRoutine = StartCoroutine(AudioRoutine());
        }
    }

    private IEnumerator AudioRoutine()
    {
        float currentVolume = 1f;
        while(currentVolume >= 0)
        {
            currentVolume -= Time.deltaTime * volumeChangeSpeed;
            audioSource.volume = currentVolume;
            yield return null;
        }
        audioSource.volume = 0;
        audioSource.Stop();
    }

    // // Update is called once per frame
    // void FixedUpdate()
    // {
    //     if ()
    //     {
    //         // Debug.Log("KeyPressed");
    //         keyPressed = true;
    //     }  
    //     if (Input.GetKeyUp(keyCode))
    //     {
    //         // Debug.Log("KeyReleased");
    //         keyPressed = false;
    //     }
    // }

    public void InitializeKey()
    {
        gameObject.SetActive(true);
    }
}
