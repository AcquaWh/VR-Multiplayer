﻿# Cat Life VR
![MIT License](http://img.shields.io/badge/license-MIT-blue.svg?style=flat)

## Índice

- [Instalación](#instalación)
- [Paquetes instalados](#paquetes-instalados)
- [Introducción](#introducción)
- [Objetivo](#objetivo)
- [Objetivos específicos](#objetivos-específicos)
- [Alcance](#alcance)
- [Dispositivo](#dispositivo)
- [Desarrollo](#desarrollo)
- [Justificación](#justificación)
- [Licencia](#licencia)
- [Conclusión](#conclusión)
- [Licencia](#licencia)
- [Referencias](#referencias)

Cat Life VR es una simulación en realidad virtual que fue creada con Google Cardboard y Daydream en Unity. Este juego tiene un fin educativo para jóvenes de kinder hasta primaria de un rango de edad de 3-11 años donde te enseñara a sumar y restar con frutas. Los niños podrán divertirse mientras están en su salón de clase virtual y aprender al mismo tiempo.

## Instalación

### Versión de Unity

 - Unity 2019.3.0f6 Personal

Clona el repositorio de GitHub en cualquier carpeta dentro de tu computadora

    git clone https://github.com/AcquaWh/Cat-Life-VR.git
    
- Descarga el archivo apk en este [enlace](https://github.com/AcquaWh/Cat-Life-VR/releases/tag/v1.0) para instalarlo en tu celular Android.
- Entra en tu celular a Ajustes > seguridad > orígenes desconocidos y actívala.
- Abre el **APK** que descargaste en tu celular y acepta todos los pasos.
- Estará listo para iniciar el juego.

## Paquetes instalados

- GoogleVR
- Photon 2
- Post Processing
- Lightweight RP

## Introducción
La aplicación de nuevas tecnologías dentro de las escuelas y universidades se esta haciendo más habitual, más ahora por la situación que nuestro mundo esta logrando superar haciendo referencia al COVID19. Ya existen herramientas como Zoom, Skype, Discord entre otras para mantenerte comunicado en el ambito laboral y estudiantil sin estar presencialmente dentro de las instalaciones de tu empresa y universidad.

Cuando estaba en el Kinder hasta la primaria inferior en mi escuela La Salle había un juego educativo que nos ponían en el área de computación que era 2D y tenias que resolver distintos puzzles como resolver una ecuación matemática básica, sumar, restar, multiplicar y dividir. También ese juego nos ponían a leer hasta escribir, este juego lo tenia todo y desde ese entonces fue que me llamaron la atención los videojuegos y su creación. De esa idea fue con la que me inspire para desarrollar mi proyecto.

Con el paso del tiempo, se ha incrementado en las computadoras la velocidad de procesamiento, con mayor capacidad de gráficos y de reproducción de sonido. Esto ha
permitido que muy recientemente la tecnología de realidad virtual pueda utilizarse en el proceso enseñanza-aprendizaje, ya que requiere de cierta velocidad de procesamiento en
una PC, respetable cantidad de memoria y una tarjeta de vídeo con aceleración gráfica.

Google en su presentación anual de Google I/O 2014, presenta una caja de cartón que transforma el celular en unas gafas de realidad virtual, el proyecto Cardboard tiene como
objetivo desarrollar la realidad virtual (VR) herramientas de bajo costo para que todos puedan disfrutar VR de manera sencilla, divertida y natural, es tanto así que uno mismo
puede construir estas gafas, el proceso de construcción de unas CardBoard puede resultar relativamente sencillo y se puede completar en unos 15 o 20 minutos.

El presente trabajo propone presentar el desarrollo de un videojuego educativo en realidad virtual desarrollado con Google Cardboard, que pueda colaborar con la enseñanza en los kindergarden y primarias para que enseñen a los niños a sumar y restar con el fin de motivar a los alumnos a aprender de forma divertida aumentando su interés por la clase de matemáticas con la ayuda de sus compañeros de clase.

## Objetivo
Desarrollar un videojuego en realidad virtual para la clase de Realidad Virtual 2 con Google Cardboard usando el modo multijugador para que al menos entre 2-3 personas se conecten a la sala de juegos en línea.

## Objetivos específicos 
- Desarrollar una sala virtual donde se puedan conectar al menos 2 personas dentro de una red.
- Desarrollar una videojuego con realidad virtual para integrar con Google Cardboard.
- Reforzar conocimiento visto en clase de Realidad Virtual 1.

## Alcance
El presente proyecto se desarrolló con la necesidad de hacer un videojuego en realidad virtual que pudiera conectarse con el método multijugador, es decir que se necesitó al menos un dispositivo móvil con el sistema operativo Android y unas gafas de realidad virtual Cardboard para poder desarrollar este proyecto. El trabajo del presente proyecto fue definido dentro de los siguientes alcances:
- Se tomo en cuenta que estamos en cuarentena por el virus de el COVID19 y no se podrá mantener contacto con el profesor físicamente para hacer pruebas con la aplicación.
- Que la aplicación se conectara por el medio multijugador y que se comunicará entre dos cascos mínimo.
- Resolver sumas básicas para niños de kinder-primaria inferior.
- Que el personaje pudiera caminar y explorar la escena.
- Crear diferentes escenas para el inicio (el menu) con sus instrucciones de jugabilidad, la sala de juego multijugador y las escenas si perdiste o ganaste.
- Mostrar paneles desplegables de textos que muestren los ejercicios que se deben resolver.

## Dispositivo
Google Cardboard son unas gafas de realidad virtual que están hechas con cartón plegable, que funciona al montar un celular con Android o iOS. Son unas gafas con el valor de 400 pesos mexicanos con la resolución de un celular en horizontal. Con estos lentes no necesitas una computadora de gaming ni tampoco una profesional, solo necesitas un celular y con eso basta.

## Desarrollo
### Herramientas necesarias para el desarrollo
Para poder desarrollar y aprender a utilizar este proyecto con Unity necesitamos cumplir al menos los requisitos mínimos que cumplir a nivel de hardware, sobre todo nuestro celular.
- Dispositivo Android con sistema operativo Android 7.0 o mayor.
- Unas gafas cardboard.
- Motor gráfico Unity 3D en su versión (2019.3.0f6).
- Extensiones de Unity3D, GoogleVR.

### Instalaciones
Comprobaremos las versiones de nuestros dispositivos, programas y preparación de todos los entornos para una posterior realización del proyecto de videojuego en realidad virtual.
### Celular
Primero deberemos de comprobar la versión de nuestro dispositivo móvil para ello tenemos que acceder a la siguiente ruta:

Ajustes/ Acerca del dispositivo/ Información del software

![android](https://i.ibb.co/1smzQJJ/ex1.png)

Como se observa en la imagen la versión de nuestro dispositivo Android es la 7.0.

Debido a compatibilidades con las librerías de Google VR nuestro dispositivo debe de tener dicha versión como mínimo para poder hacer uso de las funcionalidades que vernos en la guía. Una vez comprobada la versión de nuestro dispositivo deberemos de instalar desde la PlayStore la aplicación Servicios RV de Google, esta aplicación de Google nos proporciona las herramientas necesarias para poder dar, entre otras, un soporte desde Unity3D a nuestro móvil y poder realizar pruebas en vivo de nuestro desarrollo mediante la conexión con un cable USB desde nuestro dispositivo móvil hasta nuestro PC.

![vr](https://i.ibb.co/J5W1CJB/vr.png)

### Cardboard
Aunque no necesario, para poder obtener una experiencia más auténtica de esta tecnología poseer unas cardboard ayudará a conseguir una inmersión en nuestro proyecto más realista.

### Dispositivo de control bluetooth
Como dispositivo de control utilizaremos otro smartphone que simulara un control de las gafas Daydream de Google.

### Unity3D
Con este motor realizaremos el desarrollo del proyecto y veremos las principales funciones que nos proporciona en conjunto a la realidad virtual. Utilizaremos la versión gratuita Unity3D Personal para nuestro desarrollo. Para poder instalar una versión reciente de Unity3D bastará con acceder a esta dirección oficial donde podremos descargar de forma gratuita una versión de Unity3D actualizada. [Enlace a la página de Unity](https://store.unity.com/es/download?ref=personal)

![img](https://i.ibb.co/xhHxFcF/img2.png)

### Punto a tener en cuenta ante la instalación de Unity, preparación del smartphone y preparación del proyecto de Unity
Tener siempre activados durante la instalación de Unity3D que tengamos activado la opcion de Android Build Support y iOS Build Support para poder seguir sin problemas en el desarrollo.

![img](https://i.ibb.co/1vW12Fs/img2.png)

### Habilitar la depuración de USB en el dispositivo
Para habilitar la depuración del dispositivo tendremos que tener activadas las opciones de desarrollador en el terminal. Para ello deberemos de acceder a la siguiente ruta: 
Ajustes > Acerca del dispositivo > Información del software > Numero de compilación

![img](https://i.ibb.co/swy0J4j/img2.png)

![img](https://i.ibb.co/WDdnHFR/info.png)

Una vez estemos en esta pantalla si presionamos 7 veces seguidas sobre el número de compilación se activará automáticamente las opciones de desarrollador.

![img](https://i.ibb.co/jMjZK96/info.png)
Conecte su dispositivo móvil mediante un cable USB a  su computador. Puede que deba de instalar los controladores adecuados a su dispositivo para que se reconozca en su PC.
En el dispositivo móvil, dentro de las opciones de desarrollador deberemos de buscar y activar la opción de depuración de USB para activar el modo de depuración cuando el dispositivo esté conectado a la computadora.

![img](https://i.ibb.co/vXVpjNF/info.png)

### Configuración de proyecto en Unity
Se empezó un proyecto nuevo en 3D en Unity (versión 2019.3.0f6) en donde se importaron los paquetes de GoogleVR desde este [enlace](https://developers.google.com/vr/develop/unity/get-started-android) en la carpeta de Assets.

![img](https://i.ibb.co/RTyxgwX/img2.png)

### Configuración de opciones de construcción y opciones de jugador
Selecciona File > Build Settings

![img](https://i.ibb.co/LNYHpFW/img2.png)

Selecciona Android y haz click en **Swith Platform,**
En la ventana de Build Settings, haz click en **Player Settings.**
Una vez pulsado **Player Settings** deberemos de modificar algunos aspectos desde el menú de la derecha Inspector indicado en la siguiente tabla:

![img](https://i.ibb.co/9vc6nyt/tabla.png)

Una vez configurados estos parámetros ya tendremos preparado el proyecto con todo lo básico para empezar con nuestro desarrollo.

### Acomodo de Google VR y diseño de UI

Se crearon las escenas, en la que vendrá el menú, la sala multijugador, cuando pierdes y ganas.

![img](https://i.ibb.co/DbCsVFq/scenes.png)

Utilizando la tienda de assets de Unity ([enlace](https://assetstore.unity.com/)) se descargaron los primeros recursos que fueron las frutas en 3D y el gato que se ve en escena.

Desde la escena de **HelloWorld** de GoogleVR, copiar los archivos importantes del Player y sus controladores de la cámara en el **Hierarchy** de la escena **Menú** que se creo con anterioridad.

![img](https://i.ibb.co/XDSJ7KD/scenes.png)

Se creo un escenario en Maya 2019 donde se reutilizara un escenario que ya tenia en la librería y solamente le cambie los cuadros a gatos entre otros ajustes de color a la escena. Cambiando de color el directional light.

![img](https://i.ibb.co/X5ZxmRV/scene.png)

Se descargo un skybox, después se le agrego movimiento en las nubes y en las estrellas para armar una escena perfecta.

![img](https://i.ibb.co/mtpj8Hr/skybox.png)

Después comenzaron se comenzaron a crear los paneles UI con TextMeshPro, se le agregaron distintas funciones para configurar el Photon para que sea multijugador. Dandole click derecho al **Hierarchy** salen diferentes opciones como lo muestra la siguiente imagen.

Click derecho > UI > Panel > Text- TextMesh Pro 

Este canvas será utilizado como nuestro HUD que almacenará aquellas imágenes o textos que utilicemos par nuestro HUD.

![img](https://i.ibb.co/BfTLrc1/ui.png)


![img](https://i.ibb.co/0J5xPhV/ui.png)

Ponemos el canvas junto al sistema de coordenadas de la main camera para  que los paneles se vean en el escenario. Para ello cambiamos dentro de las opciones de canvas a WorldSpace: Canvas -> Render Mode -> World Space

![img](https://i.ibb.co/BfTLrc1/ui.png)

Para insertar las frutas dentro de los botones de la UI del canvas es:
UI > Image
Importamos una imagen en el panel de la derecha que sea un Sprite 2D en Source Image.

![img](https://i.ibb.co/c30RpJd/banana.png)

### Configuración Photon
Se crea un **Empty** en el Hierarchy y en Add Component escribes Connection Photon (Script)

![img](https://i.ibb.co/MG8h6Dv/script.png)

En **Connect Button** se arrastra el botón que creamos de Comenzar y el **Join Random Button** el de unirte a la sala de el Canvas que acabamos de crear.
También ponemos el número máximo de jugadores por cuarto y mínimo.

Dentro del archivo C# va a estar este código:
El MonoBehauviour para hacer llamadas a Photon Pun y también usando la librería Photon.Pum y el TMPro para llamar a los TextMesh botones y textos.

Este archivo se llamará ConnectionPhoton.cs
```c#
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;
    using Photon.Pun;
    using TMPro;
    public class ConnectionPhoton : MonoBehaviourPunCallbacks
    {
        public Button ConnectButton;
        public Button JoinRandomButton;
        public TextMeshProUGUI Log;
        public TextMeshProUGUI PlayerCount;
        public int playersCount;
    
        public byte maxPlayersPerRoom = 4;
        public byte minPlayersPerRoom = 2;
        private bool IsLoading = false;
```

Para hacer la función de conectar a un servidor multijugador se tiene que correr este código que lo que hace es revisar si el usuario esta conectado, si no, en el Texto llamado Log despliega un error o alerta.

El JoinRandom() es para conectarte a una sala multijugador, si no tuviste éxito el **Canvas** te despliega un mensaje de que fallaste en unirte.

El OnJoinnedRoom despliega el mensaje de que todo salio bien al unirte y el OnJoinRandomFailer es que no encontraste una sala para unirte, tu mismo creas tu propia sala.

El FixedUpdate() es para verificar cuantos usuarios hay conectados actualmente en tu sala y muestra en el Canvas un texto con el número de jugadores que van y el máximo.

Cuando es OnConnectedToMaster es que esta actualmente conectándose a un servidor en el proceso.

El LoadMap() es para cargar el nivel con PhotonNetwork según el nombre de la escena que le asignaste y te lleva a la siguiente.

```c#
    public void Connect()
    {
        if (!PhotonNetwork.IsConnected)
        {
            if (PhotonNetwork.ConnectUsingSettings())
            {
                Log.text = "Connected to Server";
            } else
            {
                Log.text = "Failing Connecting to Server";
            }
        }
    }


    public override void OnConnectedToMaster()
    {
        ConnectButton.interactable = false;
        JoinRandomButton.interactable = true;
    }
    public void JoinRandom()
    {
        if (!PhotonNetwork.JoinRandomRoom())
        {
            Log.text = "Fail Joining";
        }
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Log.text = "No Rooms to Join, creating one...";
        if(PhotonNetwork.CreateRoom(null, new Photon.Realtime.RoomOptions() { MaxPlayers = maxPlayersPerRoom }))
        {
            Log.text = "Room Created";
        } else
        {
            Log.text = "Fail Creating Room";
        }
    }
    public override void OnJoinedRoom()
    {
        Log.text = "Joinned";
        JoinRandomButton.interactable = false;
    }
    private void FixedUpdate()
    {
        if(PhotonNetwork.CurrentRoom != null)

            playersCount = PhotonNetwork.CurrentRoom.PlayerCount;
            PlayerCount.text = playersCount + "/" + maxPlayersPerRoom;

        if(IsLoading == false && playersCount >= minPlayersPerRoom)
        {
            LoadMap();
        }
    }
    private void LoadMap()
    {
        IsLoading = true;
        PhotonNetwork.LoadLevel("Game");
    }
```

### Caminar con la cámara
Se necesita un controlador del jugador para que Photon identifique de quien es el que tu estas controlando en el juego con una validación llamada:

```c#
     if (photonView.IsMine)
     {
	     cam.SetActive(true);
     }
```

Este script lo vamos a llamar PlayerController.cs y va en el Prefab del Player en Resources > PhotonPrefabs.

Aquí necesitamos el valor de la velocidad a como se moverá, la cámara y la distancia en la que inclinaremos la cabeza hacia abajo para caminar. También llamamos la animación del gato de caminado.

```c#
    void Update()
        {
            if (!photonView.IsMine) return;
    
            transform.Translate(Vector3.forward * axis.z * moveSpeed * Time.deltaTime);
            transform.Rotate(Vector3.up * axis.x * rotSpeed * Time.deltaTime);
    
            if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
            {
                Vector3 forward2 = vrCamera.TransformDirection(Vector3.forward);
                cc.SimpleMove(forward2 * moveSpeed);
    
                animacion.SetBool("walk", true);
            } else
            {
                animacion.SetBool("walk", false);
            }
            /* 
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
            */
        }

    Vector3 axis { get => new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")); }
```

También podemos movernos con las teclas WASD, y en el Start mandamos a llamar a el Animator para el gato y el character controller.

```c#
    void Start()
    {
        cc = GetComponent<CharacterController>();
        /*
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
        */

        animacion = GetComponentInChildren<Animator>();
        if (photonView.IsMine)
        {
            cam.SetActive(true);
        }
    }
```

### Escena multijugador
Antes de todo se debe hacer un código en esta escena multijugador que haga aparecer al usuario con el player prefabricado, creando al jugador en esa escena. Se hizo un objeto vació y dentro como componente se creo un archivo llamado GameSetupController.cs

```c#
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using System.IO;
    using Photon.Pun;
    
    public class GameSetupController : MonoBehaviour
    {
        [SerializeField]
        Transform camtransform;
        void Start()
        {
            createPlayer();
        }
    
        void createPlayer()
        {
            PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "Player"), Vector3.zero, Quaternion.identity);
        }
    }
```

Los usuarios van juntando entre todos frutas para pasar más sencillo el nivel y a los 3 fallos les manda a la escena de perder.

Para lograr esto se necesita tener un archivo de codigo por fuera que recolecte puntos, y los puntos en contra también para imprimirlos en un TextMeshPro en el Canvas.

El timescale es para pausar la partida cuando pierdas y ganes, eso evita que te muevas durante.
Recuerda siempre importan las librerías de Photon.Pun cuando quieras usar una función de Photon y llamar a MonoBehaviourPunCallbacks.

Esta es la primera vez en este proyecto que añadimos un SceneManagement, así que antes de salirnos de cualquier partida debemos dejar la sala multijugador con LeaveRoom(), el nombre de la escena a la que te quieres tele transportar debe tener el mismo nombre que en **Build > Scenes in Build**

Este archivo se llamará ScoreScript.cs

```c#
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;
    using TMPro;
    using Photon.Pun;
    using UnityEngine.SceneManagement;
    public class ScoreScript : MonoBehaviourPunCallbacks
    {
    public static int scoreValue = 0;
    public static int errorValue = 0;
    TextMeshProUGUI score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreValue != 240)
        {
            score.text = "Errores: " + errorValue + "  Puntos: " + scoreValue;
        } else
        {
            Time.timeScale = 0;
            Debug.Log("Has ganado");
            PhotonNetwork.LeaveRoom();
            SceneManager.LoadScene("Won");

        }
        if(errorValue == 3)
        {
            Time.timeScale = 0;
            Debug.Log("Has perdido");
            PhotonNetwork.LeaveRoom();
            SceneManager.LoadScene("Lost");

        }
        
    }
}
```

Después a las frutas y comida se le pone un trigger que cuando entre el jugador que tenga el tag **Player**, se activará el cuestionario y un audioclip de golpe que dirá "Meow" como un gato, agregando 10 puntos por fruta y por cuestionario resuelto 50.

El AudioSource lo podemos agregar en un objeto vació en el **Hierarchy** como cuando agregamos la música de fondo de los niveles y teniendo la música .mp3 en la carpeta Assets, arrastrándolo a las opciones que habilitamos dentro de la fruta y arrastramos el Empty que es el que tiene el AudioSource.

El archivo se llamara FrutaScript.cs

![img](https://i.ibb.co/D9Tnx4v/bananascript.png)

```c#
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    
    public class BananaScript : MonoBehaviour
    {
        public GameObject Panel;
        public AudioClip meow;
        public AudioSource audioSource;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag.Equals("Player"))
            {
                if(Panel != null)
                {
                    bool isActive = Panel.activeSelf;
                    Panel.SetActive(true);
                    audioSource.PlayOneShot(meow, 0.7F);
                    ScoreScript.scoreValue += 10;
                    Destroy(gameObject);
                }
            }
        }
    }
```

Para terminar el juego, solo se le asigno en la escena final un script llamado End.cs:

```c#
    Application.Quit();
```

## Justificación
El proyecto se justifica por ser una herramienta de aprendizaje para niños que necesiten aprender matemáticas beneficiándose de escenarios virtuales para nada aburridos.
Desde el punto de vista tecnológico, se empleó herramientas actuales para el desarrollo, como ser Unity 3d como procesador de gráficos en 3D y la aplicación será desarrollada para la plataforma Android. 

SDK Android para Unity nos permitió integrar Android con el gestor Unity 3D. Se utiliza además del visor CardBoard el cual fue lanzado por Google el 2014, como una herramienta
a bajo costo para lograr una realidad virtual en la aplicación.

## Conclusión
Después de tener varias semanas trabajando en el proyecto de Cat Life VR, pude reforzar los conocimientos previos que ya había aprendido en clase de Realidad Virtual 2 y obligarme a investigar más técnicas de otras formas para conectarte en línea por medio de Photon 2.

- El objetivo general fue cumplido ya que se realizo el juego con exito en realidad virtual con Google Cardboard usando la tecnología Photon Pun 2 para crear un servidor virtual para que los usuarios puedan jugar al mismo tiempo en una misma red.
- El sistema de multijugador puede llegar a ser complicado de implementar en proyectos de poco tiempo para desarrollar, así que tengo planeado investigar aun más sobre el tema de realidad virtual en multijugador.
- El costo de las gafas de realidad virtual Google Cardboard es absurdamente barato a diferencia de otros dispositivos como el Oculus rift entre otros, así que no tuve que gastar.
- Se logro trabajar con distintos recursos que tienen licencia gratis de uso, yo lo tuve que implementar en el proyecto y modificar varios materiales.

## Referencias
Yoo, S., & Parker, C. (2015, August). Controller-less interaction methods for Google cardboard. In Proceedings of the 3rd ACM Symposium on Spatial User Interaction (pp. 127-127).

MacIsaac, D. (Ed.). (2015). Google Cardboard: A virtual reality headset for $10?. The Physics Teacher, 53(2), 125-125.

Etxeberría, F. (2001). Videojuegos y educación.

Vera-Muñoz, M. I., & Espinosa Brilla, D. (2001). Efectos de los videojuegos y de la realidad virtual en los valores.

Keene, S. (2018). Google Daydream VR Cookbook: Building Games and Apps with Google Daydream and Unity. Addison-Wesley Professional.

LaValle, S. M., Yershova, A., Katsev, M., & Antonov, M. (2014, May). Head tracking for the Oculus Rift. In 2014 IEEE International Conference on Robotics and Automation (ICRA) (pp. 187-194). IEEE.

Psotka, J. (1995). Immersive training systems: Virtual reality and education and training. Instructional science, 23(5-6), 405-431.

Egger, J., Gall, M., Wallner, J., Boechat, P., Hann, A., Li, X., ... & Schmalstieg, D. (2017). HTC Vive MeVisLab integration via OpenVR for medical applications. PloS one, 12(3), e0173972.

## Licencia
Entra a este [enlace](https://github.com/AcquaWh/VR-Multiplayer/blob/master/LICENSE) para ver la licencia del proyecto.


