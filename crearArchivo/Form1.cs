using BibliotecaBanco3;

namespace crearArchivo
{
    public partial class Form1 : frmBancoUI
    {
        private StreamWriter archivoWriter;//Escribe datos en el archivo de texto
        private FileStream salida;// mantiene la conexion con el archivo
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //manejador de eventos para el boton guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //crea un cuadro de dialogo que permite al usuario guardar el archivo
            SaveFileDialog selectorArchivo = new SaveFileDialog();
            DialogResult resultado = selectorArchivo.ShowDialog();
            string nombreArchivo;//nombre del archivo en el que se ca a guardar los datos

            selectorArchivo.CheckFileExists=false;//permite al usuario crear archivo

            //sale del manejador
            if(resultado==DialogResult.Cancel)
                return;

            nombreArchivo = selectorArchivo.FileName;

            

        }
    }
}