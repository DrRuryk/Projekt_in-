using UnityEngine;
using System.Collections.Generic; 

public class TileGenerator : MonoBehaviour
{
    public GameObject Grass;
    public GameObject Forest;
    public GameObject Stone;
    public GameObject Wheat;
    
    public int ForestAmount = 5;
    public int StoneAmount = 5;
    public int WheatAmount = 5;
    public int rows = 5;  
    public int cols = 5;  
    public float spacing = 1.1f; 
    public float xOffset = 0f;
    public float yOffset = 0f;
    
    private List<GameObject> generatedTiles = new List<GameObject>();
    private List<Vector3> positions = new List<Vector3>();
    private pola = rows * cols;
    void Start()
    {
        GenerateTiles();
        
    }

    void GenerateTiles()
    {
        //grass
        
        //forest
        int rngfor = Random.Range(ForestAmount, pola);
        //stone
        int rngsto = Random.Range(StoneAmount, pola);
        //wheat 
        int rngwheat = Random.Range(WheatAmount, pola);
        
    }
       
    
    
    
    
}

//Kod śmieciowy
/* int stoneCount = 0 , forestCount = 0, wheatCount = 0, GrassCount = 0;
        for (float x = xOffset; x < cols; x++)
        {
            for (float y = yOffset; y < rows; y++) 
            {
                Vector3 position = new Vector3(x * spacing, y * spacing, 0);
                int rng = Random.Range(1, 101);
                GameObject tile = null;
                switch (rng)
                    {
                    case int n when(n==1 && n<=60):
                       tile = Instantiate(Grass, position, Quaternion.identity, transform);
                       GrassCount++;
                        break;
                    case int n when(n>60 && n<=80):
                        tile = Instantiate(Forest, position, Quaternion.identity, transform);
                        forestCount++;
                        break;
                    case int n when(n>80 && n<=90):
                        tile = Instantiate(Stone, position, Quaternion.identity, transform);
                        stoneCount++;
                        break;
                    default:
                        tile = Instantiate(Wheat, position, Quaternion.identity, transform);
                        wheatCount++; 
                        break;
                    }
                generatedTiles.Add(tile);
            }
        }
        EnsureMinimumTiles(ref stoneCount, 2, Stone, generatedTiles, positions);
        EnsureMinimumTiles(ref forestCount, 2, Forest, generatedTiles, positions);
        EnsureMinimumTiles(ref wheatCount, 2, Wheat, generatedTiles, positions);
    }
    void EnsureMinimumTiles(ref int count, int minRequired, GameObject tilePrefab, List<GameObject> generatedTiles, List<Vector3> positions)
    {
        while (count < minRequired)
        {
            int replaceIndex = Random.Range(0, generatedTiles.Count);
            Destroy(generatedTiles[replaceIndex]); 
            generatedTiles[replaceIndex] = Instantiate(tilePrefab, positions[replaceIndex], Quaternion.identity, transform);
            count++;
        }
    }*/
