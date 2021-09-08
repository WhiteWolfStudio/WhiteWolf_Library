# Using

* You must first add scripts to the project
* To work with the database, add

``` csharp
using WhiteWolf;

public class YourClass : WW_Library
```

&nbsp;
# Possibilities

## return [ something ]

&nbsp;
***
&nbsp;

* MainPlayerPos [ __Vector2__ ]

    ``` csharp
    // Distance between objects
    ```
    * ``` string name ```

&nbsp;
***
&nbsp;

* GetDistance [ __Float__ ]

    ``` csharp
    // Distance between objects
    ```

    * ``` ( Vector2 _tp_a, Vector2 _tp_b ) ```
    * ``` ( GameObject _obj_1 GameObject _obj_2 ) ```

&nbsp;
***
&nbsp;

* Rotate [ __Vector2__ ]

    ``` csharp
    // Turn in the right direction
    ```

    * ``` ( string side ) ```
        * __left__
        * __right__

&nbsp;
***
&nbsp;

* L [ __int__ ]

    ``` csharp
    // Returns the amount
    ```

    * ``` ( int[] array ) ```
    * ``` ( float[] array ) ```
    * ``` ( bool[] array ) ```
    * ``` ( string[] array ) ```
    * ``` ( char[] array ) ```
    * ``` ( Sprite[] array ) ```
    * ``` ( Vector2[] array ) ```
    * ``` ( Vector3[] array ) ```
    * ``` ( GameObject[] array ) ```
    * ``` ( Transform[] array ) ```

&nbsp;
***
&nbsp;

* RandomN [ __float__ ] [ __int__ ]

    ``` csharp
    // Classic random number
    ```

    * ``` ( float min, float max ) ```
    * ``` ( int min, int max ) ```

&nbsp;
***
&nbsp;

* NewPoint [ __Vector2__ ]

    ``` csharp
    // New point on coordinate X
    ```

    * ``` ( GameObject obj, float min, float max ) ```

&nbsp;
***
&nbsp;

* GameObjectData [ __string__ ]

    ``` csharp
    // Full info about GameObject

    /* Name /*
    
    /* PosX */
    /* PosY */
    
    /* RotateX */
    /* RotateY */
    ```

    * ``` ( GameObject go ) ```

&nbsp;
***
&nbsp;

* CameraPosition [ __Vector2__ ] [ __Vector3__ ]

    ``` csharp
    // Set Camera position | XY
    ```
    * ``` ( float x, float y ) ```

    &nbsp;
    ``` csharp
    // Set Camera position | XYZ
    ```
    * ``` ( float x, float y, float z ) ```

&nbsp;
***
&nbsp;

* CameraScale [ __Vector3__ ]

    ``` csharp
    // Set Camera Scale | XY
    ```
    * ``` ( float _sX, float _sY ) ```

&nbsp;
***
&nbsp;

* FindLenghtWithTag [ __int__ ]

    ``` csharp
    // Number of objects with a tag
    ```
    * ``` ( string tag ) ```

&nbsp;
***
&nbsp;

* FindWithTag [ __GameObject[]__ ]

    ``` csharp
    // Get objects with a tag
    ```
    * ``` ( string tag ) ```

&nbsp;
***
&nbsp;

* FindWithName [ __GameObject__ ]

    ``` csharp
    // Get object with a name
    ```
    * ``` ( string name ) ```

&nbsp;
***
&nbsp;

* WriteNewLine [ __void__ ]

    ``` csharp
    // Write in file new line
    ```
    * ``` ( string path, string file, string text ) ```

&nbsp;
***
&nbsp;

* ScriptsName [ __string__ ]

    ``` csharp
    // Get scripts name in GameObject
    ```
    * ``` ( null ) ```

&nbsp;
***
&nbsp;

* WriteScriptName [ __void__ ]

    ``` csharp
    // Get script name in GameObject
    // And write it in file
    ```
    * ``` ( string path, string file, string text ) ```

&nbsp;
***
&nbsp;

* WriteScriptsName [ __void__ ]

    ``` csharp
    // Get scripts name in GameObject
    // And write it in file
    ```
    * ``` ( GameObject go, string path, string file, string text ) ```

&nbsp;
***
&nbsp;

* WriteLog [ __void__ ]

    ``` csharp
    // Only for logs
    ```
    * ``` ( string path, string file, string text ) ```

&nbsp;
***
&nbsp;

* ReadFile [ __string__ ]

    ``` csharp
    // For read file
    ```
    * ``` ( string path, string file ) ```

&nbsp;
***
&nbsp;

* GenerateID [ __string__ ]

    ``` csharp
    // Generate ID
    // N = Length id
    ```
    * ``` ( int n ) ```

&nbsp;
***
&nbsp;

* CheckFile [ __bool__ ]

    ``` csharp
    // Checking if a file exists
    ```
    * ``` ( string path, string file ) ```

&nbsp;
***
&nbsp;

* ReturnV2 [ __Vector2__ ]

    ``` csharp
    // Return transform.position in Vector2
    ```
    * ``` ( GameObject obj ) ```

&nbsp;
***
&nbsp;

* ReturnV3 [ __Vector3__ ]

    ``` csharp
    // Return transform.position in Vector3
    ```
    * ``` ( GameObject obj ) ```

&nbsp;
***
&nbsp;

* LoadGOs [ __GameObject[]__ ]

    ``` csharp
    // Loading GameObjects from the "Resource" folder
    ```
    * ``` ( string folder ) ```
    * ``` ( string path, string folder ) ```

&nbsp;
***
&nbsp;

* LoadSprites [ __Sprite[]__ ]

    ``` csharp
    // Loading Sprites from the "Resource" folder
    ```
    * ``` ( string folder ) ```
    * ``` ( string path, string folder ) ```

&nbsp;
***
&nbsp;

* ## <a href="https://github.com/WhiteWolfStudio/WhiteWolf_DataBase" target="_blank">__White Wolf DataBase__ in __White Wolf Library__</a>