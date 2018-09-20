using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using consumo.AccesoDatos;

namespace consumo
{
    public partial class consumo : Form
    {
        public consumo()
        {
            InitializeComponent();
        }

  

        public void button1_Click(object sender, EventArgs e)
        {
           // VARIABLES//
            DateTime fecha = dateTimePicker1.Value;
            int cod_bod = int.Parse(cod_bodega1.Text);
            string cod_art = (texcod1.Text);
            decimal consumo = decimal.Parse(texconsu1.Text);
            decimal entrada = decimal.Parse(texentrada1.Text);
            decimal Sobro = decimal.Parse(texsobro1.Text);
            int can_cerdo = int.Parse(textcerd1.Text);
            string Nota = textnot1.Text;
            // Formulas solo para mostrar //
            decimal consuXcerdo = (consumo * 46) / can_cerdo;
            decimal Sobro_anterior = + entrada - consumo;
            Sobro = Sobro_anterior;
            // LIMPIAR CAMPOS TEXBOX//
            texcod1.Text = "";
            cod_bodega1.Text = "";
            texconsu1.Text = "";
            texentrada1.Text = "";
            texsobro1.Text = "";
            textcerd1.Text = "";
            textnot1.Text = "";

            using (AccesoDatos.CERDOSEntities c = new AccesoDatos.CERDOSEntities())
            {
                foreach (var item in new List<int>(){1,2,34,5})
                {
                    c.BODEGAS.Add(new AccesoDatos.BODEGAS()
                    {
                        Codigo_Bodega = item.ToString(),
                        Descripcion = "esta semana se paga magtricula",
                        Ubicacion = "voy a cobrar mas"

                    });
                }
                c.SaveChanges();


                List<BODEGAS> bodegas = c.BODEGAS.SqlQuery(Where(x=> x.Codigo_Bodega);
            }


            // USAR FUNCION DE INSERT //
/// save(fecha, cod_bod, cod_art, consumo, entrada, Sobro, can_cerdo, Nota, consuXcerdo,Sobro_anterior);

            MessageBox.Show("SE GUARDO CON EXITO");

        }

        public int save(DateTime fecha, int cod_bod, string cod_art, decimal consumo, decimal entrada, decimal Sobro, int can_cerdo, string Nota, decimal consuXcerdo,decimal sobro_anterior)

        {   // CONEXION A LA BD //
            var instancia = @"\SQLGME;";
            var localString = "Data Source=DESKTOP-GI1IHLH";
            localString += instancia;
            localString += "Initial Catalog=CERDOS;user id=dbo; password=dbo;";
            //ConectionServer2 conection = new ConectionServer2();
            int result = 0;

            try
            {
                // INSERT //
                string saveStaff = "INSERT into consumo (Fecha,cod_bodega,cod_articulo,Consumo,Entrada,Sobro,can_cerdo,nota,consuXcerdo,sobro_anterior) VALUES (@Fecha,@Cod_bodega,@Cod_articulo,@Consumo,@Entrada,@Sobro,@can_cerdo,@nota,@consuXcerdo,@sobro_anterior)";
                using (SqlConnection openCon = new SqlConnection(localString))
                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Fecha", SqlDbType.DateTime, 30).Value = fecha;
                    querySaveStaff.Parameters.Add("@Cod_bodega", SqlDbType.VarChar, 30).Value = cod_bod;
                    querySaveStaff.Parameters.Add("@Cod_articulo", SqlDbType.Text, 30).Value = cod_art;
                    querySaveStaff.Parameters.Add("@Consumo", SqlDbType.Decimal, 30).Value = consumo;
                    querySaveStaff.Parameters.Add("@Entrada", SqlDbType.Decimal, 30).Value = entrada;
                    querySaveStaff.Parameters.Add("@Sobro", SqlDbType.Decimal, 30).Value = Sobro;
                    querySaveStaff.Parameters.Add("@can_cerdo", SqlDbType.Int, 30).Value = can_cerdo;
                    querySaveStaff.Parameters.Add("@nota", SqlDbType.Text, 30).Value = Nota;
                    querySaveStaff.Parameters.Add("@consuXcerdo", SqlDbType.Decimal, 30).Value = consuXcerdo;
                    querySaveStaff.Parameters.Add("@consuXcerdo", SqlDbType.Decimal, 30).Value = sobro_anterior;

                    openCon.Open();
                    result = querySaveStaff.ExecuteNonQuery();
                }

            }
            // CAPTURADOR DE ERRORES //
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
                Console.WriteLine(ex.Message);

            }


            return result;
            {

            }

        }
        // BOTON SALIR //
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        // RELLENAR CON 0 A LA IZQUIERDA //
        private void texconsu1_TextChanged(object sender, EventArgs e)
        {
            this.texcod1.Text = this.texcod1.Text.PadLeft(6, '0');
        }

        private void boxubica_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    


