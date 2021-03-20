using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSequence : MonoBehaviour {

    public GameObject cam1;
    public GameObject cam2;
    public GameObject playerCam;
    public GameObject player;

    public PlayerController playerController;

    // Start is called before the first frame update
    void Start() {
        // StartCoroutine(TheSequence());
    }

    IEnumerator TheSequence() {
        playerController.shouldUpdate = false;
        player.GetComponent<Animator>().SetBool("isDancing", true);

        yield return new WaitForSeconds(7);

        cam2.SetActive(true);
        cam1.SetActive(false);
        yield return new WaitForSeconds(7);
        
        cam2.SetActive(false);
        playerCam.SetActive(true);
        playerController.shouldUpdate = true;
        player.GetComponent<Animator>().SetBool("isDancing", false);
    }

    // Update is called once per frame
    void Update() {
        
    }
}
