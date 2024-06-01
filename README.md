# DebugColors
Easy way to Debug Colorful Texts in Unity Console

### Important Note
To properly use this code make sure to create the scriptable object and attach it to an object in your hierarchy.

To override Debug.Log use the following:
```
using DebugColors;
using Debug = DebugColors.DebugX;
```
Using only DebugColors use the following
```
DebugX.Log
```
View the DebugColorsExample code for more information

## Example 1
![Screenshot_27](https://github.com/MidooriTV/ColorfulLogs/assets/130106855/677cfc4e-f906-4d50-acb4-9d4afcf7e6b5)
```
        Debug.Log(@"I:orange:b; love:red:b; 
                        Colorful Logs:rainbow:b;", colorData);
        Debug.Log("sniper:orange:b; bug:green:b;", colorData);
```

## Example 2
![Screenshot_28](https://github.com/MidooriTV/ColorfulLogs/assets/130106855/c228467a-a058-450f-9c6f-7ae64818094d)
```
        Debug.Log($"Score = {score}:yellow:b;", colorData);
        Debug.Log($"Health = {health}:green:b;", colorData);
```

## Emojis
![Screenshot_31](https://github.com/MidooriTV/ColorfulLogs/assets/130106855/f5088701-3cc0-4c6a-9425-db5088037223)
```
        Debug.Log("Hello:yellow:b; world:red:b;", colorData);
        Debug.Log("acid:yellow:b;", colorData);
        Debug.Log("bearflip:yellow:b;", colorData);
        Debug.Log("blubby:yellow:b;", colorData);
        Debug.Log("cry:yellow:b;", colorData);
        Debug.Log("doubletableflip:yellow:b;", colorData);
        Debug.Log("execution:yellow:b;", colorData);
        Debug.Log("fly:yellow:b;", colorData);
        Debug.Log("screwit:yellow:b;", colorData);
```

## Syntax
```
(Text or Emoji):Color:FontStyle;
```

## Font Style
+ b = Bold
+ i = Italic

### To Do
- [x] Removed Regex
- [x] ScriptableObject for Colors
- [ ] Add more font styles
