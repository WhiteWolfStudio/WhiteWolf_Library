using UnityEngine;
using System.IO;

namespace WhiteWolf {

    public class WW_Library : MonoBehaviour {

        public Vector2 MainPlayerPos( string name ){

            GameObject _mp = GameObject.Find( name );
            Vector2 _tp = _mp.transform.position;

            return _tp;

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public float GetDistance( Vector2 _tp_a, Vector2 _tp_b ){ return Vector2.Distance( _tp_a, _tp_b ); }

        public float GetDistance( GameObject _obj_1, GameObject _obj_2 ){

            Vector2 _tp_a = _obj_1.transform.position;
            Vector2 _tp_b = _obj_2.transform.position;

            return Vector2.Distance( _tp_a, _tp_b );

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public void PrintDistance( Vector2 _tp_a, Vector2 _tp_b ) => print( GetDistance( _tp_a, _tp_b ).ToString() );

        public void PrintDistance( GameObject _tp_a, GameObject _tp_b ) => print( GetDistance( _tp_a, _tp_b ).ToString() );

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public void Print( string str_0, float text, string str_1 ) => print( str_0 +  text.ToString() + str_1 );

        public void Print( string str_0, int text, string str_1 ) => print( str_0 +  text.ToString() + str_1 );

        public void Print( string str_0, Vector2 text, string str_1 ) => print( str_0 +  text.ToString() + str_1 );

        public void Print( string str, float text ) => print( str +  text.ToString() );

        public void Print( string str, int text ) => print( str +  text.ToString() );

        public void Print( string str, Vector2 text ) => print( str +  text.ToString() );

        public void Print( float text ) => print( text.ToString() );

        public void Print( int text ) => print( text.ToString() );

        public void Print( Vector2 text ) => print( text.ToString() );

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public Vector2 Rotate( string side ){

            Vector2 _rot = new Vector2( 0, 0 );

            if ( side == "l" ){

                _rot = new Vector2( 0, 180 );

            } else if ( side == "r" ){

                _rot = new Vector2( 0, 0 );

            }

            return _rot;

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public int L( int[] array ){ return array.Length; }
        public int L( float[] array ){ return array.Length; }
        public int L( bool[] array ){ return array.Length; }
        public int L( string[] array ){ return array.Length; }
        public int L( char[] array ){ return array.Length; }
        public int L( Sprite[] array ){ return array.Length; }
        public int L( Vector2[] array ){ return array.Length; }
        public int L( Vector3[] array ){ return array.Length; }
        public int L( GameObject[] array ){ return array.Length; }
        public int L( Transform[] array ){ return array.Length; }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public float RandomN( float min, float max ){ return Random.Range( min, max ); }

        public int RandomN( int min, int max ){ return Random.Range( min, max ); }

        public float RandomN( float min, float max, int l ){

            float n = 0;

            for ( int i=0; i<l; i++ ){ n += Random.Range( min, max ); }

            return n /= l;

        }

        public int RandomN( int min, int max, int l ){

            int n = 0;

            for ( int i=0; i<l; i++ ){ n += Random.Range( min, max ); }

            return n /= l; ;

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public Vector2 NewPoint( GameObject obj, float min, float max ){

            Vector2 point = obj.transform.position;

            float x = RandomN( min, max, 5 );

            point = new Vector2( point.x + x, point.y );

            return point;

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public string GameObjectData( GameObject go ){

            string data = "";

            data += "Name: " + go.name + "\n";
            data += "PosX: " + go.transform.position.x + "\n";
            data += "PosY: " + go.transform.position.y + "\n";
            data += "RotateX: " + go.transform.eulerAngles.x + "\n";
            data += "RotateY: " + go.transform.eulerAngles.y + "\n";

            return data;

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public Vector2 CameraPosition( float x, float y ){

            float _s_w = Screen.width * x;
            float _s_h = Screen.height * y;

            return Camera.main.ScreenToWorldPoint( new Vector3( _s_w, _s_h, 10 ) );

        }

        public Vector3 CameraPosition( float x, float y, float z ){

            float _s_w = Screen.width * x;
            float _s_h = Screen.height * y;

            return Camera.main.ScreenToWorldPoint( new Vector3( _s_w, _s_h, z ) );

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public Vector3 CameraScale( float _sX, float _sY ){

            float _s_go_w = Screen.width * _sX;
            float _s_go_h = Screen.height * _sY;

            return Camera.main.ScreenToWorldPoint( new Vector3( _s_go_w, _s_go_h, 10 ) );

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public int FindLenghtWithTag( string tag ){ return GameObject.FindGameObjectsWithTag( tag ).Length; }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public GameObject[] FindWithTag( string tag ){ return GameObject.FindGameObjectsWithTag( tag ); }

        public GameObject FindWithName( string name ){ return GameObject.Find( name ); }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public void WriteNewLine( string path, string file, string text ){

            StreamWriter w = File.AppendText( path + file );
            w.Write( text );
            w.Close();

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public void NewData( string path, string file ){

            StreamReader sr = new StreamReader( path + file );
            string data = sr.ReadToEnd();
            sr.Close();

            if ( data != "" ) WriteNewLine( path, file, "\n" );

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public string ScriptsName(){ return GetComponent<MonoBehaviour>().GetType().Name; }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public void WriteScriptName( string path, string file, string text ){ WriteNewLine( path, file, $"{System.DateTime.Now.ToString()} | {text + GetComponent<MonoBehaviour>().GetType().Name}\n" ); }

        public void WriteScriptsName( GameObject go, string path, string file, string text ){

            MonoBehaviour[] scripts = go.GetComponents<MonoBehaviour>();
            string line = "";

            foreach ( MonoBehaviour script in scripts ){ line += script.GetType().Name + " "; }

            WriteNewLine( path, file, $"{System.DateTime.Now.ToString()} | {text} {line}\n" );

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public void WriteLog( string path, string file, string text ) {

            if ( ReadFile( path, file ) == null || ReadFile( path, file ) == "" ){

                if ( text != "null" ) { WriteNewLine( path, file, $"{System.DateTime.Now.ToString()} | {Time.time }: {text}\n" ); }

            }
            else {

                if ( text != "null" ) { WriteNewLine( path, file, $"{System.DateTime.Now.ToString()} | {Time.time }: {text}\n" ); }
                else { WriteNewLine( path, file, "\n" ); }

            }

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public string ReadFile( string path, string file ){

            string data; 

            StreamReader reader = new StreamReader( $"{path}/{file}" );
            data = reader.ReadToEnd();
            reader.Close();

            return data;

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public string GenerateID( int n ){

            string data = "";

            for ( int i=0; i<n; i++ ) data += Random.Range( 0, 9 ).ToString();

            return data;

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public bool CheckFile( string path, string file ){

            if ( !File.Exists( $"{path}/{file}" ) ) return false;
            else return true;

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public Vector2 ReturnV2( GameObject obj ){ return new Vector2( obj.transform.position.x, obj.transform.position.y ); }

        public Vector2 ReturnV3( GameObject obj ){ return new Vector3( obj.transform.position.x, obj.transform.position.y, obj.transform.position.z ); }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public void CreateResources(){ if ( !Directory.Exists( "Assets/Resources" ) ){ Directory.CreateDirectory( "Assets/Resources" ); } }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public GameObject[] LoadGOs( string folder ){ return Resources.LoadAll<GameObject>( $"{folder}" ); }
        public GameObject[] LoadGOs( string path, string folder ){ return Resources.LoadAll<GameObject>( $"{path}/{folder}" ); }

        public Sprite[] LoadSprites( string folder ){ return Resources.LoadAll<Sprite>( $"{folder}" ); }
        public Sprite[] LoadSprites( string path, string folder ){ return Resources.LoadAll<Sprite>( $"{path}/{folder}" ); }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public float LoadDataFloat( string name ) {
            if ( PlayerPrefs.HasKey( name ) ) return PlayerPrefs.GetFloat( name );
            return -0.0f;
        }

        public int LoadDataInt( string name ) {
            if ( PlayerPrefs.HasKey( name ) ) return PlayerPrefs.GetInt( name );
            return -0;
        }

        public string LoadDataString( string name ) {
            if ( PlayerPrefs.HasKey( name ) ) return PlayerPrefs.GetString( name );
            return null;
        }
        
        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public void SaveDataFloat( string name, float value ) {
            PlayerPrefs.SetFloat( name, value );
            PlayerPrefs.Save();
        }

        public void SaveDataInt( string name, int value ) {
            PlayerPrefs.SetInt( name, value );
            PlayerPrefs.Save();
        }

        public void SaveDataString( string name, string value ) {
            PlayerPrefs.SetString( name, value );
            PlayerPrefs.Save();
        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public void ResetData(){ PlayerPrefs.DeleteAll(); Debug.Log( "All data deleted!" ); }

    }

}
