using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpacecraftDeath : MonoBehaviour
{
    ParticleSystem deathExplosion;
    SpacecraftController spacecraftController;
    // Start is called before the first frame update
    void Start()
    {
        deathExplosion = GameObject.Find("death_explosion").GetComponent<ParticleSystem>();
        spacecraftController = GetComponent<SpacecraftController>();
        deathExplosion.Stop();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Wall")
        {
            Die();
        }
    }

    void Die()
    {
        deathExplosion.Play();
        spacecraftController.DisableSpacecraft();
        Destroy(gameObject, 3);
        StartCoroutine(WaitAndLoadScene("DeathMenu", 1.0f));
    }

    IEnumerator WaitAndLoadScene(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}
