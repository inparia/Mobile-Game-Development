using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ObjectPool : MonoBehaviour
{
    public Queue<GameObject> m_bulletPool;
    public GameObject bullet;
    public int MaxBullets;

    // Start is called before the first frame update
    private void Start()
    {
        _buildBulletPool();
    }

    public void _buildBulletPool()
    {
        m_bulletPool = new Queue<GameObject>();

        for(int count = 0; count < MaxBullets; count ++)
        {
            var tempBullet = Instantiate(bullet);
            tempBullet.SetActive(false);
            m_bulletPool.Enqueue(tempBullet);
        }    

    }

    public GameObject GetBullet(Vector3 position)
    {
        var newBullet = m_bulletPool.Dequeue();
        newBullet.SetActive(true);
        newBullet.transform.position = position;
        return newBullet;
    }

    public void ReturnBullet(GameObject returnBullet)
    {
        returnBullet.SetActive(false);
        m_bulletPool.Enqueue(returnBullet);
    }
}
