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

namespace consumo
{
    public partial class consumo : Form
    {
        public consumo()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.CONSUMO' Puede moverla o quitarla según sea necesario.
        }

        public void button1_Click(object sender, EventArgs e)
        {
           
            DateTime fecha = dateTimePicker1.Value;
            int cod_bod = int.Parse(cod_bodega.Text);
            string cod_art = texcod1.Text;
            decimal consumo = decimal.Parse(texconsu1.Text);
            decimal entrada = decimal.Parse(texentrada1.Text);
            decimal Sobro = decimal.Parse(texsobro1.Text);
            int can_cerdo = int.Parse(textcerd1.Text);
            string Nota = textnot1.Text;
            decimal consuXcerdo = (consumo * 46) / can_cerdo;

            texcod1.Text = "";
            cod_bodega.Text = "";
            texconsu1.Text = "";
            texentrada1.Text = "";
            texsobro1.Text = "";
            textcerd1.Text = "";
            textnot1.Text = "";
            save(fecha, cod_bod, cod_art, consumo, entrada, Sobro, can_cerdo, Nota, consuXcerdo);
            // segundas variables
            string cod_art2 = texcod2.Text;
            decimal consumo2 = decimal.Parse(texconsu2.Text);
            decimal entrada2 = decimal.Parse(texentrada2.Text);
            decimal Sobro2 = decimal.Parse(texsobro2.Text);
            int can_cerdo2 = int.Parse(textcerd2.Text);
            string Nota2 = textnot2.Text;
            decimal consuXcerdo2 = (consumo * 46) / can_cerdo;
            texcod2.Text = "";
            cod_bodega.Text = "";
            texconsu2.Text = "";
            texentrada2.Text = "";
            texsobro2.Text = "";
            textcerd2.Text = "";
            textnot2.Text = "";
            save2(fecha, cod_bod, cod_art2, consumo2, entrada2, Sobro2, can_cerdo2, Nota2, consuXcerdo2);

            MessageBox.Show("SE GUARDO CON EXITO");

        }

        public int save(DateTime fecha, int cod_bod, string cod_art, decimal consumo, decimal entrada, decimal Sobro, int can_cerdo, string Nota, decimal consuXcerdo)

        {
            var instancia = @"\SQLGME;";
            var localString = "Data Source=192.168.1.155";
            localString += instancia;
            localString += "Initial Catalog=CERDOS;user id=dbo; password=dbo;";
            //ConectionServer2 conection = new ConectionServer2();
            int result = 0;

            try
            {

                string saveStaff = "INSERT into consumo (Fecha,cod_bodega,cod_articulo,Consumo,Entrada,Sobro,can_cerdo,nota,consuXcerdo) VALUES (@Fecha,@Cod_bodega,@Cod_articulo,@Consumo,@Entrada,@Sobro,@can_cerdo,@nota,@consuXcerdo)";
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
                    openCon.Open();
                    result = querySaveStaff.ExecuteNonQuery();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
                Console.WriteLine(ex.Message);

            }
        }
        /// insert 2 
        public int save2(DateTime fecha, int cod_bod, string cod_art2, decimal consumo2, decimal entrada2, decimal Sobro2, int can_cerdo2, string Nota2, decimal consuXcerdo2)

        {
            var instancia = @"\SQLGME;";
            var localString = "Data Source=192.168.1.155";
            localString += instancia;
            localString += "Initial Catalog=CERDOS;user id=dbo; password=dbo;";
            //ConectionServer2 conection = new ConectionServer2();
            int result = 0;
            try
            {

                string saveStaff = "INSERT into consumo (Fecha,cod_bodega,cod_articulo,Consumo,Entrada,Sobro,can_cerdo,nota,consuXcerdo) VALUES (@Fecha,@Cod_bodega,@Cod_articulo,@Consumo,@Entrada,@Sobro,@can_cerdo,@nota,@consuXcerdo)";
                using (SqlConnection openCon = new SqlConnection(localString))
                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;
                    querySaveStaff.Parameters.Add("@Fecha", SqlDbType.DateTime, 30).Value = fecha;
                    querySaveStaff.Parameters.Add("@Cod_bodega", SqlDbType.VarChar, 30).Value = cod_bod;
                    querySaveStaff.Parameters.Add("@Cod_articulo", SqlDbType.Text, 30).Value = cod_art2;
                    querySaveStaff.Parameters.Add("@Consumo", SqlDbType.Decimal, 30).Value = consumo2;
                    querySaveStaff.Parameters.Add("@Entrada", SqlDbType.Decimal, 30).Value = entrada2;
                    querySaveStaff.Parameters.Add("@Sobro", SqlDbType.Decimal, 30).Value = Sobro2;
                    querySaveStaff.Parameters.Add("@can_cerdo", SqlDbType.Int, 30).Value = can_cerdo2;
                    querySaveStaff.Parameters.Add("@nota", SqlDbType.Text, 30).Value = Nota2;
                    querySaveStaff.Parameters.Add("@consuXcerdo", SqlDbType.Decimal, 30).Value = consuXcerdo2;
                    openCon.Open();
                    result = querySaveStaff.ExecuteNonQuery();
                }
            }


            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
                Console.WriteLine(ex.Message);

            }

            return result;
            {

            }


        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


