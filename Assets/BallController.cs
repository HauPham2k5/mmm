using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource _do, _re, _mi, _fa, _son, _la, _si;
    void Start()
    {
        Debug.Log(message: "start");
        _do = GameObject.FindWithTag("Do").GetComponent<AudioSource>();
        _re = GameObject.FindWithTag("Re").GetComponent<AudioSource>();
        _mi = GameObject.FindWithTag("Mi").GetComponent<AudioSource>();
        _fa = GameObject.FindWithTag("Fa").GetComponent<AudioSource>();
        _son = GameObject.FindWithTag("Son").GetComponent<AudioSource>();
        _la = GameObject.FindWithTag("La").GetComponent<AudioSource>();
        _si = GameObject.FindWithTag("Si").GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _do.Play();
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            _re.Play();
        }
        if( Input.GetKeyDown(KeyCode.E))
        {
            _mi.Play();
        }
        if(Input.GetKeyDown (KeyCode.F))
        {
            _fa.Play();
        }
        if(Input.GetKeyDown(KeyCode.V))
        {
            _son.Play();
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            _la.Play();
        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            _si.Play();
        }
    }
}
