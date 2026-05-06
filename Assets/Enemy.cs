using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    public Transform player;
    [SerializeField]private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (player != null)
        {
            agent.SetDestination(player.position);
        }
    }
}
