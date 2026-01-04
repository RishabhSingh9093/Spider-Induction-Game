using UnityEngine;
public class Shooting : MonoBehaviour
{
    public Camera fpsCamera;
    public float range=100f;
    public GameObject impactEffect;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    void Shoot()
{
    Ray ray=fpsCamera.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;
    if(Physics.Raycast(ray,out hit,range))
    {
        for(int i=0;i<12;i++) 
{
    Vector3 randomOffset=Random.insideUnitSphere*0.08f;
    GameObject dot=Instantiate(impactEffect,hit.point+hit.normal*0.03f+randomOffset,Quaternion.LookRotation(hit.normal));
    float size = Random.Range(0.04f, 0.08f);
    dot.transform.localScale = Vector3.one * size;
    }

    }
}
}
