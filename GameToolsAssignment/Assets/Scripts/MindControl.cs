using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MindControl : MonoBehaviour {
   private GuardPlayerControl m_guardplayermovescript;
    public GameObject player;
    private PlayerMovement m_playermovescript;
    private bool m_control;
    private bool m_inTrigger;
	// Use this for initialization
	void Start () {
        m_guardplayermovescript = GetComponent<GuardPlayerControl>();
        m_playermovescript = player.GetComponent<PlayerMovement>();
        m_guardplayermovescript.enabled = false;
        m_inTrigger = false;
	}

    private void Update()
    {
       if(m_control)
        {
            m_playermovescript.enabled = false;
            m_guardplayermovescript.enabled = true;
        }
       else if(!m_control)
        {
            m_playermovescript.enabled = true;
            m_guardplayermovescript.enabled = false;
        }
       if(m_inTrigger)
        {
            if(Input.GetKeyDown("m"))
            {
                StartCoroutine(controlling());
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MindControl")
        {
            m_inTrigger = true;
        }
    }
    IEnumerator controlling()
    {
        Debug.Log("MindControl");
        m_control = true;
        yield return new WaitForSeconds(10.0f);
        m_control = false;
    }
    }
