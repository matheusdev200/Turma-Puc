using UnityEngine;


public enum EnemyState
{
    None, Idle, Patrolling, Attacking, Death, CastingSpell
}

public class Enemy : MonoBehaviour
{
    public EnemyState currentState;
    public bool canCastSpell = false;
    public GameObject enemyPrefab;
    public GameObject collectablePrefab;

    public bool alive = true;

    void Start()
    {
        currentState = EnemyState.Idle;
    }
    void Update()
    {
        if (currentState == EnemyState.None)
        {
            Debug.LogError("Inimigo não foi inicializado", gameObject);
            return;
        }
        //serve para o Death e para quaisquer outros estados que forem acrescentados
        else if (currentState == EnemyState.Death)
        {
            Death();
            return;
        }
        else if (currentState == EnemyState.Idle)
        {
            Idle();
        }
        else if (currentState == EnemyState.Patrolling)
        {
            Patrolling();
        }
        else if (currentState == EnemyState.Attacking)
        {
            Attacking();
        }
        else if (currentState == EnemyState.CastingSpell && canCastSpell)
        {
            CastingSpell();
        }
        //Debug.Log("Inimigo está vivo", gameObject);
    }

    public void SwitchExample()
    {
        switch (currentState)//stateMachine com switch
        {
            case EnemyState.None:
                Debug.LogError("Inimigo não foi inicializado", gameObject);
                break;
            case EnemyState.Death:
                Death();
                break;
            case EnemyState.Idle:
                //etcs
                break;
            case EnemyState.Patrolling:
                //etcs
                break;
            case EnemyState.Attacking:
                //etcs
                break;
            case EnemyState.CastingSpell:
                //etcs
                break;
        }
    }


    void Idle()
    {
        //Debug.Log("Inimigo está parado.");
    }
    void Patrolling()
    {
        Debug.Log("Inimigo está patrulhando.");
    }
    void Attacking()
    {
        Debug.Log("Inimigo está atacando.");
    }
    void CastingSpell()
    {
        Debug.Log("Inimigo está conjurando uma mandinga.");
    }
    //Enemy Death
    void Death()
    {
        if (alive == true)
        {
            Debug.Log("Inimigo está morto.");

            GetComponentInChildren<SpriteRenderer>().color = Color.black;

            alive = false;

            //criar um coletavel na posicao do inimigo
            GameObject collectable;//variavel local nova
            collectable = Instantiate(collectablePrefab, transform.position, Quaternion.identity);
            //edita collectable conforme a necessidade
            
            //Instantiate(collectablePrefab, transform);
            //coisa.transform.SetParent();//configura o parent do objeto
            Debug.Log(collectable.name);

            Destroy(gameObject, 2f);
        }
    }
}