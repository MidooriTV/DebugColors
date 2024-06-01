using UnityEngine;
using DebugColors;
using Debug = DebugColors.DebugX;

public class DebugColorsExample : MonoBehaviour
{
    public int score = 28;
    public int health = 100;
    public ColorData colorData;
    
    private void Start()
    {
        LogWithAllFeatures();
    }

    private void LogWithAllFeatures()
    {
        Debug.Log(@"I:orange:b; love:red:b; 
                        Colorful Logs:rainbow:b;", colorData);
        Debug.Log("sniper:orange:b; bug:green:b;", colorData);
        Debug.Log($"Score = {score}:yellow:b;", colorData);
        Debug.Log($"Health = {health}:green:b;", colorData);
        Debug.Log("Hello world:green;", colorData);
        Debug.Log("Hello:b; World:i;", colorData);
        Debug.Log("love:red:b; love:red:b; love:red:b;", colorData);
        Debug.Log("Hello:yellow:b; world:red:b;", colorData);
        Debug.Log("acid:yellow:b;", colorData);
        Debug.Log("bearflip:yellow:b;", colorData);
        Debug.Log("blubby:yellow:b;", colorData);
        Debug.Log("cry:yellow:b;", colorData);
        Debug.Log("doubletableflip:yellow:b;", colorData);
        Debug.Log("execution:yellow:b;", colorData);
        Debug.Log("fly:yellow:b;", colorData);
        Debug.Log("screwit:yellow:b;", colorData);
    }
}