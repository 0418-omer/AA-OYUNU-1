using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public buyukcember Buyukcemberscript;
  public spawner Spawnerscripts;
  public Animator anim;
  bool isDead;

    // oyun bitirme  işlemi
  public void EndGame()
  {
    Buyukcemberscript.enabled=false;
    Spawnerscripts.enabled=false;
    anim.SetTrigger("die");
    isDead=true;
  }

  
  
}
