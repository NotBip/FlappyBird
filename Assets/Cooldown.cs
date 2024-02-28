using Unity.VisualScripting;
using UnityEngine;


public class Cooldown { 

    private float cooldownTime = .5f;  
    private float _nextFireTime; 

    public bool isCooldown => Time.time < _nextFireTime; 
    public void startCooldown() => _nextFireTime = Time.time + cooldownTime; 

}