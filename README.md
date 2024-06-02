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
![Screenshot_27](https://github.com/MidooriTV/DebugColors/assets/130106855/f82b213b-b68f-45f5-8367-3e7f8c0626cc)
```
        Debug.Log(@"I:orange:b; love:red:b; 
                        Colorful Logs:rainbow:b;", colorData);
        Debug.Log("sniper:orange:b; bug:green:b;", colorData);
```


## Example 2
![Screenshot_28](https://github.com/MidooriTV/DebugColors/assets/130106855/bb35538d-5422-4e89-8817-e164f8b81c7d)
```
        Debug.Log($"Score = {score}:yellow:b;", colorData);
        Debug.Log($"Health = {health}:green:b;", colorData);
```

## Emojis
![Screenshot_31](https://github.com/MidooriTV/DebugColors/assets/130106855/9e44c53c-2c6a-4484-90d5-44a225f38441)
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
