using System.Collections.Generic;
using UnityEngine;
using System.Linq;
namespace Domains{
public class PoolingManager : MonoBehaviour
{
    public static List<PooledObjectInfo> Pools = new List<PooledObjectInfo>();
    public static GameObject SpawnObject(GameObject objectPrefab, Vector3 spawnPosition, Quaternion spawnRotation)
    {
        PooledObjectInfo pool = Pools.Find(p => p.LookupString == objectPrefab.name);

        if (pool == null)
        {
            pool = new PooledObjectInfo() { LookupString = objectPrefab.name };
            Pools.Add(pool);
        }
        GameObject possibleObjectToSpawn = pool.InactiveObjects.FirstOrDefault();

        if (possibleObjectToSpawn == null)
        {
            possibleObjectToSpawn = Instantiate(objectPrefab, spawnPosition, spawnRotation);
        }
        else
        {
            possibleObjectToSpawn.transform.position = spawnPosition;
            possibleObjectToSpawn.transform.rotation = spawnRotation;
            pool.InactiveObjects.Remove(possibleObjectToSpawn);
            possibleObjectToSpawn.SetActive(true);
        }

        return possibleObjectToSpawn;
    }
    public static GameObject SpawnObject(GameObject objectPrefab, Transform spawnParent)
    {
        PooledObjectInfo pool = Pools.Find(p => p.LookupString == objectPrefab.name);

        if (pool == null)
        {
            pool = new PooledObjectInfo() { LookupString = objectPrefab.name };
            Pools.Add(pool);
        }
        GameObject possibleObjectToSpawn = pool.InactiveObjects.FirstOrDefault();

        if (possibleObjectToSpawn == null)
        {
            possibleObjectToSpawn = Instantiate(objectPrefab, spawnParent);
        }
        else
        {
            possibleObjectToSpawn.transform.SetParent(spawnParent);
            possibleObjectToSpawn.transform.localPosition = Vector3.zero;
            possibleObjectToSpawn.transform.rotation = Quaternion.identity;
            pool.InactiveObjects.Remove(possibleObjectToSpawn);
            possibleObjectToSpawn.SetActive(true);
        }

        return possibleObjectToSpawn;
    }
    public static void ReturnObjectToPool(GameObject go)
    {
        PooledObjectInfo pool = Pools.Find(p => $"{p.LookupString}(Clone)" == go.name);

        if (pool == null)
        {
            Debug.Log("Tentando voltar pra piscina um objeto que nao pertence a piscina");
        }
        else
        {
            go.SetActive(false);
            pool.InactiveObjects.Add(go);
        }
    }
    public static void ReturnObjectToPool(GameObject go, Transform poolBucket)
    {
        PooledObjectInfo pool = Pools.Find(p => $"{p.LookupString}(Clone)" == go.name);

        if (pool == null)
        {
            Debug.Log("Tentando voltar pra piscina um objeto que nao pertence a piscina");
        }
        else
        {
            if (poolBucket != null)
            {
                go.transform.SetParent(poolBucket);
                go.transform.position = Vector3.zero;
                go.SetActive(false);
                pool.InactiveObjects.Add(go);
            }
        }
    }
}
    public class PooledObjectInfo
    {
        public string LookupString;
        public List<GameObject> InactiveObjects = new List<GameObject>();
    }
}