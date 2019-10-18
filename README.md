# KamaliDebug
Easy way to Debug Colorful Texts in Unity Console

![image](https://user-images.githubusercontent.com/16706911/66844927-0af01480-ef7c-11e9-8202-a2d35878955e.png)


```
    private void Start()
    {
    DebugX.Log(@"I:orange:b; love:red:b; Unity:yellow:b;
    ColorfullllllllllllllllText:rainbow:b;");
    
    DebugX.Log("sniper:orange:b; bug:green:b;");

    }
```

<H3> Numbers:  </H3>


![image](https://user-images.githubusercontent.com/16706911/67084273-808cf800-f1a9-11e9-9a12-a283fc66b957.png)

```
using UnityEngine;
using KamaliDebug;
public class Example : MonoBehaviour
{
    public int score;
    public int health;
    private void Start()
    {
        DebugX.Log($"Score = {score}:yellow:b;");
        DebugX.Log($"Health = {health}:green:b;");
    }
}
```



<H3> Syntax </H3>

```(Text or Emoji):Color:TextStyle;```




<H3> Font Color </H3>

```DebugX.Log("Hello world:green;");```




![image](https://user-images.githubusercontent.com/16706911/66838611-d2e3d400-ef71-11e9-8721-c71773f4cd79.png)

<H3> Font Style </H3>

```DebugX.Log("Hello:b; World:i;");```


    
![image](https://user-images.githubusercontent.com/16706911/66840783-72569600-ef75-11e9-80c7-4d0d3e8ffab2.png)


<H3> Emoji </H3>

```DebugX.Log("love:red:b; love:red:b; love:red:b;");```


![image](https://user-images.githubusercontent.com/16706911/66839173-dd529d80-ef72-11e9-9010-eac6aaf06411.png)




<H3> Complex </H3>

```DebugX.Log("Hello:yellow:b; world:red:b;");```

![image](https://user-images.githubusercontent.com/16706911/66838419-7da7c280-ef71-11e9-83c6-d0dda9d5d75f.png)



___________

ToDo:

1.optimization ( I call a regex per Debug.LogX I should prevent this in build).

2.Add more fontstyles , colors and emojis

3.Make ScriptableObject for Colors

