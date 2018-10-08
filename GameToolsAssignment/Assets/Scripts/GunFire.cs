using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour {
    [SerializeField] private GameObject m_bulletPrefab;
    private Transform m_spawnPoint;
	// Use this for initialization
	void Start () {
        m_spawnPoint = GameObject.FindGameObjectWithTag("Spawn").transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("f"))
            {
            Instantiate(m_bulletPrefab, m_spawnPoint.position, m_spawnPoint.rotation);
        }
	}
}
