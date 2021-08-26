using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour
{
    public void ReactToHit()
    {
        Wandering behavior = GetComponent<Wandering>();
    if(behavior!=null)
    {
        behavior.SetAlive(false);
    }
        StartCoroutine(Die());
    }
    private IEnumerator Die()
    {
        this.transform.Rotate(-75, 0, 0);

        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);
    }
}
