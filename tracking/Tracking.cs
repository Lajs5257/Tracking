using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tracking.Entities;
using tracking.Helpers;

namespace tracking
{
    public partial class Tracking : Form
    {/*
         public long? supply_chain_id { get; set; }
        public long? id { get; set; }
        public string? plante { get; set; }
        public string? shipment { get; set; }
        public string? transline_name { get; set; }
        public int? transline_id { get; set; }
        public int? legacy_code { get; set; }
        public string? timezone { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }
        public int? speed { get; set; }
        public int? distance_to_route { get; set; }
        public int? distance_to_end_route { get; set; }
        public string? odometer { get; set; }
        public string? code { get; set; }
        public string? altitude { get; set; }
        public int? ignition { get; set; }
        public int? batery { get; set; }
        public string? course { get; set; }
         */
        #region VARIABLES PRIVADAS
        private long supply_chain_id;
        private long id;
        private string plante;
        private string shipment;
        private string transline_name;
        private int transline_id;
        private int legacy_code;
        private string timezone;
        private double latitude;
        private double longitude;
        private int speed;
        private int distance_to_route;
        private int distance_to_end_route;
        private string odometer;
        private string code;
        private string altitude;
        private int ignition;
        private int batery;
        private string course;
        #endregion
        
        #region PROPIEDADES
        public string Token
        {
            get { return txtToken.Text; }
            set { txtToken.Text = value; }
        }
        public string Shipment
        {
            get { return txtShipment.Text; }
            set { txtShipment.Text = value; }
        }
        public DateTime FhStart
        {
            get { return dtpInicial.Value; }
            set { dtpInicial.Value = value; }
        }
        public DateTime FhEnd
        {
            get { return dtpFinal.Value; }
            set { dtpFinal.Value = value; }
        }
        public long SupplyChainId
        {
            get { return supply_chain_id; }
            set { supply_chain_id = value; }
        }
        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Plante
        {
            get { return plante; }
            set { plante = value; }
        }
        public string TranslineName
        {
            get { return transline_name; }
            set { transline_name = value; }
        }
        public int TranslineId
        {
            get { return transline_id; }
            set { transline_id = value; }
        }
        public int LegacyCode
        {
            get { return legacy_code; }
            set { legacy_code = value; }
        }
        public string Timezone
        {
            get { return timezone; }
            set { timezone = value; }
        }
        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }
        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int DistanceToRoute
        {
            get { return distance_to_route; }
            set { distance_to_route = value; }
        }
        public int DistanceToEndRoute
        {
            get { return distance_to_end_route; }
            set { distance_to_end_route = value; }
        }
        public string Odometer
        {
            get { return odometer; }
            set { odometer = value; }
        }
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Altitude
        {
            get { return altitude; }
            set { altitude = value; }
        }
        public int Ignition
        {
            get { return ignition; }
            set { ignition = value; }
        }
        public int Batery
        {
            get { return batery; }
            set { batery = value; }
        }
        public string Course
        {
            get { return course; }
            set { course = value; }
        }
        #endregion
        #region CONSTRUCTOR
        public Tracking()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENTOS
        private async void btnRequest_Click(object sender, EventArgs e)
        {
            //Creamos el listado de Posts a llenar
            List<TrackingInfo> listado = new List<TrackingInfo>();
            Request request = new Request()
            {
                token = txtToken.Text,
                fh_start = dtpInicial.Value,
                fh_end = dtpFinal.Value,
                shipment = txtShipment.Text
            };
            //Instanciamos un objeto Reply
            Reply oReply = new Reply();
            //poblamos el objeto con el método generic Execute
            oReply = await Traking.Execute<List<TrackingInfo>>("https://app.rcontrol.com.mx/jsonapi/get_tracking_info_rest_service_std_test", methodHttp.POST, request, listado);
            //Poblamos el datagridview
            this.dgvTracking.DataSource = oReply.Data;

            // Hacemos visible la busqueda
            tlpBusqueda.Visible = oReply.Data != null ? true : false;

            //Mostramos el statuscode devuelto, podemos añadirle lógica de validación
            MessageBox.Show(oReply.StatusCode);

        }
        private void dgvTracking_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                TrackingInfo trackingInfo = new TrackingInfo()
                {
                    supply_chain_id = Convert.ToInt64(dgvTracking.Rows[e.RowIndex].Cells["supply_chain_id"].Value),
                    id = Convert.ToInt64(dgvTracking.Rows[e.RowIndex].Cells["id"].Value),
                    plante = dgvTracking.Rows[e.RowIndex].Cells["plante"].Value.ToString(),
                    shipment = dgvTracking.Rows[e.RowIndex].Cells["shipment"].Value.ToString(),
                    transline_name = dgvTracking.Rows[e.RowIndex].Cells["transline_name"].Value.ToString(),
                    transline_id = Convert.ToInt32(dgvTracking.Rows[e.RowIndex].Cells["transline_id"].Value),
                    legacy_code = Convert.ToInt32(dgvTracking.Rows[e.RowIndex].Cells["legacy_code"].Value),
                    timezone = dgvTracking.Rows[e.RowIndex].Cells["timezone"].Value.ToString(),
                    latitude = Convert.ToDouble(dgvTracking.Rows[e.RowIndex].Cells["latitude"].Value),
                    longitude = Convert.ToDouble(dgvTracking.Rows[e.RowIndex].Cells["longitude"].Value),
                    speed = Convert.ToInt32(dgvTracking.Rows[e.RowIndex].Cells["speed"].Value),
                    distance_to_route = Convert.ToInt32(dgvTracking.Rows[e.RowIndex].Cells["distance_to_route"].Value),
                    distance_to_end_route = Convert.ToInt32(dgvTracking.Rows[e.RowIndex].Cells["distance_to_end_route"].Value),
                    odometer = dgvTracking.Rows[e.RowIndex].Cells["odometer"].Value.ToString(),
                    code = dgvTracking.Rows[e.RowIndex].Cells["code"].Value.ToString(),
                    altitude = dgvTracking.Rows[e.RowIndex].Cells["altitude"].Value.ToString(),
                    ignition = Convert.ToInt32(dgvTracking.Rows[e.RowIndex].Cells["ignition"].Value),
                    batery = Convert.ToInt32(dgvTracking.Rows[e.RowIndex].Cells["batery"].Value),
                    course = dgvTracking.Rows[e.RowIndex].Cells["course"].Value.ToString(),
                };
            }
        }
        #endregion
    }
}
