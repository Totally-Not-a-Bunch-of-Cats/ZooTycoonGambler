using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    [SerializeField] GameObject exhibitBase;

    [SerializeField] SpriteRenderer sprite;

    [SerializeField] int mapHeight = 50;

    [SerializeField] int mapWidth = 50;

    void Start()
    {
        sprite.size = new(mapWidth,mapHeight);
    }

}
