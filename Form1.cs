using Agenda.Clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmAgenda : Form
    {
        private string jsonFilePath = "agenda.json"; 
        private List<Persona> contactos;

        public frmAgenda()
        {
            InitializeComponent();

            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.UserAddedRow += dataGridView1_UserAddedRow;
            dataGridView1.UserDeletedRow += dataGridView1_UserDeletedRow;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (!File.Exists(jsonFilePath))
            {
                File.WriteAllText(jsonFilePath,
@"[
  {
    ""Nombre"": """",
    ""Ap paterno"": """",
    ""Ap materno"": """",
    ""Telefono"": """",
    ""Correo"": """",
    ""Dirección"": """"
  }
]");
                contactos = new List<Persona>();
            }
            else
            {
                string json = File.ReadAllText(jsonFilePath);
                contactos = JsonConvert.DeserializeObject<List<Persona>>(json);
                if (contactos == null)
                {
                    contactos = new List<Persona>();
                }
            }

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null; 
            dataGridView1.DataSource = contactos;

            ActualizarDatos();
        }

        private void GuardarDatos()
        {
            string json = JsonConvert.SerializeObject(contactos, Formatting.Indented);
            File.WriteAllText(jsonFilePath, json);
            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            lblEstado.Text = $"Registros: {contactos.Count} | Última actualización: {DateTime.Now}";
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            GuardarDatos();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            GuardarDatos();
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            GuardarDatos();
        }

        
        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            GuardarDatos();
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}