using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoilControl : MonoBehaviour
{
    Material waterMat;
    // Start is called before the first frame update
    void Start()
    {
        waterMat = transform.Find("Water").GetComponent<MeshRenderer>().material;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartBoilAnimation()
    {
        StartCoroutine(Boil());
    }

    private IEnumerator Boil()
    {
        yield return null;
        float amount = waterMat.GetFloat("Displacement");
        float t = 0;
        float min = 1;
        while( t <= 5)
        {
            print("amount : " + amount);
            amount += 0.01f;
            
            float newDisplacement = Random.Range(min, amount);
            t += Time.deltaTime;
            waterMat.SetFloat("Displacement", newDisplacement);
            print(waterMat.GetFloat("Displacement"));
            yield return null;
        }

        
    }
}
