using MiLibreria;
using System;
using System.Data;
using System.Windows.Forms;

namespace MonitorAHK2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarVistas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarVistas();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarVistas()
        {
            // Backlog
            DataSet dataSet = Utilidades.Ejecutar("DECLARE @FechaLocal DATETIME DECLARE @FechaGTM DATETIME DECLARE @FechaInicio DATETIME SET @FechaLocal = (SELECT GETDATE()) SET @FechaGTM = (SELECT DATEADD(hour, 6, @FechaLocal)) SET @FechaInicio = (SELECT CONVERT(char(10), @FechaGTM, 112)) SELECT iLoggerID AS 'LOGGER', SUM(ISNULL(CAST(iCount AS BIGINT), 0)) AS 'PENDIENTES POR ARCHIVAR' FROM nice_storage_center.dbo.vwScBacklog WHERE dtRecordingGMTStartTime BETWEEN @FechaInicio AND @FechaGTM GROUP BY iLoggerID");

            if (dataSet.Tables.Count > 0)
                dataGridBacklog.DataSource = dataSet.Tables[0];
        }
    }
}
